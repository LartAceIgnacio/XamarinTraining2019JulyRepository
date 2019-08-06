using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinActivities.Model;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E5ContactPage : ContentPage
    {
        private ObservableCollection<Person> _peopleList = new ObservableCollection<Person>();
        private Dictionary<String, String> _colorList = new Dictionary<String, String>()
        {
                { "A", "#ff0000"},
                { "B", "#ff4000"},
                { "C", "#ff8000"},
                { "D", "#ffbf00"},
                { "E", "#bfff00"},
                { "F", "#80ff00"},
                { "G", "#00ff00"},
                { "H", "#00ffbf"},
                { "I", "#0040ff"},
                { "J", "#0000ff"},
                { "K", "#8000ff"},
                { "L", "#ff00ff"},
                { "M", "#f0327e"},
                { "N", "#856364"},
                { "O", "#74807c"},
                { "P", "#295730"},
                { "Q", "#3c0e3d"},
                { "R", "#85780b"},
                { "S", "#662308"},
                { "T", "#ff9eca"},
                { "U", "#9ee8ff"},
                { "V", "#c5ff9e"},
                { "W", "#f2ff9e"},
                { "X", "#822222"},
                { "Y", "#4a638c"},
                { "Z", "#e89c23"}
        };
        public E5ContactPage()
        {
            InitializeComponent();
            InitContactList();
            InitItemSource();
        }

        public void InitColor()
        {
            foreach (var person in _peopleList)
            {
                foreach (var color in _colorList)
                {
                    if (color.Key == person.InitialKey.Substring(0, 1))
                    {
                        person.Color = color.Value;
                    }
                }
            }
        }

        public void InitItemSource()
        {
            InitColor();
            lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
        }
        public ObservableCollection<Person> InitContactList()
        {
            _peopleList = new ObservableCollection<Person>()
            {
               new Person()
               {
                   FirstName = "Melrose",
                   LastName = "Mejidana",
                   ContactNumber = "09389062548"
               },
               new Person()
               {
                   FirstName = "Aaron",
                   LastName = "Custodio",
                   ContactNumber = "09693262548"
               }
               ,
               new Person()
               {
                   FirstName = "Jasper",
                   LastName = "Orilla",
                   ContactNumber = "0978262548"
               },
               new Person()
               {
                   FirstName = "Felix",
                   LastName = "Carao",
                   ContactNumber = "09478062548"
               },
               new Person()
               {
                   FirstName = "Kyla Gae",
                   LastName = "Calpito",
                   ContactNumber = "09236062548"
               },
               new Person()
               {
                   FirstName = "Mermellah",
                   LastName = "Angni",
                   ContactNumber = "09369062548"
               },
               new Person()
               {
                   FirstName = "Arnold",
                   LastName = "Mendoza",
                   ContactNumber = "09899062548"
               },
               new Person()
               {
                   FirstName = "Charles",
                   LastName = "Nazareno",
                   ContactNumber = "09789062548"
               },
               new Person()
               {
                   FirstName = "Dino",
                   LastName = "Reyes",
                   ContactNumber = "09299062548"
               },
               new Person()
               {
                   FirstName = "Marc Kenneth",
                   LastName = "Lomio",
                   ContactNumber = "09369062548"
               }
               ,
               new Person()
               {
                   FirstName = "Jelmarose Grace",
                   LastName = "De Vera",
                   ContactNumber = "09328962548"
               }
            };

            return _peopleList;
        }

        private void SeachBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                InitItemSource();
            }
            else
            {
                var sortedPeople = _peopleList.OrderBy(p => p.FirstName).ToList();
                lstContacts.ItemsSource = sortedPeople.Where(p => p.FirstName.ToLower().StartsWith(e.NewTextValue.ToLower())
                                                               || p.LastName.ToLower().StartsWith(e.NewTextValue.ToLower())
                                                               || p.ContactNumber.Contains(e.NewTextValue));
            }
        }


        async void OnDelete(object sender, EventArgs e)
        {
            var mi = (MenuItem) sender;
            var personToDelete = (Person) mi.CommandParameter;
            bool answer = await DisplayAlert("Contact List", "Are you sure you want to delete " +personToDelete.FullName + "?", "OK", "Cancel");

            if (answer)
            {
                _peopleList.Remove(personToDelete);
                lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
                await DisplayAlert("Contact List", personToDelete.FullName + " successfully deleted", "OK");
            }
        }


        private void ContactListView_Refreshing(object sender, EventArgs e)
        {
            InitContactList();
            InitItemSource();
            lstContacts.EndRefresh();
        }

        //private void ContactListView_Tapped(object sender, ItemTappedEventArgs e)
        //{
        //    var person = (Person) e.Item;
        //    DisplayAlert("Contact List", "You tap: " + person.FullName, "OK");
        //}
    }
}