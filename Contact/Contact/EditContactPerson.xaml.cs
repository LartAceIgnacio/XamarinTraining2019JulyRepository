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
    public partial class EditContactPerson : ContentPage
    {
        private EventHandler<Person> _editContactEventHandler;
        public ContactDb contactDb;
        public Person contact;
        public EditContactPerson(Person contact, EventHandler<Person> editContactEventHandler)
        {
            InitializeComponent();
            this.contact = contact;
            this.BindingContext = contact;
            this._editContactEventHandler = editContactEventHandler;
        }

        void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            
            if (firstName.Text == null || lastName.Text == null || contactNumber.Text == null || email.Text == null)
            {
                DisplayAlert("Registration", "Please Enter All the Fields!", "Ok");
            }
            else
            {

                contact.FirstName = firstName.Text;
                contact.LastName = lastName.Text;
                contact.ContactNumber = contactNumber.Text;
                contact.Email = email.Text;
                this._editContactEventHandler?.Invoke(this, contact);
            }
        }
    }
}