﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Quote { get; set; }
        public string Email { get; set; }
        //public Contact(string firstName, string lastName, string phoneNumber, string quote, string email)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.PhoneNumber = phoneNumber;
        //    this.Quote = quote;
        //    this.Email = email;
        //}
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
