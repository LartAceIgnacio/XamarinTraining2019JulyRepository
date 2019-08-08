using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinExercise.Models;

namespace XamarinExercise.Database
{

    public class ContactsDb
    {
        private SQLiteConnection _sqlconnection;

        public ContactsDb()
        {
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Contacts>();
        }

        public IEnumerable<Contacts> GetUsers()
        {
            return (from c in _sqlconnection.Table<Contacts>()
                    select c).ToList();
        }

        public Contacts GetContacts(int id)
        {
            return _sqlconnection.Table<Contacts>().FirstOrDefault(c => c.id == id);
        }

        public void AddContact(Contacts contact)
        {
            _sqlconnection.Insert(contact);
        }

        public void UpdateContact(Contacts contact)
        {
            _sqlconnection.Update(contact);
        }

        public void DeleteContact(int id)
        {
            _sqlconnection.Delete<Contacts>(id);
        }
    }
}
