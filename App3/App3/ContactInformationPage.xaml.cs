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
    public partial class ContactInformationPage : ContentPage
    {
        private Contact _contact;
        public ContactInformationPage(Contact contact)
        {
            InitializeComponent();
            _contact = contact;
            this.BindingContext = _contact;
        }

        private async void TlbrDelete_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question",
                "Do you want to delete this contact?", "Yes", "No");
            if (answer == true)
            {
                MessagingCenter.Send<ContentPage, Contact>(this, "Delete", _contact);
                await Navigation.PopAsync(true);
            }
        }
    }
}