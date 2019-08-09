using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormExercise.Database;
using XamarinFormExercise.Model;

namespace XamarinFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise10AddContactPerson : ContentPage
    {
       private Person _person;
        EventHandler<Person> _onAddContactPersonEventHandler;
        public Exercise10AddContactPerson(EventHandler<Person> onAddContactPersonEventHandler)
        {
            this._onAddContactPersonEventHandler = onAddContactPersonEventHandler;
            InitializeComponent();
        }
        async void AddContactPerson(object sender, EventArgs e)
        {
            string firstName = Firstname.Text;
            string lastName = Lastname.Text;
            string contact = ContactNumber.Text;
            string imageUrl = ImageUrl.Text;
            string quote = Quote.Text;
            if (firstName == "" || firstName == null || lastName == "" || lastName == null ||
               contact == "" || contact == null || imageUrl == "" || imageUrl == null ||
               quote == "" || quote == null)
            {
                await DisplayAlert("", "All field is required", "OK");
            }
            else
            {
                _person =
                   new Person()
                   {
                       Firstname = firstName,
                       Lastname = lastName,
                       ContactNumber = contact,
                       Image = imageUrl,
                       Quote = quote
                   };
                this._onAddContactPersonEventHandler?.Invoke(this, this._person);
                await this.Navigation.PopAsync(false);
            }
        }
    }
}