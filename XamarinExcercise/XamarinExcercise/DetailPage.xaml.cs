using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExcercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private Person _person;
        private EventHandler<Person> _deleteContactDetailEventHandler;
        public DetailPage(Person person,EventHandler<Person> deleteContactDetailEventHandler)
        {
            InitializeComponent();
            this._person = person;
            this.BindingContext = person;
            this._deleteContactDetailEventHandler = deleteContactDetailEventHandler;
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Delete", String.Format("Do you want to delete {0}", _person.FullName),"Yes","No");
            if (answer)
            {
                _deleteContactDetailEventHandler?.Invoke(this, _person);
                await Navigation.PopModalAsync();
            }
        }
    }
}