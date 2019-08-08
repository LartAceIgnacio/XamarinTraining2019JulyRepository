using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExcercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactFormPage : ContentPage
    {
        private EventHandler<Person> _addContactEventHandler;
        public ContactFormPage(EventHandler<Person> addContactEventHandler)
        {
            InitializeComponent();
            this._addContactEventHandler = addContactEventHandler;
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            Person newPerson = new Person()
            {
                FirstName = FName.Text,
                LastName = LName.Text,
                ContactNumber = ContactNum.Text
            };
            this._addContactEventHandler?.Invoke(this, newPerson);
            await Navigation.PopModalAsync();

        }
    }
}