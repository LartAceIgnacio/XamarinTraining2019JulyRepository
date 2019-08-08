using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Contacts.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Image { get; set; }
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
        public string Initials
        {
            get
            {
                return String.Format("{0}{1}", FirstName[0], LastName[0]);
            }
        }
        public string Color
        {
            get
            {
                return "#0093ff";
            }
        }
    }
}
