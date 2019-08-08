using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinActivities.Models;

namespace XamarinActivities.ContactsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        private EventHandler<Contact> SaveContactEventHandler;
        public AddContactPage(EventHandler<Contact> saveContactEventHandler)
        {
            InitializeComponent();
            SaveContactEventHandler = saveContactEventHandler;
        }

        private void Close_MenuItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact contact = new Contact(firstName.Text, lastName.Text, mobileNumber.Text, emailAddress.Text, "facebook.com/user", "instagram.com/user");
            SaveContactEventHandler?.Invoke(this, contact);
            Navigation.PopModalAsync();
        }
    }
}