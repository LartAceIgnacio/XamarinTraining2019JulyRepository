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
            MessagingCenter.Subscribe<ContentPage, Contact>(this, "Delete", (sender, arg) =>
            {
                _contactList.Remove(arg);
            });
        }

        ObservableCollection<Contact> GetContactList()
        {
            ObservableCollection<Contact> initialList = new ObservableCollection<Contact>
            {
                new Contact("Aaron", "Custodio", "09176967845", "I do not know where family doctors acquired illegibly perplexing handwriting; nevertheless, extraordinary pharmaceutical intellectuality, counterbalancing indecipherability, transcendentalizes intercommunications' incomprehensibleness.", "aaroncustodio@gmail.com"){ },
                new Contact("Jasper", "Orilla", "09175214789", "jasper is the masper", "jasperorilla@gmial.com"){ },
                new Contact("Lex", "Carao", "0917965978", "You can quote them, disagree with them, glorify or vilify them.", "drlexan123213@gmail.com"){ },
                new Contact("Kyla", "Calpito", "09177894321", "angulord is my name, angular is my game", "kylacalpits@gmail.com"){ },
                new Contact("Mermellah", "Angni", "09171254698", "sorisorisori", "mermellah@gmail.com"){ },
                new Contact("Arnold", "Mendoza", "09173216540", "*nagsosolve pa ng 7x7*", "arnoldmendoza@gmail.com"){ },
                new Contact("Charles", "Nazareno", "09174563215", "nani mo nani mo", "charlesnazareno@gmail.com"){ },
                new Contact("Dino", "Reyes", "09175641289", "hoy", "dinoreyes@gmail.com"){ },
                new Contact("Melrose", "Mejidana", "09174678913", "Hindi kami ni Lomi", "melrosemeji@gmail.com"){ },
                new Contact("Hangsome", "Lomio", "09176547821", "Dalawa lang ang masarap sa mundo", "drmkcthehandsome@gmail.com"){ },
                new Contact("Jelmarose", "Grace", "09177845263", "ano?", "jemlarose@gmail.com"){ }
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
            DisplayAlert("This contact has been deleted", _contact.FullName, "OK");
            contactList.ItemsSource = new ObservableCollection<Contact>(this._contactList.OrderBy(x => x.FirstName));
        }

        private async void ContactList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Contact contact = e.Item as Contact;
            await Navigation.PushAsync(new ContactInformationPage(contact));
        }

        async private void TlbrAdd_Clicked(object sender, EventArgs e)
        {
            var addContactPage = new AddContactPage(AddContact);
            await Navigation.PushAsync(addContactPage);
        }

        public void AddContact(object sender, Contact contact)
        {
            this._contactList.Add(contact);
            contactList.ItemsSource = new ObservableCollection<Contact>(this._contactList.OrderBy(x=>x.FirstName)); 
            this.Navigation.PopAsync();
        }

        async private void Update_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var _contact = menuItem.CommandParameter as Contact;
            //_contact.FullName = "Updated";
            //contactList.ItemsSource = _contactList;
            var updateContactPage = new UpdateContactPage(_contact);
            await this.Navigation.PushAsync(updateContactPage);
            contactList.ItemsSource = new ObservableCollection<Contact>(this._contactList.OrderBy(x => x.FirstName));
        }
    }
}