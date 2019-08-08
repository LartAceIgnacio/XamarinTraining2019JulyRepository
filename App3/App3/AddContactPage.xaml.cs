using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        private Contact _contact;
        private EventHandler<Contact> _addContactEventHandler;
        private string _newFirstName;
        private string _newLastName;
        private string _newMobileNumber;
        private string _newQuote;
        private string _newEmail;
        public AddContactPage(EventHandler<Contact> addContactEventHandler)
        {
            InitializeComponent();
            this._addContactEventHandler = addContactEventHandler;
        }

        private void TlbrAdd_Clicked(object sender, EventArgs e)
        {
            this._newFirstName = newFirstName.Text.ToString();
            this._newLastName = newLastName.Text.ToString();
            this._newMobileNumber = newMobileNumber.Text.ToString();
            this._newQuote = newQuote.Text.ToString();
            this._newEmail = newEmail.Text.ToString();
            this._contact = new Contact(_newFirstName, _newLastName, _newMobileNumber, _newQuote, _newEmail) { };
            //this._contact = new Contact(newFirstName.Text, newLastName.Text, newMobileNumber.Text, newQuote.Text, newEmail.Text) { };
            //this._contact = new Contact("Lart", "Ignacio", "09177845263", "lart is good", "lart@gmail.com") { };
            this._addContactEventHandler?.Invoke(this, this._contact);
        }
    }
}