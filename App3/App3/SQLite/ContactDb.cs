using App3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App3.SQLite
{
    public class ContactDb
    {
        private SQLiteConnection _sqlconnection;

        public ContactDb()
        {
            _sqlconnection = DependencyService.Get<ISqlite>().GetConnection();
            _sqlconnection.CreateTable<Contact>();
        }

        public IEnumerable<Contact> GetContacts()
        {
            return (from t in _sqlconnection.Table<Contact>()
                    select t).ToList();
        }

        public Contact GetContact(int id)
        {
            return _sqlconnection.Table<Contact>().FirstOrDefault(t => t.Id == id);
        }

        public void AddContact(Contact contact)
        {
            _sqlconnection.Insert(contact);
        }

        public void DeleteContact(int id)
        {
            _sqlconnection.Delete<Contact>(id);
        }

        public void DeleteAll()
        {
            _sqlconnection.DeleteAll<Contact>();
        }

        public IEnumerable<Contact> SearchContact(string searchString)
        {
            return _sqlconnection.Table<Contact>().Where(t => 
            t.FirstName.ToLower().Contains(searchString)||
            t.LastName.ToLower().Contains(searchString));
        }

        public void UpdateContact(Contact contact)
        {
            _sqlconnection.Update(contact);
        }
    }
}
