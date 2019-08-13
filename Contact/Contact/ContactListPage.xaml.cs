﻿using Contact.Database;
using Contact.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListPage : ContentPage
    {
        ObservableCollection<ContactDb> dbContactList = new ObservableCollection<ContactDb>();
        ObservableCollection<Person> contactList = new ObservableCollection<Person>();
        public ContactDb contactDb = new ContactDb();
        public Person person;

        public ContactListPage()
        {
            InitializeComponent();
            List_Refresh();
            
        }
        
            
        async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var dataContact = menuItem.CommandParameter as ContactDb;
            var viewContact = menuItem.CommandParameter as Person;

            bool confirm = await DisplayAlert("Delete Contact", "Are you sure to delete this?", "Yes", "No");

            if (confirm == true)
            {
                this.dbContactList.Remove(dataContact);
                contactDb.DeleteContact(viewContact.Id);
            }
            List_Refresh();
        }
        void List_Refresh()
        {

            var viewContactList = contactDb.GetPeople();
            contactListView.ItemsSource = viewContactList.OrderBy(n => n.FirstName);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            string searchString = e.NewTextValue.ToLower();
            contactListView.ItemsSource = contactDb.SearchPerson(searchString).OrderBy(n => n.FullName);
        }

        private void ContactListView_Refreshing(object sender, EventArgs e)
        {
            List_Refresh();
            contactListView.EndRefresh();
        }
        async void DeleteContactProfile(object sender, Person person)
        {

            bool confirm = await DisplayAlert("Delete Contact",
                "Would you like to Delete this Contact?", "Yes", "No");
            if (confirm == true)
            {
                contactDb.DeleteContact(person.Id);
                await this.Navigation.PopAsync();
                List_Refresh();
            }
        }
        async private void ContactListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Person person = e.Item as Person;
            var contactProfilePage = new ContactProfilePage(person, DeleteContactProfile, EditContactProfile);
            await this.Navigation.PushAsync(contactProfilePage);
        }

        async void EditContactProfile(object sender, Person person)
        {

            this.contactDb.UpdateContact(person);
            await DisplayAlert("Contact Update", person.FirstName + " has updated to your Contacts", "Ok");
            List_Refresh();
            await this.Navigation.PopAsync();
        }

        async void AddContactProfile(object sender, Person person)
        {

            this.contactDb.AddContact(person);
            await DisplayAlert("Contact Added", person.FirstName + " has added to your Contacts", "Ok");
            List_Refresh();
            await this.Navigation.PopAsync();

        }
        async void AddContact_Page(object sender, EventArgs e)
        {
            var addContactPage = new AddContactPerson(AddContactProfile);
            addContactPage.BindingContext = contactList;
            await Navigation.PushAsync(addContactPage);
        }
    }
}