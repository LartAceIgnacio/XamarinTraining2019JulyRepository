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
        public ContactPage(Person person)
        {
            InitializeComponent();
            this.BindingContext = person;
            _person = person;
            lblFullName.Text = person.FullName;
            lblContact.Text = person.ContactNumber;
            imgContact.Source = person.ImageUrl;
        }

        private void TlbrDelete_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "Delete", _person);
        }
    }
}