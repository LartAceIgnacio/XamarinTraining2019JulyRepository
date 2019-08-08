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
            string firstName = ExistingFirstname.GetValue(EntryCell.TextProperty).ToString();
            string lastName = ExistingLastname.GetValue(EntryCell.TextProperty).ToString();
            string contact = ExistingContactNumber.GetValue(EntryCell.TextProperty).ToString();
            string imageUrl = ExistingImageUrl.GetValue(EntryCell.TextProperty).ToString();
            string quote = ExistingQuote.GetValue(Editor.TextProperty).ToString();
            _person =
               new Person()
               {
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