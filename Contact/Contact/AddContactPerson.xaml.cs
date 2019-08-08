using Contact.Database;
using Contact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class AddContactPerson : ContentPage
    {
        private EventHandler<Person> _addContactEventHandler;
        public ContactDb contactDb;
        public Person person;
        public AddContactPerson(Person person, EventHandler<Person> addContactEventHandler)
        {
            _addContactEventHandler = addContactEventHandler;
        }
        void AddContact_Clicked(object sender, EventArgs e)
        {
            var newContact = new Person()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Email = email.Text
            };
            this._addContactEventHandler?.Invoke(this, newContact);
        }
    }
}