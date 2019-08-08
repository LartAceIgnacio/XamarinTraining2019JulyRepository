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
        private int _id;
        public E7AddContactPage(EventHandler<Person> addContactEventHandler, int id)
        {
            InitializeComponent();
            _addContactEventHandler = addContactEventHandler;
            _id = id;
        }

        private void OnAddToContacts_Clicked(object sender, EventArgs e)
        {
            var _personDetails = new Person
            {
                Id = _id,
                FirstName = entryFirstName.Text,
                LastName = entryLastName.Text,
                ContactNumber = entryContactNumber.Text,
                ImgURL = entryImageURL.Text,
                Email = entryEmail.Text,
                Bio = editorBio.Text
            };
            _addContactEventHandler?.Invoke(this, _personDetails);
        }
    }
}