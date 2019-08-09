using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinEssentials.Exercises.Models;

namespace XamarinEssentials.Exercises.Database
{
    public class ContactDb
    {
        private SQLiteConnection _sqlconnection;

        public ContactDb()
        {
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Contact>();
        }

        public IEnumerable<Contact> GetContacts()
        {
            return (from table in _sqlconnection.Table<Contact>()
                    select table).ToList();
        }

        public Contact GetContact(int id)
        {
            return _sqlconnection.Table<Contact>().FirstOrDefault(t => t.Id == id);
        }

        public void AddContact(Contact contact)
        {
            _sqlconnection.Insert(contact);
        }

        public void UpdateContact(Contact contact)
        {
            _sqlconnection.Update(contact);
        }

        public void DeleteContact(int id)
        {
            _sqlconnection.Delete<Contact>(id);
        }
    }   
}
