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
    public partial class E7UpdateContactPage : ContentPage
    {
        EventHandler<Person> _updateContactEventHandler;
        Person _personDetails;
        public E7UpdateContactPage(EventHandler<Person> updateContactEventHandler, Person personDetails)
        {
            InitializeComponent();
            _updateContactEventHandler = updateContactEventHandler;
            _personDetails = personDetails;

            BindingContext = _personDetails;

            SetKeyboard();
        }

        private void SetKeyboard()
        {
            entryFirstName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            entryLastName.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            editorBio.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);
        }

        private void OnUpdateContacts_Clicked(object sender, EventArgs e)
        {
            _updateContactEventHandler?.Invoke(this, _personDetails);
        }
    }
}