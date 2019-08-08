using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAML.Models;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContact : ContentPage
    {
        private readonly EventHandler<Person> _addContactHandler;
        public AddContact(EventHandler<Person> addContactHandler)
        {
            InitializeComponent();
            this._addContactHandler = addContactHandler;
            SetKeyboardSettings();
        }

        private void SetKeyboardSettings()
        {
            entryFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            entryLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            edtrQuote.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);
        }

        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            Person _person = new Person
            {
                FirstName = entryFirstName.Text,
                LastName = entryLastName.Text,
                ContactNumber = entryContact.Text
            };
            this._addContactHandler?.Invoke(this, _person);
        }

    }
}