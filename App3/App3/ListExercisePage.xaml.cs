using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App3.Models;
using System.Collections.ObjectModel;
using App3.SQLite;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercisePage : ContentPage
    {
        public ContactDb contactDb;
        //private ObservableCollection<Contact> _contactList;

        public ListExercisePage()
        {
            
            InitializeComponent();
            //_contactList = GetContactList();
            //MessagingCenter.Subscribe<ContentPage, Contact>(this, "Delete", (sender, arg) =>
            //{
            //    _contactList.Remove(arg);
            //});
            contactDb = new ContactDb();
            contactDb.DeleteAll();
            contactDb.AddContact(new Contact()
            {
                FirstName="Aaron",
                LastName="Custodio",
                PhoneNumber="09179854875",
                Email="aaron@bai.com",
                Quote="ay-ayron the 3x3 god"
            });
            contactDb.AddContact(new Contact()
            {
                FirstName = "Jasper",
                LastName = "Orilla",
                PhoneNumber = "09179854175",
                Email = "jaspern@bai.com",
                Quote = "ajsper the master"
            });
            contactDb.AddContact(new Contact()
            {
                FirstName = "Lex",
                LastName = "Carao",
                PhoneNumber = "09176995978",
                Email = "kedx@bai.com",
                Quote = "ella talaga"
            });
            contactList.ItemsSource = contactDb.GetContacts();
        } 

        private void ContactList_Refreshing(object sender, EventArgs e)
        {
            contactDb = new ContactDb();
            contactList.ItemsSource = contactDb.GetContacts();
            contactList.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            contactDb = new ContactDb();
            string _searchString = e.NewTextValue.ToLower(); 
            contactList.ItemsSource = contactDb.SearchContact(_searchString);
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            contactDb = new ContactDb();
            var menuItem = sender as MenuItem;
            var _contact = menuItem.CommandParameter as Contact;
            contactDb.DeleteContact(_contact.Id);
            DisplayAlert("This contact has been deleted", _contact.FullName, "OK");
            contactList.ItemsSource = contactDb.GetContacts();
        }

        private void DeleteFromInformationPage(object sender, Contact contact)
        {
            contactDb = new ContactDb();
            contactDb.DeleteContact(contact.Id);
            contactList.ItemsSource = contactDb.GetContacts();
            this.Navigation.PopAsync();
        }

        private async void ContactList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Contact contact = e.Item as Contact;
            var contactInformationPage = new ContactInformationPage(contact, DeleteFromInformationPage);
            await Navigation.PushAsync(contactInformationPage);
        }

        async private void TlbrAdd_Clicked(object sender, EventArgs e)
        {
            var addContactPage = new AddContactPage(AddContact);
            await Navigation.PushAsync(addContactPage);
        }

        public void AddContact(object sender, Contact contact)
        {
            contactDb = new ContactDb();
            contactDb.AddContact(contact);
            contactList.ItemsSource = contactDb.GetContacts();
            this.Navigation.PopAsync();
        }

        private void UpdateInformation(object sender, Contact contact)
        {
            contactDb = new ContactDb();
            contactDb.UpdateContact(contact);
            contactList.ItemsSource = contactDb.GetContacts();
            this.Navigation.PopAsync();
        }

        async private void Update_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var _contact = menuItem.CommandParameter as Contact;
            var updateContactPage = new UpdateContactPage(_contact, UpdateInformation);
            await this.Navigation.PushAsync(updateContactPage);
        }
    }
}