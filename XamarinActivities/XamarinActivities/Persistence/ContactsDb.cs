using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Xamarin.Forms;
using XamarinActivities.Models;
using XamarinActivities.Util;
using XamarinActivities.ViewModel;

namespace XamarinActivities.Db
{
    public class ContactsDb
    {
        private SQLiteConnection connection;

        public ContactsDb()
        {
            connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            connection.CreateTable<ContactViewModel>();
        }

        public ObservableCollection<ContactViewModel> GetContacts()
        {
            var contacts = connection.Table<ContactViewModel>().OrderBy(c => c.FirstName).ToList();
            return new ObservableCollection<ContactViewModel>(contacts);
        }

        public ObservableCollection<ContactViewModel> AddContact(ContactViewModel contact)
        {
            connection.Insert(contact);
            return GetContacts();
        }

        public ObservableCollection<ContactViewModel> DeleteContact(ContactViewModel contact)
        {
            connection.Delete<ContactViewModel>(contact.Id);
            return GetContacts();
        }

        public ObservableCollection<ContactViewModel> UpdateContact(ContactViewModel contact, ContactViewModel newContact)
        {
            newContact.Id = contact.Id;
            connection.Update(newContact);
            return GetContacts();
        }
    }
}
