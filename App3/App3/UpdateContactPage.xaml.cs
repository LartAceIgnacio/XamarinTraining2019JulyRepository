using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.SQLite;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateContactPage : ContentPage
    {
        private EventHandler<Contact> _updateContactEventHandler;
        public ContactDb contactDb;
        private Contact _contact;

        public UpdateContactPage(Contact contact, EventHandler<Contact> updateContactEventHandler)
        {
            InitializeComponent();
            _contact = contact;
            this.BindingContext = _contact;
            _updateContactEventHandler = updateContactEventHandler;
        }

        async private void TlbrUpdate_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newFirstName.Text) || String.IsNullOrEmpty(newLastName.Text) || String.IsNullOrEmpty(newMobileNumber.Text) || String.IsNullOrEmpty(newEmail.Text) || String.IsNullOrEmpty(newQuote.Text))
            {
                await DisplayAlert("Alert", "All fields must be answered", "Ok");
            }
            else
            {
                this._updateContactEventHandler?.Invoke(this, this._contact);
            }      
        }
    }
}