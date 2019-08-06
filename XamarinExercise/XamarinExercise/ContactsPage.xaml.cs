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
        ObservableCollection<Contacts> contactSearchList;
        public ContactsPage()
        {
            InitializeComponent();
            contactList=GetContacts();
            contactListView.ItemsSource = contactList.OrderBy(c => c.FirstName);
        }
        ObservableCollection<Contacts> GetContacts()
        {
            var contacts = new ObservableCollection<Contacts>() {
                new Contacts() { FirstName = "Jelma Grace", LastName = "DeVera", ContactNo = "09111111111"},
                new Contacts() { FirstName = "Aaron Edwigg", LastName = "Custodio", ContactNo = "0922222222" },
                new Contacts() { FirstName = "Mark Kenneth", LastName = "Lomio", ContactNo = "09333333333" },
                new Contacts() { FirstName = "Melrose", LastName = "Mejidana", ContactNo = "09444444444" },
                new Contacts() { FirstName = "Felix Alexander", LastName = "Carao", ContactNo = "09555555555" },
                new Contacts() { FirstName = "Dino Angelo", LastName = "Reyes", ContactNo = "09666666666" },
                new Contacts() { FirstName = "Charles Kenichi", LastName = "Nazareno", ContactNo = "09777777777" },
                new Contacts() { FirstName = "Kyla Gae", LastName = "Calpito", ContactNo = "09888888888" },
                new Contacts() { FirstName = "Arnold", LastName = "Mendoza", ContactNo = "09999999999" },
                new Contacts() { FirstName = "Mermela", LastName = "Angni", ContactNo = "09101010101" }
            };
            return contacts;
        }
        ObservableCollection<Contacts> Filter(string searchText=null)
        {
            contactSearchList = contactList;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return contactList;
            }
            else
            {
                var filter = contactSearchList.Where(c => c.FullName.ToLower().Contains(searchText.ToLower())).OrderBy(c => c.FirstName).ToList();
                ObservableCollection<Contacts> filteredContacs = new ObservableCollection<Contacts>(filter);
                return filteredContacs;
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
            contactList = Filter(e.NewTextValue);
            contactListView.ItemsSource = contactList.OrderBy(c=>c.FirstName);
        }
    }
}