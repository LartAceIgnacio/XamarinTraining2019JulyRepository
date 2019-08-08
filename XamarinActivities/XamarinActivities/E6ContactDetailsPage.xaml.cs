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
    public partial class E6ContactDetailsPage : ContentPage
    {
        private Person _personDetails;
        private EventHandler<Person> _deleteEventHandler;
        private EventHandler<Person> _updateEventHandler;
        public E6ContactDetailsPage(Person person, EventHandler<Person> deleteEventHandler, EventHandler<Person> updateEventHandler)
        {
            InitializeComponent();
            _personDetails = person;

            _deleteEventHandler = deleteEventHandler;
            _updateEventHandler = updateEventHandler;
            BindingContext = person;
        }

        async void OnDelete_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Contact List", "Are you sure you want to delete " + _personDetails.FullName + "?", "OK", "Cancel");

            if (answer)
            {
                _deleteEventHandler?.Invoke(this, _personDetails);
            }
        }

        async void OnUpdate_Clicked(object sender, EventArgs e)
        {
           ;
            await Navigation.PushAsync(new E7UpdateContactPage(_updateEventHandler, _personDetails));
        }

        private void OnButtonCall_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Call", "Calling " + _personDetails.FirstName + "...", "Cancel");
        }

        private void OnButtonMessage_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "You message " + _personDetails.FirstName + "!", "OK");
        }
    }
}