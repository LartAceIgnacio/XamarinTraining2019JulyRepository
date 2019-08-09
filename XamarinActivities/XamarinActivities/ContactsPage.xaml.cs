using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinActivities.Models;
using XamarinActivities.ContactsPages;
using XamarinActivities.Db;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        ObservableCollection<Contact> _contacts;
        Contact TappedContact;
        ContactsDb contactsDb = new ContactsDb();

        public ContactsPage()
        {
            InitializeComponent();
            _contacts = getContacts();
            contactsList.ItemsSource = _contacts;
        }

        ObservableCollection<Contact> getContacts()
        {
            #region Old Implementation
            //var contacts = new ObservableCollection<Contact>()
            //{
            //    new Contact("Melrose", "Mejidana", "09999999989", "melrose@blastasia.com", "facebook.com/melrose", "instagram.com/melrose") { },
            //    new Contact("Arnold Allan", "Mendoza", "09999999998", "arnold@blastasia.com", "facebook.com/arnold", "instagram.com/arnold") { },
            //    new Contact("Charles Kenichi", "Nazareno", "09999999997", "charles@blastasia.com", "facebook.com/charles", "instagram.com/charles") { },
            //    new Contact("Dino Angelo", "Reyes", "09999999996", "dino@blastasia.com", "facebook.com/dino", "instagram.com/dino") { },
            //    new Contact("Mermellah", "Angni", "09999999988", "mermellah@blastasia.com", "facebook.com/mermellah", "instagram.com/mermellah") { },
            //    new Contact("Aaron Edwigg", "Custodio", "09999999999", "aaron@blastasia.com", "facebook.com/aaron", "instagram.com/aaron") { },
            //    new Contact("Felix Alexander", "Carao", "09999999995", "felix@blastasia.com", "facebook.com/felix", "instagram.com/felix") { },
            //    new Contact("Jasper", "Orilla", "09999999994", "jasper@blastasia.com", "facebook.com/jasper", "instagram.com/jasper") { },
            //    new Contact("Kyla Gae", "Calpito", "09999999991", "kyla@blastasia.com", "facebook.com/kyla", "instagram.com/kyla") { },
            //    new Contact("Jelmarose Grace", "De Vera", "09999999993", "jelmarose@blastasia.com", "facebook.com/jelmarose", "instagram.com/jelmarose") { },
            //    new Contact("Marc Kenneth", "Lomio", "09999999990", "marc@blastasia.com", "facebook.com/marc", "instagram.com/marc") { },
            //};

            //return new ObservableCollection<Contact>(contacts.OrderBy(c => c.FirstName)); 
            #endregion
            return contactsDb.GetContacts();
        }

        ObservableCollection<Contact> filterContacts(string searchText = null)
        {

            if (String.IsNullOrEmpty(searchText))
            {
                return new ObservableCollection<Contact>(_contacts.OrderBy(c => c.FirstName));
            }
            else
            {
                var filteredContactsList = _contacts.Where(c => c.FullName.ToLower().Contains(searchText.ToLower()) ||
                                                           c.MobileNumber.Contains(searchText.ToLower()))
                                                   .ToList()
                                                   .OrderBy(c => c.FirstName);
                return new ObservableCollection<Contact>(filteredContactsList);
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            contactsList.ItemsSource = filterContacts(e.NewTextValue);
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DeleteContact(null, contact);
        }

        private void ContactsList_Refreshing(object sender, EventArgs e)
        {
            _contacts = getContacts();
            contactsList.ItemsSource = _contacts;
            contactsList.EndRefresh();
        }
        
        private void ContactsList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            TappedContact = contact;
            contactsList.SelectedItem = null;
            ViewContactPage viewPage = new ViewContactPage(contact, DeleteContact, EditContact);
            Navigation.PushModalAsync(new NavigationPage(viewPage));
        }

        private void AddUser_Clicked(object sender, EventArgs e)
        {
            AddContactPage addPage = new AddContactPage(AddContact);
            Navigation.PushModalAsync(new NavigationPage(addPage));
        }

        private void DeleteContact(object sender, Contact contact)
        {
            _contacts = contactsDb.DeleteContact(contact);
            contactsList.ItemsSource = _contacts;
        }

        private void AddContact(object sender, Contact contact)
        {
            //_contacts.Add(contact);
            //_contacts = new ObservableCollection<Contact>(_contacts.OrderBy(c => c.FirstName).ToList());
            //contactsList.ItemsSource = _contacts;
            _contacts = contactsDb.AddContact(contact);
            contactsList.ItemsSource = _contacts;
        }

        private void EditContact(object sender, Contact newContact)
        {
            contactsDb.UpdateContact(TappedContact, newContact);
        }
    }
}