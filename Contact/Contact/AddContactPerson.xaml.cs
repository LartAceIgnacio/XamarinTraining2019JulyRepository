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
        public AddContactPerson(EventHandler<Person> addContactEventHandler)
        {
            InitializeComponent();
            _addContactEventHandler = addContactEventHandler;
            
        }
        void AddContact_Clicked(object sender, EventArgs e)
        {
            var newContact = new Person()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                ContactNumber = contactNumber.Text,
                Email = email.Text
            };
            if (firstName.Text == null || lastName.Text == null || contactNumber.Text == null || email.Text == null)
            {
                DisplayAlert("Registration Failed!", "Please Enter All the Fields!", "Ok");
            }
            else
            {
                this._addContactEventHandler?.Invoke(this, newContact);
            }
            
        }
    }
}