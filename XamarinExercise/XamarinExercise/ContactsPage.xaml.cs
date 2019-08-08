using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExercise.Models;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        ObservableCollection<Contacts> contactList;
        public ContactsPage()
        {
            InitializeComponent();
            contactList=GetContacts();
            contactListView.ItemsSource = contactList.OrderBy(c => c.FirstName);
            MessagingCenter.Subscribe<ContactInfoPage, Contacts>(this, "delete this", (sender, contact)=>
            {
                contactList.Remove(contact);
                contactListView.ItemsSource = contactList;
                DisplayAlert("Delete Success",contact.FullName + " Has been Deleted", "Ok");
            });
        }
        ObservableCollection<Contacts> GetContacts()
        {
            var contacts = new ObservableCollection<Contacts>() {
                new Contacts() { FirstName = "Jelma Grace", LastName = "DeVera", ContactNo = "09111111111", Address="Pasig City", EmailAddress="jelmaGD@gmail.com", Birthday="January 28"},
                new Contacts() { FirstName = "Aaron Edwigg", LastName = "Custodio", ContactNo = "0922222222", Address="Cavite City", EmailAddress="aaronEC@gmail.com", Birthday="January 11" },
                new Contacts() { FirstName = "Mark Kenneth", LastName = "Lomio", ContactNo = "09333333333", Address="Cainta, Rizal", EmailAddress="mKc@gmail.com", Birthday="December 11"  },
                new Contacts() { FirstName = "Melrose", LastName = "Mejidana", ContactNo = "09444444444", Address="Cainta, Rizal", EmailAddress="mKc@gmail.com", Birthday="March 26" },
                new Contacts() { FirstName = "Felix Alexander", LastName = "Carao", ContactNo = "09555555555", Address="Pasig City", EmailAddress="lex@gmail.com", Birthday="April 23" },
                new Contacts() { FirstName = "Dino Angelo", LastName = "Reyes", ContactNo = "09666666666", Address="Pasig City", EmailAddress="dinorado@gmail.com", Birthday="Junly 19" },
                new Contacts() { FirstName = "Charles Kenichi", LastName = "Nazareno", ContactNo = "09777777777", Address="Cavite City", EmailAddress="blazt@gmail.com", Birthday="December 6" },
                new Contacts() { FirstName = "Kyla Gae", LastName = "Calpito", ContactNo = "09888888888", Address="Makati City", EmailAddress="kyla@gmail.com", Birthday="December 4" },
                new Contacts() { FirstName = "Arnold", LastName = "Mendoza", ContactNo = "09999999999", Address="Batangas City", EmailAddress="rnold@gmail.com", Birthday="OCtober 11" },
                new Contacts() { FirstName = "Mermela", LastName = "Angni", ContactNo = "09101010101", Address="Marawi City", EmailAddress="gerald@gmail.com", Birthday="February 29" }
            };
            return contacts;
        }
        ObservableCollection<Contacts> Filter(string searchText=null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return contactList;
            }
            else
            {
                var filter = contactList.Where(c => c.FullName.ToLower().Contains(searchText.ToLower())).OrderBy(c => c.FirstName).ToList();
                ObservableCollection<Contacts> filteredContacts = new ObservableCollection<Contacts>(filter);
                return filteredContacts;
            }
        }
        
        async void Delete_Clicked(object sender, EventArgs e)
        {
            var contacItem = sender as MenuItem;
            var contact = contacItem.CommandParameter as Contacts;
            bool answer = await DisplayAlert("Are you sure?",
                "Would you like to Delete this Contact?", "Yes", "No");
            if (answer== true)
            {
                contactList.Remove(contact);
                contactListView.ItemsSource = contactList.OrderBy(c => c.FirstName);
            }     
        }

        void ContactList_Refreshing(object sender, EventArgs e)
        {
            contactList = GetContacts();
            contactListView.ItemsSource = contactList.OrderBy(c => c.FirstName);
            contactListView.EndRefresh();
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            ObservableCollection<Contacts> searchList;
            searchList = Filter(e.NewTextValue);
            contactListView.ItemsSource = searchList.OrderBy(c=>c.FirstName);
        }


        async void ContactItem_Tapped(object sender, ItemTappedEventArgs e)
        {
            Contacts contact = e.Item as Contacts;
            var contactInfo= new ContactInfoPage(contact);
            await this.Navigation.PushAsync(contactInfo);
        }

        async void Contact_Add(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddContactPage(Add_Contact));
        }

        async void Add_Contact(object sender, Contacts contact)
        {
            this.contactList.Add(contact);
            await DisplayAlert("Added "+contact.FirstName,
                contact.FullName+" Has been added to your Contacts", "Ok");
            await this.Navigation.PopAsync();
            contactListView.ItemsSource = contactList.OrderBy(c=>c.FirstName);
        }
    }
}