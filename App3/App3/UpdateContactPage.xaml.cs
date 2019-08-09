using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.SQLite;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateContactPage : ContentPage
    {
        private EventHandler<Contact> _updateContactEventHandler;
        public ContactDb contactDb;
        private Contact _contact;
        public UpdateContactPage(Contact contact, EventHandler<Contact> updateContactEventHandler)
        {
            InitializeComponent();
            _contact = contact;
            this.BindingContext = _contact;
            _updateContactEventHandler = updateContactEventHandler;
        }

        private void TlbrUpdate_Clicked(object sender, EventArgs e)
        {
            this._updateContactEventHandler?.Invoke(this, this._contact);
        }
    }
}