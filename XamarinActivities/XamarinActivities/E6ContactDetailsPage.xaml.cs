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
        public E6ContactDetailsPage(Person person)
        {
            InitializeComponent();
            _personDetails = person;
            BindingContext = person;
        }

        async void OnDelete_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Contact List", "Are you sure you want to delete " + _personDetails.FullName + "?", "OK", "Cancel");

            if (answer)
            {
                //var contactPage = new E5ContactPage(_personDetails);
                //await Navigation.PushModalAsync(new NavigationPage(contactPage));
                //MessagingCenter.Subscribe<MainPage, string>(this, "Hi", _personDetails.FirstName);
                //MessagingCenter.Send<E6ContactDetailsPage, Person>(this, "AnchorsName", _personDetails);
                await Navigation.PopAsync();
                MessagingCenter.Send<E6ContactDetailsPage, Person>(this, "Delete", _personDetails);
            }
        }
    }
}