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
    public partial class FormsAndSettings_Bonus : ContentPage
    {
        private readonly Contact _contact;
        private readonly EventHandler<Contact> _editContactEventHandler;

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        public FormsAndSettings_Bonus(Contact contact, EventHandler<Contact> editContactEventHandler)
        {
            InitializeComponent();

            this._contact = contact;
            this._editContactEventHandler = editContactEventHandler;

            enFirstName.Text = contact.FirstName;
            enLastName.Text = contact.LastName;
            enContactNo.Text = contact.ContactNumber;
            enEmail.Text = contact.Email;
            dpBirthday.Date = Convert.ToDateTime(contact.Birthday);
            enAvatar.Text = contact.AvatarUrl;
            edQuote.Text = contact.Quote;
        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            var UpdatedContact = new Contact
            {
                Id = _contact.Id,
                FirstName = textInfo.ToTitleCase(enFirstName.Text),
                LastName = textInfo.ToTitleCase(enLastName.Text),
                ContactNumber = enContactNo.Text,
                Email = enEmail.Text,
                Birthday = dpBirthday.Date.ToShortDateString(),
                AvatarUrl = enAvatar.Text,
                Quote = edQuote.Text
            };

            this._editContactEventHandler?.Invoke(this, UpdatedContact);
        }
    }
}