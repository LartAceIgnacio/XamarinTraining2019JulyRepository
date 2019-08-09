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
        public ContactDb contactDb;
        private Contact _contact;
        public ContactInformationPage(Contact contact, EventHandler<Contact> deleteContactEventHandler)
        {
            InitializeComponent();
            _contact = contact;
            this.BindingContext = _contact;
            _deleteContactEventHandler = deleteContactEventHandler;
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
        //async private void TlbrUpdate_Clicked(object sender, EventArgs e)
        //{
        //    var menuItem = sender as MenuItem;
        //    //_contact.FullName = "Updated";
        //    //contactList.ItemsSource = _contactList;
        //    var updateContactPage = new UpdateContactPage(_contact);
        //    await this.Navigation.PushAsync(updateContactPage);
        //}
    }
}