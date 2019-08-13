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
    public partial class ContactInformationPage : ContentPage
    {
        private EventHandler<Contact> _deleteContactEventHandler;
        private EventHandler<Contact> _updateContactEventHandler;
        public ContactDb contactDb;
        private Contact _contact;

        public ContactInformationPage(Contact contact, EventHandler<Contact> deleteContactEventHandler, EventHandler<Contact> updateContactEventHandler)
        {
            InitializeComponent();
            _contact = contact;
            this.BindingContext = _contact;
            _deleteContactEventHandler = deleteContactEventHandler;
            _updateContactEventHandler = updateContactEventHandler;
        }

        private async void TlbrDelete_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question",
                "Do you want to delete this contact?", "Yes", "No");
            if (answer == true)
            {
                this._deleteContactEventHandler?.Invoke(this, this._contact);
            }
        }

        async private void TlbrUpdate_Clicked(object sender, EventArgs e)
        {
            var updateContactPage = new UpdateContactPage(_contact, _updateContactEventHandler);
            await this.Navigation.PushAsync(updateContactPage);
        }
    }
}