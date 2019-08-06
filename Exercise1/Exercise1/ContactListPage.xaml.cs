using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercise1.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListPage : ContentPage
    {
        ObservableCollection<Person> contactList;
        ObservableCollection<Person> filterGroup;
        
        public ContactListPage()
        {
            InitializeComponent();

            contactList = GetPeople();
            contactListView.ItemsSource = contactList;
        }
        ObservableCollection<Person> GetPeople(string searchText = null)
        {
            contactList = new ObservableCollection<Person>
            {
                new Person()
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNumber = "0999999999"
                },
                new Person()
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Charles Kenichi",
                    LastName = "Nazareno",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    ContactNumber = "0999999998"
                },
                new Person()
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNumber = "0999999998"
                },
            };
            var list = contactList;
            if (String.IsNullOrWhiteSpace(searchText))
            {
                return contactList;
            }
            else
            {
                var filter = list.Where(p => p.FullName.ToLower().Contains(searchText.ToLower()) || p.ContactNumber.ToLower().Contains(searchText.ToLower()));
                ObservableCollection<Person> filterGroup = new ObservableCollection<Person>(filter);
                return filterGroup;
            }
            
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Person;

            bool confirm = await DisplayAlert("Delete Contact", "Are you sure to delete this?", "Yes", "No");

            if (confirm == true)
            {
                contactList.Remove(contact);
            }
            
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            filterGroup = GetPeople(e.NewTextValue);
            contactListView.ItemsSource = filterGroup;
        }

        private void ContactListView_Refreshing(object sender, EventArgs e)
        {
            contactList = GetPeople();
            contactListView.ItemsSource = contactList;
            contactListView.EndRefresh();
        }
    }
}