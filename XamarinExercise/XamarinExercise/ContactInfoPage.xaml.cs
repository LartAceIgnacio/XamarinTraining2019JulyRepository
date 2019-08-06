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
        public ContactInfoPage(Contacts contact)
        {
            InitializeComponent();
            this.BindingContext = contact;
        }
        void Back_Pop(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
        async void Contact_Delete(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Are you sure?",
                "Would you like to Delete this Contact?", "Yes", "No");
            if (answer == true)
            {
                
            }
        }
    }
}