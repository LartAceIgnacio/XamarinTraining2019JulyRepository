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
        public ContactProfilePage(Person contact, EventHandler<Person> deleteContactEventHandler)
        {
            InitializeComponent();
            this.contact = contact;
            this.BindingContext = contact;
            this._deleteContactEventHandler = deleteContactEventHandler;

        }

        private void DeleteContact_Clicked(object sender, EventArgs e)
        {
            this._deleteContactEventHandler?.Invoke(this, this.contact);
        }
    }
}
