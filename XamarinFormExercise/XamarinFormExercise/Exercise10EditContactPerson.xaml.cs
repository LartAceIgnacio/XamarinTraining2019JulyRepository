using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormExercise.Model;

namespace XamarinFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise10EditContactPerson : ContentPage
    {
        Person _person;

        EventHandler<Person> _onEditContactPersonEventHandler;
        public Exercise10EditContactPerson(Person person, EventHandler<Person> onEditContactPersonEventHandler)
        {
            this._person = person;
            this._onEditContactPersonEventHandler = onEditContactPersonEventHandler;
            InitializeComponent();
            ExistingFirstname.Text = person.Firstname;
            ExistingLastname.Text = person.Lastname;
            ExistingContactNumber.Text = person.ContactNumber;
            ExistingImageUrl.Text = person.Image;
            ExistingQuote.Text = person.Quote;

        }
        async void UpdateContactPerson(object sender, EventArgs e)
        {
            string firstName = ExistingFirstname.Text;
            string lastName = ExistingLastname.Text;
            string contact = ExistingContactNumber.Text;
            string imageUrl = ExistingImageUrl.Text;
            string quote = ExistingQuote.Text;
            if(firstName == "" || firstName == null || lastName == "" || lastName == null ||
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
                  Id = _person.Id,
                  Firstname = firstName,
                  Lastname = lastName,
                  ContactNumber = contact,
                  Image = imageUrl,
                  Quote = quote
              };
                this._onEditContactPersonEventHandler?.Invoke(this, this._person);
                await this.Navigation.PopAsync(false);

            }
           
        }
    }
}