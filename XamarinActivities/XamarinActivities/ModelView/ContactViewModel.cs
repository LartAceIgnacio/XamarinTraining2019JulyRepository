using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinActivities.Database;

namespace XamarinActivities.ModelView
{
    public class ContactViewModel : BindableObject
    {
        private ContactsDb contactsDb = new ContactsDb();
        private string _firstname;

        public string FirstName {
            get
            {
                return _firstname;
            }
        }
    }
}
