using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        public Person PersonToDelete { get; set; }
        public E5ContactPage()
        {
            InitializeComponent();
            InitContactList();
            InitItemSource();

            Delete_Subscribe();
        }

        private void Delete_Subscribe()
        {
            MessagingCenter.Subscribe<E6ContactDetailsPage, Person>(this, "Delete", (sender, person) => {
                _peopleList.Remove(person);
                lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
                DisplayAlert("Contact List", person.FullName + " successfully deleted", "OK");
                MessagingCenter.Unsubscribe<E6ContactDetailsPage, Person>(this, "Delete");
            });
        }

        //public E5ContactPage(Person personToDelete)
        //{
        //    InitializeComponent();
        //    InitContactList();
        //    InitItemSource();
        //    Debug.WriteLine(personToDelete.FirstName);

        //    if (personToDelete != null)
        //    {
        //        _peopleList.Remove(personToDelete);
        //        lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
        //        Debug.WriteLine(personToDelete.FullName);
        //        DisplayAlert("Contact List", personToDelete.FullName + " successfully deleted", "OK");
        //    } 
        //}

        private void InitColor()
        {
            foreach (var person in _peopleList)
            {
                foreach (var color in _colorList)
                {
                    var firstLetter = person.InitialKey.Substring(0, 1);
                    if (color.Key == firstLetter)
                    {
                        person.InitialKeyColor = color.Value;
                    }
                }
            }
        }

        private void InitItemSource()
        {
            InitColor();
            lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
        }
        private ObservableCollection<Person> InitContactList()
        {
            _peopleList = new ObservableCollection<Person>()
            {
               new Person()
               {
                   FirstName = "Melrose",
                   LastName = "Mejidana",
                   ContactNumber = "09389062548",
                   ImgURL = "https://tinyurl.com/y6klbxdz",
                   Bio = "Luhmeh",
                   Email = "mhelrosemejidana@gmail.com"
               },
               new Person()
               {
                   FirstName = "Aaron",
                   LastName = "Custodio",
                   ContactNumber = "09693262548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Creating the life of my dreams one day at a time",
                   Email = "aaron.custudio@gmail.com"
               }
               ,
               new Person()
               {
                   FirstName = "Jasper",
                   LastName = "Orilla",
                   ContactNumber = "0978262548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Life isn’t perfect but your photos can be",
                   Email = "jasper.orilla@gmail.com"
               },
               new Person()
               {
                   FirstName = "Felix",
                   LastName = "Carao",
                   ContactNumber = "09478062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "See the good in the world",
                   Email = "lex.carao@gmail.com"
               },
               new Person()
               {
                   FirstName = "Kyla Gae",
                   LastName = "Calpito",
                   ContactNumber = "09236062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Save turtle",
                   Email = "kyla.gae@gmail.com"
               },
               new Person()
               {
                   FirstName = "Mermellah",
                   LastName = "Angni",
                   ContactNumber = "09369062548",
                   ImgURL = "https://tinyurl.com/y6klbxdz",
                   Bio = "Anong produkto sa marawi? Gyera.",
                   Email = "mermellol@gmail.com"
               },
               new Person()
               {
                   FirstName = "Arnold",
                   LastName = "Mendoza",
                   ContactNumber = "09899062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "No to carbs",
                   Email = "arnold.mendoza@gmail.com"
               },
               new Person()
               {
                   FirstName = "Charles Kenechi",
                   LastName = "Nazareno",
                   ContactNumber = "09789062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Wake. Play. Slay.",
                   Email = "blast@gmail.com"
               },
               new Person()
               {
                   FirstName = "Dino Angelo",
                   LastName = "Reyes",
                   ContactNumber = "09299062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "I may be a handful but hey you’ve got two hands!",
                   Email = "dinarado@gmail.com"
               },
               new Person()
               {
                   FirstName = "Marc Kenneth",
                   LastName = "Lomio",
                   ContactNumber = "09369062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "My favorite data type is char",
                   Email = "drmkc@gmail.com"
               }
               ,
               new Person()
               {
                   FirstName = "Jelmarose Grace",
                   LastName = "De Vera",
                   ContactNumber = "09328962548",
                   ImgURL = "https://tinyurl.com/y6klbxdz",
                   Bio = "Single and living my best life",
                   Email = "grace.rose@gmail.com"
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
                lstContacts.ItemsSource = _peopleList.Where(p => p.FirstName.ToLower().StartsWith(e.NewTextValue.ToLower())
                                                               || p.LastName.ToLower().StartsWith(e.NewTextValue.ToLower())
                                                               || p.ContactNumber.Contains(e.NewTextValue))
                                                     .OrderBy(p => p.FirstName).ToList();
            }
        }

        async void OnDelete_Clicked(object sender, EventArgs e)
        {
            var mi = (MenuItem) sender;
            var personToDelete = (Person) mi.CommandParameter;
            bool answer = await DisplayAlert("Contact List", "Are you sure you want to delete " + personToDelete.FullName + "?", "OK", "Cancel");

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

        async void ContactListView_Tapped(object sender, ItemTappedEventArgs e)
        {
            var personDetails = (Person) e.Item;
            var detailPage = new E6ContactDetailsPage(personDetails);
            await Navigation.PushAsync(detailPage);
            
        }
    }
}