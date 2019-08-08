using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinFormExercise.Model;

namespace XamarinFormExercise.Database
{
   public class ContactDb
    {
        private SQLiteConnection _sqlConnection;
        public ContactDb()
        {
            _sqlConnection = DependencyService.Get<ISqlite>().GetConnection();
            _sqlConnection.CreateTable<Person>();
        }
        public IEnumerable<Person> GetContactPersons()
        {
            return _sqlConnection.Table<Person>().OrderBy(contact => contact.Firstname).ToList();
        }
        public Person GetContactPerson(int id)
        {
            return _sqlConnection.Table<Person>().FirstOrDefault(contact => contact.Id == id);
        }

        public void UpdateContactPerson(Person personChanges)
        {
            _sqlConnection.Update(personChanges);

        }
        public void AddContactPerson(Person person)
        {
            _sqlConnection.Insert(person);
        }
        public void DeleteContactPerson(int id)
        {
            _sqlConnection.Delete<Person>(id);
        }
    }
}
