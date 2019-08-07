using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinActivities.Models;

namespace XamarinActivities.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewContactPage : ContentPage
    {
        private Contact _contact;
        public ViewContactPage(Contact contact)
        {
            InitializeComponent();
            this.BindingContext = contact;
            _contact = contact;
        }

        private void Close_MenuItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        async private void Delete_MenuItem_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Delete", "Are you sure you want to delete " + _contact.FullName, "Yes", "Cancel");
            if(answer)
            {
                MessagingCenter.Send(this, "Delete", _contact);
                await Navigation.PopModalAsync();
            }
        }
    }
}