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
    public partial class E7AddContactPage : ContentPage
    {
        EventHandler<Person> _addContactEventHandler;
        public E7AddContactPage(EventHandler<Person> addContactEventHandler)
        {
            InitializeComponent();
            _addContactEventHandler = addContactEventHandler;

        }

        private void OnAddToContacts_Clicked(object sender, EventArgs e)
        {
            var _personDetails = new Person
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ContactNumber = txtContactNumber.Text,
                ImgURL = "https://tinyurl.com/y6klbxdz",
                Email = "dhdhd",
                Bio = "gshshs"
            };
            _addContactEventHandler?.Invoke(this, _personDetails);
        }
    }
}