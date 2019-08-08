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
            string firstName = Firstname.GetValue(EntryCell.TextProperty).ToString();
            string lastName = Lastname.GetValue(EntryCell.TextProperty).ToString();
            string contact = ContactNumber.GetValue(EntryCell.TextProperty).ToString();
            string imageUrl = ImageUrl.GetValue(EntryCell.TextProperty).ToString();
            string quote = Quote.GetValue(Editor.TextProperty).ToString();
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