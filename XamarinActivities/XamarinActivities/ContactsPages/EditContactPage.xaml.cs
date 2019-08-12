using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void FirstName_Unfocused(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(firstName.Text))
            {
                Error_FirstName.Text = "This field is required.";
            }
            else
            {
                Error_FirstName.Text = "";
            }
            SaveButton_Disabled();
        }

        private void LastName_Unfocused(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(lastName.Text))
            {
                Error_LastName.Text = "This field is required.";
            }
            else
            {
                Error_LastName.Text = "";
            }
            SaveButton_Disabled();
        }

        private void MobileNumber_Unfocused(object sender, EventArgs e)
        {
            var mobileNumberPattern = @"(\+?\d{2}?\s?\d{3}\s?\d{3}\s?\d{4})|([0]\d{3}\s?\d{3}\s?\d{4})";
            if (String.IsNullOrWhiteSpace(mobileNumber.Text) || !Regex.IsMatch(mobileNumber.Text, mobileNumberPattern))
            {
                Error_MobileNumber.Text = "Invalid mobile number.";
            }
            else
            {
                Error_MobileNumber.Text = "";
            }
            SaveButton_Disabled();
        }

        private void EmailAddress_Unfocused(object sender, EventArgs e)
        {
            var emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (String.IsNullOrWhiteSpace(emailAddress.Text) || !Regex.IsMatch(emailAddress.Text, emailPattern))
            {
                Error_EmailAddress.Text = "Invalid email address.";
            }
            else
            {
                Error_EmailAddress.Text = "";
            }
            SaveButton_Disabled();
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

        private void SaveButton_Disabled()
        {
            if (String.IsNullOrWhiteSpace(firstName.Text) || String.IsNullOrWhiteSpace(lastName.Text) || String.IsNullOrWhiteSpace(mobileNumber.Text))
            {
                saveButton.IsEnabled = false;
            }
            else
            {
                saveButton.IsEnabled = true;
            }
        }
    }
}