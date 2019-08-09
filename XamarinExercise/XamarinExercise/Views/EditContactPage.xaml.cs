using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExercise.Models;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditContactPage : ContentPage
    {
        Contacts contact;
        private EventHandler<Contacts> _editContactEventHandler;
        public EditContactPage(Contacts contact, EventHandler<Contacts> editContactEventHandler)
        {
            InitializeComponent();
            this.contact = contact;
            this.BindingContext = contact;
            birthday.Date = DateTime.Parse(contact.Birthday);
            this._editContactEventHandler = editContactEventHandler;
        }

        void Submit_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) ||
                string.IsNullOrWhiteSpace(lastName.Text) ||
                string.IsNullOrWhiteSpace(contactNo.Text) ||
                string.IsNullOrWhiteSpace(address.Text) ||
                string.IsNullOrWhiteSpace(email.Text))
            {
                DisplayAlert("All Fields Are Required", "Please Fill up all the fields", "Ok");
            }
            else
            {
                var editContact = new Contacts()
                {
                    id = contact.id,
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    ContactNo = contactNo.Text,
                    Address = address.Text,
                    EmailAddress = email.Text,
                    Birthday = birthday.Date.ToString()
                };
                this._editContactEventHandler?.Invoke(this, editContact);
            }
        }
    }
}