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
        int id;
        private EventHandler<Contacts> _addContactEventHandler;
        public AddContactPage(EventHandler<Contacts> addContactEventHandler, int id)
        {
            InitializeComponent();
            this.id = id;
            _addContactEventHandler = addContactEventHandler;
        }
        void Submit_Clicked(object sender, EventArgs e)
        {
            var newContact = new Contacts()
            {
                id = this.id,
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