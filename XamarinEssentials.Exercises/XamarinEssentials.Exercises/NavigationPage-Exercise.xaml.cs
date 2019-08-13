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
        private readonly Contact contact;
        private readonly EventHandler<Contact> _deleteContactEventHandler;

        public NavigationPage_Exercise(Contact item, EventHandler<Contact> deleteContactEventHandler)
        {
            InitializeComponent();

            contact = item;
            this._deleteContactEventHandler = deleteContactEventHandler;

            ciAvatar.Source = contact.AvatarUrl;
            lblName.Text = contact.FullName;
            lblContactNo.Text = contact.ContactNumber;
            lblEmail.Text = contact.Email;
            lblBirthday.Text = contact.Birthday;
        }

        private async void TlbrDelete_Clicked(object sender, EventArgs e)
        {
            string confirmDeleteMessage = string.Format("Delete {0} from contact list?", contact.FullName);

            bool answer = await DisplayAlert("Confirm Action", confirmDeleteMessage, "Yes", "No");

            if (answer)
            {
                this._deleteContactEventHandler?.Invoke(this, this.contact);
                await this.Navigation.PopAsync();
            }
        }
    }
}