using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXamarin.Contacts.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin.Contacts.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactView : ContentPage
    {
        private EventHandler<Person> _addNewContact;

        public AddContactView(EventHandler<Person> addNewContact)
        {
            InitializeComponent();

            _addNewContact = addNewContact;
        }
    }
}