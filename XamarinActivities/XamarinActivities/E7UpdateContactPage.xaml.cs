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
    public partial class E7UpdateContactPage : ContentPage
    {
        EventHandler<Person> _updateContactEventHandler;
        Person _personDetails;
        public E7UpdateContactPage(EventHandler<Person> updateContactEventHandler, Person personDetails)
        {
            InitializeComponent();
            _updateContactEventHandler = updateContactEventHandler;
            _personDetails = personDetails;

            BindingContext = _personDetails;

            SetKeyboard();
        }

        private void SetKeyboard()
        {
            entryFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            entryLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            editorBio.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);
        }

        private void OnUpdateContacts_Clicked(object sender, EventArgs e)
        {
            bool isComplete = CheckInput();

            if (isComplete)
            {
                _updateContactEventHandler?.Invoke(this, _personDetails);
            }
            else
            {
                DisplayAlert("", "Please complete the required inputs!", "OK");
            }
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(entryFirstName.Text) || string.IsNullOrEmpty(entryLastName.Text) || string.IsNullOrEmpty(entryContactNumber.Text) || string.IsNullOrEmpty(entryEmail.Text) || string.IsNullOrEmpty(editorBio.Text))
            {
                return false;
            }

            if (entryContactNumber.Text.Length <= 1)
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