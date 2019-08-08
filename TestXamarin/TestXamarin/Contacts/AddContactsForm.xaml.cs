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
    public partial class AddContactsForm : ContentPage
    {
        private EventHandler<Person> _addNewContact;

        public AddContactsForm(EventHandler<Person> addNewContact)
        {
            InitializeComponent();
            _addNewContact = addNewContact;

            this.entryFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            this.entryLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            Person newContact = new Person();
            newContact.FirstName = this.entryFirstName.Text;
            newContact.LastName = this.entryLastName.Text;
            newContact.ContactNo = this.entryContactNo.Text;

            this._addNewContact?.Invoke(this, newContact);
        }
    }
}