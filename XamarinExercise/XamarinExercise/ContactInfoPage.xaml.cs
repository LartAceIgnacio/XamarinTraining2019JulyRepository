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
        public ContactInfoPage(Contacts contact)
        {
            InitializeComponent();
            this.contact = contact;
            //btnBack.Clicked += Back_Pop;
            this.BindingContext = contact;
        }
        void Back_Pop(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        async void Contact_Delete(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Are you sure?",
                "Would you like to Delete this Contact1?", "Yes", "No");
            if (answer == true)
            {
                await this.Navigation.PopModalAsync();
                MessagingCenter.Send<ContactInfoPage, Contacts>(this, "delete this", contact);
            }
        }
    }
}