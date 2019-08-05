﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinActivities.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string MobileNumber { get; set; }

        public Contact(string firstName, string lastName, string mobileNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
            MobileNumber = mobileNumber;
        }
    }
}
