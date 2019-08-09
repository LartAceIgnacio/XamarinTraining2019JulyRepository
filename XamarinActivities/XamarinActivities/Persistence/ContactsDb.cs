using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using Xamarin.Forms;
using XamarinActivities.Models;
using XamarinActivities.Util;

namespace XamarinActivities.Db
{
    public class ContactsDb
    {
        private SQLiteConnection connection;

        public ContactsDb()
        {
            connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            connection.CreateTable<Contact>();
        }

        public ObservableCollection<Contact> GetContacts()
        {
            var contacts = connection.Table<Contact>().OrderBy(c => c.FirstName).ToList();
            return new ObservableCollection<Contact>(contacts);
        }

        public ObservableCollection<Contact> AddContact(Contact contact)
        {
            connection.Insert(contact);
            return GetContacts();
        }

        public ObservableCollection<Contact> DeleteContact(Contact contact)
        {
            connection.Delete<Contact>(contact.Id);
            return GetContacts();
        }

        public ObservableCollection<Contact> UpdateContact(Contact contact, Contact newContact)
        {
            newContact.Id = contact.Id;
            connection.Update(newContact);
            return GetContacts();
        }
    }
}
