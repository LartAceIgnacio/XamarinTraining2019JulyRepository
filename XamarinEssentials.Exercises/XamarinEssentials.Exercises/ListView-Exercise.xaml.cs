using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEssentials.Exercises.Models;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Exercise : ContentPage
    {
        ObservableCollection<Contact> ContactList;
        ObservableCollection<Contact> SearchList;
        ObservableCollection<Contact> SortedList;

        public ListView_Exercise()
        {
            InitializeComponent();

            ContactList = new ObservableCollection<Contact>()
            {
                new Contact { FirstName = "Arnold Allan", LastName = "Schwarzenegger", ContactNumber = "09056484757" },
                new Contact { FirstName = "Charles Kenichi", LastName = "Onerazan", ContactNumber = "09156584566" },
                new Contact { FirstName = "Mark Kenneth 'Hangsome'", LastName = "Lomio", ContactNumber = "09056484757" },
                new Contact { FirstName = "Jasper 'Japs'", LastName = "Orilla", ContactNumber = "09056484757" },
                new Contact { FirstName = "Jelmarose 'Grace'", LastName = "DeVera", ContactNumber = "09056484757" },
                new Contact { FirstName = "Felix 'S Perm'", LastName = "Carao", ContactNumber = "09167395531" },
                new Contact { FirstName = "Dino 'Saur' Angelo", LastName = "Reyes", ContactNumber = "09729588734" },
                new Contact { FirstName = "Melrose 'Rosemel'", LastName = "Mejidana", ContactNumber = "09167755498" },
                new Contact { FirstName = "Kyla Gae 'Turtle'", LastName = "Calpito", ContactNumber = "09167395531" },
                new Contact { FirstName = "Mermellah 'lol'", LastName = "Angni", ContactNumber = "0988659931" },
                new Contact { FirstName = "Barry 'Happy'", LastName = "Manilow", ContactNumber = "09285555784" },
                new Contact { FirstName = "Erickson 'Jocson'", LastName = "Reyes", ContactNumber = "09195554491" },
                new Contact { FirstName = "Gerald 'Alder'", LastName = "Anderson", ContactNumber = "09295550240" },
                new Contact { FirstName = "Holly 'Jolly'", LastName = "Mendoza", ContactNumber = "09167395531" },
                new Contact { FirstName = "Irejane 'Ire'", LastName = "Santos", ContactNumber = "0988659931" }
            };

            lstContacts.ItemsSource = SortList(ContactList);
        }

        private void LstContacts_Refreshing(object sender, EventArgs e)
        {
            ContactList = GetContacts();
            lstContacts.ItemsSource = SortList(ContactList);
            lstContacts.EndRefresh();
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            string confirmDeleteMessage = string.Format("Delete {0} from contact list?", contact.FullName);

            bool answer = await DisplayAlert("Confirm Action", confirmDeleteMessage, "Yes", "No");

            if (answer)
            {
                ContactList.Remove(contact);
                lstContacts.ItemsSource = SortList(ContactList);
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchList = GetContacts(e.NewTextValue);
            lstContacts.ItemsSource = SortList(SearchList);
        }

        //private async void ShowConfirmationDialog(string title, string message)
        //{
        //    var answer = await DisplayAlert(title , message, "Yes", "No");

        //}

        ObservableCollection<Contact> SortList(ObservableCollection<Contact> list)
        {
            return SortedList = new ObservableCollection<Contact>(list.OrderBy(c => c.FullName));
        }

        ObservableCollection<Contact> GetContacts()
        {
            return new ObservableCollection<Contact>
            {
                new Contact { FirstName = "Arnold Allan", LastName = "Schwarzenegger", ContactNumber = "09056484757" },
                new Contact { FirstName = "Charles Kenichi", LastName = "Onerazan", ContactNumber = "09156584566" },
                new Contact { FirstName = "Mark Kenneth 'Hangsome'", LastName = "Lomio", ContactNumber = "09056484757" },
                new Contact { FirstName = "Jasper 'Japs'", LastName = "Orilla", ContactNumber = "09056484757" },
                new Contact { FirstName = "Jelmarose 'Grace'", LastName = "DeVera", ContactNumber = "09056484757" },
                new Contact { FirstName = "Felix 'S Perm'", LastName = "Carao", ContactNumber = "09167395531" },
                new Contact { FirstName = "Dino 'Saur' Angelo", LastName = "Reyes", ContactNumber = "09729588734" },
                new Contact { FirstName = "Melrose 'Rosemel'", LastName = "Mejidana", ContactNumber = "09167755498" },
                new Contact { FirstName = "Kyla Gae 'Turtle'", LastName = "Calpito", ContactNumber = "09167395531" },
                new Contact { FirstName = "Mermellah 'lol'", LastName = "Angni", ContactNumber = "0988659931" }
            };
        }

        ObservableCollection<Contact> GetContacts(string searchText = null)
        {
            var list = ContactList;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return ContactList;
            }
            else
            {
                var filteredList = list.Where(
                    contact => contact.FullName.ToLower().Contains(searchText.ToLower()) ||
                               contact.ContactNumber.Contains(searchText)).ToList();
                ObservableCollection<Contact> searchResults = new ObservableCollection<Contact>(filteredList);
                return searchResults;
            }
        }
    }
}