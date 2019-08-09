using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TestXamarin.Contacts.Model;

namespace TestXamarin.Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsInfo : ContentPage
    {
        private EventHandler<Person> _deleteContact;
        private Person _person;
        public ContactsInfo(Person p, EventHandler<Person> DeleteContact)
        {
            InitializeComponent();
            this.ContactInfo.BindingContext = p;
            _person = p;
            _deleteContact = DeleteContact;
        }

        private async void BtnDeleteContact_Clicked(object sender, EventArgs e)
        {
            string title = "Delete contact?";
            string message = String.Format("Are you sure you want to delete {0} from your contacts?", _person.FullName);
            string accept = "OK";
            string cancel = "Cancel";
            bool confirm = await DisplayAlert(title, message, accept, cancel);
            if (confirm)
            {
                this._deleteContact?.Invoke(this, _person);
            }
        }
    }
}