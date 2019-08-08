using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XAML.Models;

namespace XAML.Database
{
    public class PersonDb
    {
        private SQLiteConnection _sqlconnection;

        public PersonDb()
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

        public void AddUser(Person person)
        {
            _sqlconnection.Insert(person);
        }

        public void DeleteUser(int id)
        {
            _sqlconnection.Delete<Person>(id);
        }
    }
}
