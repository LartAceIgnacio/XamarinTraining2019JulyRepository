using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinActivities.Model;

namespace XamarinActivities.Database
{
    public class ContactsDb
    {
        private SQLiteConnection _sqlConnection;

        public ContactsDb()
        {
            _sqlConnection = DependencyService.Get<ISqlite>().GetConnection();
            _sqlConnection.CreateTable<Person>();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _sqlConnection.Table<Person>();
        }

        public Person GetPerson(int id)
        {
            return _sqlConnection.Table<Person>().FirstOrDefault(t => t.Id == id);
        }

        public void CreateContact(Person person)
        {
            _sqlConnection.Insert(person);
        }

        public void UpdateContact(Person person)
        {
            _sqlConnection.Update(person);
        }

        public void DeleteContact(int id)
        {
            _sqlConnection.Delete<Person>(id);
        }
    }
}
