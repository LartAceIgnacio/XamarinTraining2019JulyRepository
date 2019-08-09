using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string FirstName { get; set; }
        [NotNull]
        public string LastName { get; set; }
        [NotNull]
        public string PhoneNumber { get; set; }
        [NotNull]
        public string Quote { get; set; }
        [NotNull]
        public string Email { get; set; }

        public string GetInitials
        {
            get
            {
                return string.Format("{0}{1}", this.FirstName[0], this.LastName[0]);
            }
        }
        public string GetBackgroundColor
        {
            get
            {
                return ColorList.ColorsList[this.FirstName.ToLower()[0]];
            }
        }
        public string FullName
        {
            get
            { 
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }   
    }
}
