using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinExcercise.Db
{
    public class ContactDb
    {
        private SQLiteConnection _sqlConnection;
        public ContactDb()
        {
            _sqlConnection = DependencyService.Get<ISqlite>().GetConnection();
            _sqlConnection.CreateTable<Person>();
        }

        public IEnumerable<Person> GetContacts()
        {
            var result = _sqlConnection.Table<Person>().ToList();
            return result;
        }
        public Person GetContacts(int id)
        {
            var result = _sqlConnection.Table<Person>().FirstOrDefault(c => c.Id == id);
            return result;
        }
        
        public void AddContact(Person newPerson)
        {
            _sqlConnection.Insert(newPerson);
        }
        public void DeleteContact(int id)
        {
            _sqlConnection.Delete<Person>(id);
        }
    }
}
