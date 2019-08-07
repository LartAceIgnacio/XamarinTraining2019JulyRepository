using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{    
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
        public string Initials
        {
            get
            {
                return String.Format("{0}{1}", this.FirstName[0], this.LastName[0]);
            }
        }
    }

    public class PeopleList : List<Person>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public PeopleList(string longName, string shortName)
        {
            LongName = longName;
            ShortName = shortName;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts_List : ContentPage
    {
        private ObservableCollection<PeopleList> _results = new ObservableCollection<PeopleList>();
        private readonly Dictionary<char, string> colors = new Dictionary<char, string>()
        {
            { 'A', "#262262" },
            { 'C', "#3D3B30" },
            { 'D', "#629677" },
            { 'F', "#993955" },
            { 'J', "#243E36" },
            { 'K', "#DA3E52" },
            { 'M', "#A30000" },
        };

        private readonly List<Person> unsortedContacts = new List<Person>
        {
            new Person
                {
                    FirstName = "Charles Ken'ichi",
                    LastName = "Nazareno",
                    ContactNo = "297493824"
                },
            new Person
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNo = "2389274832"
                },
            new Person
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNo = "298395723"
                },
            new Person
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNo = "297329"
                },
            new Person
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNo = "30932874"
                },
            new Person
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNo = "09074932"
                },
            new Person
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNo = "09556986121"
                },
            new Person
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNo = "349289"
                },
            new Person
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNo = "238274832"
                },
            new Person
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNo = "289463287"
                },
            new Person
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    ContactNo = "193812942"
                },

        };
        public Contacts_List()
        {
            InitializeComponent();
            var sortedContacts = SortContactsToGroup(unsortedContacts);
            this.ContactsList.ItemsSource = sortedContacts;
        }

        private string GetColor(char c)
        {
            colors.TryGetValue(c, out string color);
            return color;
        }

        private List<PeopleList> SortContactsToGroup(List<Person> unsortedContacts)
        {
            List<PeopleList> contacts = new List<PeopleList>();
            List<Person> sortedContacts = new List<Person>();
            unsortedContacts = unsortedContacts.OrderBy(person => person.FirstName).ToList();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                foreach (var contact in unsortedContacts)
                {
                    if (contact.FirstName[0] == c)
                    {
                        contact.Color = GetColor(contact.FirstName[0]);
                        sortedContacts.Add(contact);
                    }
                }
                if (sortedContacts.Count > 0)
                {
                    var group = new PeopleList(String.Format("Letter {0}", c), String.Format("{0}", c));
                    foreach (Person contact in sortedContacts)
                    {
                        group.Add(contact);
                    }
                    //Reset contents of sortedContacts
                    sortedContacts.Clear();

                    contacts.Add(group);
                }
            }
            return contacts;
        }

        private ObservableCollection<PeopleList> GetSearchResults(string query)
        {
            var contacts = SortContactsToGroup(unsortedContacts);
            var people = new ObservableCollection<PeopleList>(contacts);
            var results = people.Where(group => group.All(
                person => person.FirstName.ToLower().Contains(query.ToLower()) ||
                          person.LastName.ToLower().Contains(query.ToLower()) ||
                          person.ContactNo.Contains(query.ToLower())
            ));
            ObservableCollection<PeopleList> searchResults = new ObservableCollection<PeopleList>(results);
            return searchResults;
        }

        private void ContactSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(e.NewTextValue) || String.IsNullOrWhiteSpace(e.NewTextValue))
            {
                var contacts = SortContactsToGroup(unsortedContacts);
                this.ContactsList.ItemsSource = contacts;
            }
            else
            {
                _results = GetSearchResults(e.NewTextValue);
                this.ContactsList.ItemsSource = _results;
            }
        }

        private void ContactsList_Refreshing(object sender, EventArgs e)
        {
            var contacts = SortContactsToGroup(unsortedContacts);
            this.ContactsList.ItemsSource = contacts;
            this.ContactsList.EndRefresh();
        }
        
        private void DeleteContact(Person person)
        {
            var updatedList = new List<Person>(unsortedContacts);
            updatedList.Remove(person);
            var contacts = SortContactsToGroup(updatedList);
            this.ContactsList.ItemsSource = contacts;
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var person = menuItem.CommandParameter as Person;
            string action = await DisplayActionSheet("Delete contact?", "Cancel", "OK");
            if (action == "OK")
            {
                DeleteContact(person);
                await DisplayAlert("Deleting contact..", "Deleted contact", "OK");
            }
        }

        private async void ContactsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = e.Item as Person;
            var page = new Contact_Details(person);
            await Navigation.PushAsync(page);
            NavigationPage.SetHasNavigationBar(page, false);
        }
    }
}