using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinActivities.Database;
using XamarinActivities.Model;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E5ContactPage : ContentPage
    {
        private ObservableCollection<Person> _peopleList = new ObservableCollection<Person>();
        public ContactsDb contactsDb = new ContactsDb();
        public Person person;
        public E5ContactPage()
        {
            InitializeComponent();
            //InitContactList();
            InitItemSource();
        }

        private void InitItemSource()
        {
            //lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
            lstContacts.ItemsSource = contactsDb.GetPeople().OrderBy(p => p.FullName);
        }

        private ObservableCollection<Person> InitContactList()
        {
            _peopleList = new ObservableCollection<Person>()
            {
               new Person()
               {
                   Id = 1,
                   FirstName = "Melrose",
                   LastName = "Mejidana",
                   ContactNumber = "09389062548",
                   ImgURL = "https://tinyurl.com/y6klbxdz",
                   Bio = "Luhmeh",
                   Email = "mhelrosemejidana@gmail.com"
               },
               new Person()
               {
                   Id = 2,
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
                   Id = 3,
                   FirstName = "Jasper",
                   LastName = "Orilla",
                   ContactNumber = "0978262548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Life isn’t perfect but your photos can be",
                   Email = "jasper.orilla@gmail.com"
               },
               new Person()
               {
                   Id = 4,
                   FirstName = "Felix",
                   LastName = "Carao",
                   ContactNumber = "09478062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "See the good in the world",
                   Email = "lex.carao@gmail.com"
               },
               new Person()
               {
                   Id = 5,
                   FirstName = "Kyla Gae",
                   LastName = "Calpito",
                   ContactNumber = "09236062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Save turtle",
                   Email = "kyla.gae@gmail.com"
               },
               new Person()
               {
                   Id = 6,
                   FirstName = "Mermellah",
                   LastName = "Angni",
                   ContactNumber = "09369062548",
                   ImgURL = "https://tinyurl.com/y6klbxdz",
                   Bio = "Anong produkto sa marawi? Gyera.",
                   Email = "mermellol@gmail.com"
               },
               new Person()
               {
                   Id = 7,
                   FirstName = "Arnold",
                   LastName = "Mendoza",
                   ContactNumber = "09899062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "No to carbs",
                   Email = "arnold.mendoza@gmail.com"
               },
               new Person()
               {
                   Id = 8,
                   FirstName = "Charles Kenechi",
                   LastName = "Nazareno",
                   ContactNumber = "09789062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "Wake. Play. Slay.",
                   Email = "blast@gmail.com"
               },
               new Person()
               {
                   Id = 9,
                   FirstName = "Dino Angelo",
                   LastName = "Reyes",
                   ContactNumber = "09299062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "I may be a handful but hey you’ve got two hands!",
                   Email = "dinarado@gmail.com"
               },
               new Person()
               {
                   Id = 10,
                   FirstName = "Marc Kenneth",
                   LastName = "Lomio",
                   ContactNumber = "09369062548",
                   ImgURL = "https://tinyurl.com/y29bn4og",
                   Bio = "WALANG HATDOG",
                   Email = "drmkc@gmail.com"
               }
               ,
               new Person()
               {
                   Id = 11,
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
                lstContacts.ItemsSource = contactsDb.GetPeople().Where(p => p.FirstName.ToLower().StartsWith(e.NewTextValue.ToLower())
                                                               || p.LastName.ToLower().StartsWith(e.NewTextValue.ToLower())
                                                               || p.ContactNumber.Contains(e.NewTextValue))
                                                     .OrderBy(p => p.FirstName).ToList();
            }
        }
        
        async void OnDelete_Clicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var personToDelete = (Person)mi.CommandParameter;
            bool answer = await DisplayAlert("Contact List", "Are you sure you want to delete " + personToDelete.FullName + "?", "OK", "Cancel");

            if (answer)
            {
                contactsDb.DeleteContact(personToDelete.Id);
                InitItemSource();

                await DisplayAlert("Contact List", personToDelete.FullName + " successfully deleted", "OK");

                //_peopleList.Remove(personToDelete);
                //lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
            }
        }

        private void ContactListView_Refreshing(object sender, EventArgs e)
        {
            //InitContactList();
            InitItemSource();
        }

        async void ContactListView_Tapped(object sender, ItemTappedEventArgs e)
        {
            var personDetails = (Person) e.Item;
            var detailPage = new E6ContactDetailsPage(personDetails, DeleteContact, UpdateContact);
            await Navigation.PushAsync(detailPage); 
        }

        async void DeleteContact(object sender, Person person)
        {
            contactsDb.DeleteContact(person.Id);
            InitItemSource();

            await DisplayAlert("Contact List", person.FullName + " successfully deleted", "OK");
            await Navigation.PopAsync();

            //_peopleList.Remove(person);
            //lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
        }

        async void OnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new E7AddContactPage(AddContact));
        }

        async void AddContact(object sender, Person person)
        {
            contactsDb.CreateContact(person);
            InitItemSource();

            await DisplayAlert("Contact List", person.FullName + " successfully added", "OK");
            await Navigation.PopAsync();

            //_peopleList.Add(person);
            //lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);
        }

        async void OnUpdate_Clicked(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            var personDetails = (Person)mi.CommandParameter;
            await Navigation.PushAsync(new E7UpdateContactPage(UpdateContact, personDetails));
        }

        async void UpdateContact(object sender, Person person)
        {
            contactsDb.UpdateContact(person);
            InitItemSource();

            await DisplayAlert("Contact List", person.FullName + " successfully updated", "OK");
            await Navigation.PopToRootAsync();

            //var personToUpdate = _peopleList.FirstOrDefault(p => p.FullName.Contains(person.FullName));

            //if(personToUpdate != null)
            //{
            //    personToUpdate.FirstName = person.FirstName;
            //    personToUpdate.LastName = person.LastName;
            //    personToUpdate.ContactNumber = person.ContactNumber;
            //    personToUpdate.Email = person.Email;
            //    personToUpdate.ImgURL = person.ImgURL;
            //    personToUpdate.Bio = person.Bio;
            //}

            //lstContacts.ItemsSource = _peopleList.OrderBy(p => p.FullName);

        }

    }
}