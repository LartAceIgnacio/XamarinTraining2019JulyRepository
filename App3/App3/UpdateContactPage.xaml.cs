using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateContactPage : ContentPage
    {
        private Contact _contact;
        private Contact _updatedContact = new Contact("Lartt", "Ignacio", "09684865123", "Lart is good", "lignacio@blastaisa.com");
        public UpdateContactPage(Contact contact)
        {
            InitializeComponent();
            this.BindingContext = contact;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _contact = _updatedContact;
        }
    }
}