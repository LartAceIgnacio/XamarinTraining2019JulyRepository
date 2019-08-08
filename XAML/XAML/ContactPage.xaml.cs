using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAML.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        private Person _person;
        private EventHandler<Person> _deleteContactHandler;
        public ContactPage(Person person, EventHandler<Person> deleteContactHandler)
        {
            InitializeComponent();
            this.BindingContext = person;
            this._person = person;
            this._deleteContactHandler = deleteContactHandler;

            FillContactDetails(person);

        }

        private void TlbrDelete_Clicked(object sender, EventArgs e)
        {
            this._deleteContactHandler?.Invoke(this, this._person);
        }

        void FillContactDetails(Person person)
        {
            lblFirstName.Text = person.FirstName;
            lblLastName.Text = person.LastName;
            lblContact.Text = person.ContactNumber;
            imgContact.Source = person.ImageUrl;
        }
    }
}