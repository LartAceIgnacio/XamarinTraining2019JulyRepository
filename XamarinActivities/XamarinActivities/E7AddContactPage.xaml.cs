using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinActivities.Model;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E7AddContactPage : ContentPage
    {
        EventHandler<Person> _addContactEventHandler;
        public E7AddContactPage(EventHandler<Person> addContactEventHandler)
        {
            InitializeComponent();
            _addContactEventHandler = addContactEventHandler;

            SetKeyboard();
        }

        private void SetKeyboard()
        {
            entryFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            entryLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            editorBio.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);
        }

        private void OnAddToContacts_Clicked(object sender, EventArgs e)
        {
            bool isComplete = CheckInput();

            if (isComplete)
            {
                var _personDetails = new Person
                {
                    FirstName = entryFirstName.Text,
                    LastName = entryLastName.Text,
                    ContactNumber = entryContactNumber.Text,
                    ImgURL = "https://tinyurl.com/y29bn4og",
                    Email = entryEmail.Text,
                    Bio = editorBio.Text
                };

                _addContactEventHandler?.Invoke(this, _personDetails);
            } else
            {
                DisplayAlert("", "Please complete the required inputs!", "OK");
            }
        }

        private bool CheckInput()
        {
            if ( string.IsNullOrEmpty(entryFirstName.Text) || string.IsNullOrEmpty(entryLastName.Text) || string.IsNullOrEmpty(entryContactNumber.Text) || string.IsNullOrEmpty(entryEmail.Text) || string.IsNullOrEmpty(editorBio.Text))
            {
                return false;
            }

            if ( entryContactNumber.Text.Length <= 1)
            {
                DisplayAlert("", "Too short for a valid contact number! Must be 8-12 in length.", "OK");
                return false;
            }

            if (entryContactNumber.Text.Length >= 12)
            {
                DisplayAlert("", "Too long for a valid contact number! Must be 8-12 in length.", "OK");
                return false;
            }

            return true;
        }
    }
}