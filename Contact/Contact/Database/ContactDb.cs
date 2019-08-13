using Contact.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contact.Database
{
    public class ContactDb
    {
        private SQLiteConnection _sqlconnection;

        public ContactDb()
        {
            _sqlconnection = DependencyService.Get<ISqlite>().GetConnection();
            _sqlconnection.CreateTable<Person>();
        }
        public IEnumerable<Person> GetPeople()
        {
            return (from t in _sqlconnection.Table<Person>()
                    select t).ToList();
        }
        public Person GetPerson(int id)
        {
            return _sqlconnection.Table<Person>().FirstOrDefault(t => t.Id == id);
        }
        public void AddContact(Person person)
        {
            _sqlconnection.Insert(person);
        }
        public void DeleteContact(int id)
        {
            _sqlconnection.Delete<Person>(id);
        }
        public void UpdateContact(Person person)
        {
            _sqlconnection.Update(person);
        }
        public IEnumerable<Person> SearchPerson(string searchText)
        {
            return _sqlconnection.Table<Person>().Where(p => p.FirstName.ToLower().Contains(searchText.ToLower()) || p.ContactNumber.ToLower().Contains(searchText.ToLower()));
        }
    }
}
