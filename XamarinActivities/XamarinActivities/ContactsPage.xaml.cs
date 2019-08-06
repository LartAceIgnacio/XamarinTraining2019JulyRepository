using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinActivities.Models;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        ObservableCollection<Contact> _contacts;

        public ContactsPage()
        {
            InitializeComponent();
            _contacts = getContacts();
            contactsList.ItemsSource = _contacts;
        }

        ObservableCollection<Contact> getContacts()
        {
            var contacts = new ObservableCollection<Contact>()
            {
                new Contact("Melrose", "Mejidana", "09999999989") { },
                new Contact("Arnold Allan", "Mendoza", "09999999998") { },
                new Contact("Charles Kenichi", "Nazareno", "09999999997") { },
                new Contact("Dino Angelo", "Reyes", "09999999996") { },
                new Contact("Mermellah", "Angni", "09999999988") { },
                new Contact("Aaron Edwigg", "Custodio", "09999999999") { },
                new Contact("Felix Alexander", "Carao", "09999999995") { },
                new Contact("Jasper", "Orilla", "09999999994") { },
                new Contact("Kyla Gae", "Calpito", "09999999991") { },
                new Contact("Jelmarose Grace", "De Vera", "09999999993") { },
                new Contact("Marc Kenneth", "Lomio", "09999999990") { },
            };

            return new ObservableCollection<Contact>(contacts.OrderBy(c => c.FirstName));
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
                                                           c.MobileNumber.ToLower().Contains(searchText.ToLower()))
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
            _contacts.Remove(contact);
        }

        private void ContactsList_Refreshing(object sender, EventArgs e)
        {
            _contacts = getContacts();
            contactsList.ItemsSource = _contacts;
            contactsList.EndRefresh();
        }
    }
}