using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

using TestXamarin.Contacts.Database;
using TestXamarin.Contacts.Model;
using System.Windows.Input;

namespace TestXamarin.Contacts.ViewModel
{
    public class AddContactViewModel : BindableObject
    {
        private ContactService _contactsDbConnect = new ContactService();
        private EventHandler<Person> _addNewContact;

        private Person _person;

        private string FirstNameProperty = "FirstName";
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged();
                OnPropertyChanged(FullName);
            }
        }

        private string LastNameProperty = "LastName";
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(FullName);
            }
        }

        private string FullNameProperty = "FullName";
        private string _fullName;
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }

        private string ContactNoProperty = "ContactNo";
        private string _contactNo;
        public string ContactNo
        {
            get { return _contactNo; }
            set
            {
                _contactNo = value;
                OnPropertyChanged();
            }
        }

        private void AddNewContact()
        {
            _person = new Person()
            {
                FirstName = FirstName,
                LastName = LastName,
                ContactNo = ContactNo
            };

            _contactsDbConnect.DbAddContact(_person);
        }

        public ICommand AddNewContactCommand => new Command(AddNewContact);
    }
}
