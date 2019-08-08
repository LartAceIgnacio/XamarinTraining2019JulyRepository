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
    public partial class Exercise10ContactPage : ContentPage
    {
        Person _Contactperson;
        EventHandler<Person> _deleteContactPersonEventHandler;

        public Exercise10ContactPage(Person Selectedperson, EventHandler<Person> deleteContactPersonEventHandler)
        {
            InitializeComponent();
            this._Contactperson = Selectedperson;
            this._deleteContactPersonEventHandler = deleteContactPersonEventHandler;
            selectPersonImage.Source = Selectedperson.Image;
            selectPersonQuote.Text =   Selectedperson.Quote;
            selectPersonFullname.Text = Selectedperson.Fullname;
            selectPersonContactNumber.Text = "Contact: " + Selectedperson.ContactNumber;
            _Contactperson =  Selectedperson;
        }
        async void onDeleteContactPerson(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Are you do you want to delete?", _Contactperson.Fullname, "Yes", "No");
            if (answer == true)
            {
                // await Navigation.PopAsync(false);
                // MessagingCenter.Send<Exercise10ContactPage, Person>(this, "Delete", _Contactperson);
                this._deleteContactPersonEventHandler?.Invoke(this, this._Contactperson);
                await this.Navigation.PopAsync();
            }
           


        }
    }
}