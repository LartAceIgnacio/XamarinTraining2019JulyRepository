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
    public partial class EditContactPage : ContentPage
    {
        ContactViewModel _contact;
        private EventHandler<ContactViewModel> EditContactEventHandler;
        public EditContactPage(ContactViewModel contact, EventHandler<ContactViewModel> editContactEventHandler)
        {
            InitializeComponent();
            this.BindingContext = contact;
            _contact = contact;
            EditContactEventHandler = editContactEventHandler;
        }
        async private void Cancel_MenuItem_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Cancel", "Are you sure you want to discard unsaved changes?", "Yes", "Cancel");
            if (answer)
            {
                await Navigation.PopModalAsync();
            }
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            ContactViewModel newContact = new ContactViewModel()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                MobileNumber = mobileNumber.Text,
                EmailAddress = emailAddress.Text,
                FacebookLink = facebookLink.Text,
                InstagramLink = instagramLink.Text
            };
            EditContactEventHandler?.Invoke(this, newContact);
            Navigation.PopModalAsync();
            Navigation.PopModalAsync();
        }
    }
}