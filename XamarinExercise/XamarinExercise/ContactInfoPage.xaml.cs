using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExercise.Models;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactInfoPage : ContentPage
    {
        Contacts contact;
        EventHandler<Contacts> _deleteContactEventHandler;
        private EventHandler<Contacts> _editContactEventHandler;
        public ContactInfoPage(Contacts contact, EventHandler<Contacts> editContactEventHandler,EventHandler<Contacts> deleteContactEventHandler)
        {
            InitializeComponent();
            this.contact = contact;
            _editContactEventHandler = editContactEventHandler;
            _deleteContactEventHandler = deleteContactEventHandler;
            //btnBack.Clicked += Back_Pop;
            this.BindingContext = contact;
        }
        void Back_Pop(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        void Contact_Delete(object sender, EventArgs e)
        {
            this._deleteContactEventHandler?.Invoke(this, this.contact);
        }
        async void Contact_Edit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditContactPage(contact, _editContactEventHandler));
        }
    }
}