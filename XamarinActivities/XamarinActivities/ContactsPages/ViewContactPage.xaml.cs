using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinActivities.Models;

namespace XamarinActivities.ContactsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewContactPage : ContentPage
    {
        private Contact _contact;
        private EventHandler<Contact> DeleteContactEventHandler;
        public ViewContactPage(Contact contact, EventHandler<Contact> deleteContactEventHandler)
        {
            InitializeComponent();
            this.BindingContext = contact;
            this.DeleteContactEventHandler = deleteContactEventHandler;
            _contact = contact;
        }

        async private void Delete_MenuItem_Clicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Delete", "Are you sure you want to delete " + _contact.FullName, "Yes", "Cancel");
            if(answer)
            {
                DeleteContactEventHandler?.Invoke(this, _contact);
                await Navigation.PopModalAsync();
            }
        }
    }
}