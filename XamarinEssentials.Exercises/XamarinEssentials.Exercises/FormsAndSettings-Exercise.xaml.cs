using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEssentials.Exercises.Models;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsAndSettings_Exercise : ContentPage
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        private readonly int _id;
        private readonly EventHandler<Contact> _addContactEventHandler;
        public FormsAndSettings_Exercise(int Id, EventHandler<Contact> addContactEventHandler)
        {
            InitializeComponent();

            this._id = Id;
            this._addContactEventHandler = addContactEventHandler;

            enFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            enLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            var NewContact = new Contact
            {
                Id = _id,
                FirstName = textInfo.ToTitleCase(enFirstName.Text),
                LastName = textInfo.ToTitleCase(enLastName.Text),
                ContactNumber = enContactNo.Text,
                Email = enEmail.Text,
                Birthday = dpBirthday.Date.ToShortDateString(),
                AvatarUrl = enAvatar.Text,
                Quote = edQuote.Text
            };

            this._addContactEventHandler?.Invoke(this, NewContact);
        }
    }
}