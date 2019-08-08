using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinActivities.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Initials { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }

        public Contact(string firstName, string lastName, string mobileNumber, string emailAddress, 
                       string facebookLink, string instagramLink)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
            Initials = firstName[0].ToString().ToUpper() + lastName[0].ToString().ToUpper();
            MobileNumber = mobileNumber;
            EmailAddress = emailAddress;
            FacebookLink = facebookLink;
            InstagramLink = instagramLink;
        }
    }
}
