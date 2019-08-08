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
        }
        ObservableCollection<Contacts> GetContacts()
        {
            var contacts = new ObservableCollection<Contacts>() {
                new Contacts() { id=1, FirstName = "Jelma Grace", LastName = "DeVera", ContactNo = "09111111111", Address="Pasig City", EmailAddress="jelmaGD@gmail.com", Birthday="01/01/1997"},
                new Contacts() { id=2, FirstName = "Aaron Edwigg", LastName = "Custodio", ContactNo = "0922222222", Address="Cavite City", EmailAddress="aaronEC@gmail.com", Birthday="02/02/1997" },
                new Contacts() { id=3, FirstName = "Mark Kenneth", LastName = "Lomio", ContactNo = "09333333333", Address="Cainta, Rizal", EmailAddress="mKc@gmail.com", Birthday="03/03/1996"  },
                new Contacts() { id=4, FirstName = "Melrose", LastName = "Mejidana", ContactNo = "09444444444", Address="Cainta, Rizal", EmailAddress="mKc@gmail.com", Birthday="04/04/1996" },
                new Contacts() { id=5, FirstName = "Felix Alexander", LastName = "Carao", ContactNo = "09555555555", Address="Pasig City", EmailAddress="lex@gmail.com", Birthday="05/05/1996" },
                new Contacts() { id=6, FirstName = "Dino Angelo", LastName = "Reyes", ContactNo = "09666666666", Address="Pasig City", EmailAddress="dinorado@gmail.com", Birthday="06/06/1991" },
                new Contacts() { id=7, FirstName = "Charles Kenichi", LastName = "Nazareno", ContactNo = "09777777777", Address="Cavite City", EmailAddress="blazt@gmail.com", Birthday="07/07/1995" },
                new Contacts() { id=8, FirstName = "Kyla Gae", LastName = "Calpito", ContactNo = "09888888888", Address="Makati City", EmailAddress="kyla@gmail.com", Birthday="08/08/1996" },
                new Contacts() { id=9, FirstName = "Arnold", LastName = "Mendoza", ContactNo = "09999999999", Address="Batangas City", EmailAddress="rnold@gmail.com", Birthday="09/09/1995" },
                new Contacts() { id=10, FirstName = "Mermela", LastName = "Angni", ContactNo = "09101010101", Address="Marawi City", EmailAddress="gerald@gmail.com", Birthday="09/09/2019" }
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
        async void Delete_Contact(object sender, Contacts contact)
        {
            bool answer = await DisplayAlert("Are you sure?",
                "Would you like to Delete this Contact?", "Yes", "No");
            if (answer == true)
            {
                contactList.Remove(contact);
                await this.Navigation.PopAsync();
                contactListView.ItemsSource = contactList.OrderBy(c => c.FirstName);   
            }
        }

        async void Edit_Clicked(object sender, EventArgs e)
        {
            var contacItem = sender as MenuItem;
            var contact = contacItem.CommandParameter as Contacts;
            var contactEdit = new EditContactPage(contact, Edit_Contact);
            await this.Navigation.PushAsync(contactEdit);
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
            var contactInfo= new ContactInfoPage(contact, Edit_Contact,Delete_Contact);
            await this.Navigation.PushAsync(contactInfo);
        }


        async void Contact_Add(object sender, EventArgs e)
        {
            int id=contactList.Count+1;
            await Navigation.PushAsync(new AddContactPage(Add_Contact,id));
        }

        async void Add_Contact(object sender, Contacts contact)
        {
            this.contactList.Add(contact);
            await DisplayAlert("Added "+contact.FirstName,
                contact.FullName+" Has been added to your Contacts", "Ok");
            await this.Navigation.PopAsync();
            contactListView.ItemsSource = contactList.OrderBy(c=>c.FirstName);
        }
        async void  Edit_Contact(object sender, Contacts contact)
        {
            foreach( var c in contactList)
            {
                if (c.id==contact.id)
                {
                    c.FirstName = contact.FirstName;
                    c.LastName = contact.LastName;
                    c.ContactNo = contact.ContactNo;
                    c.Address = contact.Address;
                    c.EmailAddress = contact.EmailAddress;
                    c.Birthday = contact.Birthday;
                    break;
                }
            }
            await DisplayAlert("Edit Successful "," Contact has been updated", "Ok");
            await this.Navigation.PopAsync();
            contactListView.ItemsSource = contactList.OrderBy(c => c.FirstName);
        }
    }
}