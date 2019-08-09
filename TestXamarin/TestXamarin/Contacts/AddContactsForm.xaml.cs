using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TestXamarin.Contacts.Model;

namespace TestXamarin.Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactsForm : ContentPage
    {
        private EventHandler<Person> _addNewContact;
        private readonly String _errorMsg = "This field is required!";

        public AddContactsForm(EventHandler<Person> addNewContact)
        {
            InitializeComponent();
            _addNewContact = addNewContact;

            this.entryFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            this.entryLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);

            /*this.lblContactNoErrorMessage.Text = _errorMsg;
            this.lblFirstNameErrorMessage.Text = _errorMsg;
            this.lblLastNameErrorMessage.Text = _errorMsg;*/
        }
        /*
        private bool IsNewContactComplete(Person newContact)
        {
            if (String.IsNullOrEmpty(newContact.FirstName) || String.IsNullOrWhiteSpace(newContact.FirstName))
            {
                this.lblFirstNameErrorMessage.IsVisible = true;
                return false;
            }
            this.lblFirstNameErrorMessage.IsVisible = false;

            if (String.IsNullOrEmpty(newContact.LastName) || String.IsNullOrWhiteSpace(newContact.LastName))
            {
                this.lblLastNameErrorMessage.IsVisible = true;
                return false;
            }
            this.lblLastNameErrorMessage.IsVisible = false;

            if (String.IsNullOrEmpty(newContact.ContactNo) || String.IsNullOrWhiteSpace(newContact.ContactNo))
            {
                this.lblContactNoErrorMessage.IsVisible = true;
                return false;
            }
            this.lblContactNoErrorMessage.IsVisible = false;

            return true;
        }
        */
        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            Person newContact = new Person();
            newContact.FirstName = this.entryFirstName.Text;
            newContact.LastName = this.entryLastName.Text;
            newContact.ContactNo = this.entryContactNo.Text;

            this._addNewContact?.Invoke(this, newContact);
            /*
            if(IsNewContactComplete(newContact))
            {
            }    
            */
        }
    }
}