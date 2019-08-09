using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinActivities.Models;
using XamarinActivities.ViewModel;

namespace XamarinActivities.ContactsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        private EventHandler<ContactViewModel> SaveContactEventHandler;
        public AddContactPage(EventHandler<ContactViewModel> saveContactEventHandler)
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
            ContactViewModel contact = new ContactViewModel()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                MobileNumber = mobileNumber.Text,
                EmailAddress = emailAddress.Text,
                FacebookLink = "facebook.com/user",
                InstagramLink = "instagram.com/user"
            };
            SaveContactEventHandler?.Invoke(this, contact);
            Navigation.PopModalAsync();
        }
    }
}