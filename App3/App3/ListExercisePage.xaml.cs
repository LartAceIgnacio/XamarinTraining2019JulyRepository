using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App3.Models;
using System.Collections.ObjectModel;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercisePage : ContentPage
    {
        private ObservableCollection<Contact> _contactList;

        public ListExercisePage()
        {
            InitializeComponent();
            _contactList = GetContactList();
            contactList.ItemsSource = _contactList;
        }

        ObservableCollection<Contact> GetContactList()
        {
            ObservableCollection<Contact> initialList = new ObservableCollection<Contact>
            {
                new Contact("Aaron", "Custodio", "09176967845"){ },
                new Contact("Jasper", "Orilla", "09175214789"){ },
                new Contact("Lex", "Carao", "0917965978"){ },
                new Contact("Kyla", "Calpito", "09177894321"){ },
                new Contact("Mermellah", "Angni", "09171254698"){ },
                new Contact("Arnold", "Mendoza", "09173216540"){ },
                new Contact("Charles", "Nazareno", "09174563215"){ },
                new Contact("Dino", "Reyes", "09175641289"){ },
                new Contact("Melrose", "Mejidana", "09174678913"){ },
                new Contact("Hangsome", "Lomio", "09176547821"){ },
                new Contact("Jelmarose", "Grace", "09177845263"){ }
            };
            return new ObservableCollection<Contact>(initialList.OrderBy(contact=>contact.FirstName));
        }  

        private void ContactList_Refreshing(object sender, EventArgs e)
        {
            _contactList = GetContactList();
            contactList.ItemsSource = _contactList;
            contactList.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredContacts = _contactList.Where(contact => contact.FullName
                                                                        .ToLower()
                                                                        .Contains(e.NewTextValue.ToLower()))
                                                                        .ToList()
                                                                        .OrderBy(contact => contact.FirstName);
            contactList.ItemsSource = new ObservableCollection<Contact>(filteredContacts);
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var _contact = menuItem.CommandParameter as Contact;
            _contactList.Remove(_contact);
            DisplayAlert("Delete", _contact.FullName, "OK");
        }
    }
}