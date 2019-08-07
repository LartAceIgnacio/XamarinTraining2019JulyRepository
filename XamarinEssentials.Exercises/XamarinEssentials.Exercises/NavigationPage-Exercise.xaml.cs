using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEssentials.Exercises.Models;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage_Exercise : ContentPage
    {
        private Contact contact;

        public NavigationPage_Exercise(Contact item)
        {
            InitializeComponent();
            btnBack.Clicked += BtnBack_Clicked;

            contact = item;

            ciAvatar.Source = contact.AvatarUrl;
            lblName.Text = contact.FullName;
            lblContactNo.Text = contact.ContactNumber;
            lblEmail.Text = contact.Email;
            lblBirthday.Text = contact.Birthday;
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        private async void TlbrDelete_Clicked(object sender, EventArgs e)
        {
            string confirmDeleteMessage = string.Format("Delete {0} from contact list?", contact.FullName);

            bool answer = await DisplayAlert("Confirm Action", confirmDeleteMessage, "Yes", "No");

            if (answer)
            {
                MessagingCenter.Send<NavigationPage_Exercise, Contact>(this, "delete_contact", contact);
                await this.Navigation.PopModalAsync();
            }
        }
    }
}