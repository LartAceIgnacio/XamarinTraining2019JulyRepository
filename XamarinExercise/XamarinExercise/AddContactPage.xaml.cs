using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExercise.Models;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        private EventHandler<Contacts> _addContactEventHandler;
        public AddContactPage(EventHandler<Contacts> addContactEventHandler)
        {
            InitializeComponent();
            _addContactEventHandler = addContactEventHandler;
        }
        void Submit_Clicked(object sender, EventArgs e)
        {
            var newContact = new Contacts()
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                ContactNo = contactNo.Text,
                Address = address.Text,
                EmailAddress = email.Text,
                Birthday = birthday.Date.ToString()
            };
            this._addContactEventHandler?.Invoke(this, newContact);
        }
    }
}