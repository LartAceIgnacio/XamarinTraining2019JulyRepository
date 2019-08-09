using Contact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactProfilePage : ContentPage
    {
        public Person contact;
        private EventHandler<Person> _deleteContactEventHandler;
        private EventHandler<Person> _editContactEventHandler;
        public ContactProfilePage(Person contact, EventHandler<Person> deleteContactEventHandler, EventHandler<Person> editContactEventHandler)
        {
            InitializeComponent();
            this.contact = contact;
            this.BindingContext = contact;
            this._deleteContactEventHandler = deleteContactEventHandler;
            this._editContactEventHandler = editContactEventHandler;

        }

        private void DeleteContact_Clicked(object sender, EventArgs e)
        {
            this._deleteContactEventHandler?.Invoke(this, this.contact);
        }

        private async void Call_Person_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Call", "Call " + contact.FirstName,  "Call" );
        }

        async void TlbrEdit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditContactPerson(contact, _editContactEventHandler));
        }

        async void Message_Person_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Send Message", "Send Message to " + contact.FirstName, "Send");
        }
    }
}
