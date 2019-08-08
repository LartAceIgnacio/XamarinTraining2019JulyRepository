using SQLite;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TestXamarin.Contacts.Model;
using Xamarin.Forms;

namespace TestXamarin.Contacts.Database
{
    public class ContactService
    {
        private SQLiteConnection _sqlconnection;

        public ContactService()
        {
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Person>();
        }
        public IEnumerable<Person> GetContacts()
        {
            return (from person in _sqlconnection.Table<Person>() select person).ToList();
        }

        public Person GetContact(int id)
        {
            return _sqlconnection.Table<Person>().FirstOrDefault(person => person.Id == id);
        }

        public void AddContact(Person person)
        {
            _sqlconnection.Insert(person);
        }

        public void DeleteContact(int id)
        {
            _sqlconnection.Delete<Person>(id);
        }
    }
}
