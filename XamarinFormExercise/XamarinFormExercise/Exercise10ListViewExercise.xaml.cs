using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    public partial class Exercise10ListViewExercise : ContentPage
    {
        private ObservableCollection<Person> _persons;
        private Person oldPerson;
        private ContactDb contactDb = new ContactDb();


        public Exercise10ListViewExercise()
        {
            
            InitializeComponent();
            GetAllContactPerson();
        }

        
  
        private void SearchBar_TextChanged(object sender,TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue.ToLower()))
            {
                GetAllContactPerson();
            }
            else
            {
                ListviewContacts.ItemsSource = contactDb.GetContactPersons().Where(x => x.Firstname.ToLower().StartsWith(e.NewTextValue.ToLower()) ||
                                                                   x.Lastname.ToLower().StartsWith(e.NewTextValue.ToLower()) ||
                                                                   x.ContactNumber.ToLower().StartsWith(e.NewTextValue.ToLower())).OrderBy(person => person.Firstname);
            }
        }
       
        async void PersonListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            oldPerson = e.Item as Person;
            await Navigation.PushAsync(new Exercise10ContactPage(oldPerson, onDeleteContactPerson));
        }
        
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var person = menuItem.CommandParameter as Person;
            contactDb.DeleteContactPerson(person.Id);
            GetAllContactPerson();
        }
        async void Edit_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            oldPerson = menuItem.CommandParameter as Person;
            await Navigation.PushAsync(new Exercise10EditContactPerson(oldPerson, onEditContactPerson));
            //TODO
        }
       private void onEditContactPerson(object sender, Person person)
        {
            contactDb.UpdateContactPerson(person);
            GetAllContactPerson();
            //TODO
        }

        private void PersonListView_Refreshing(object sender, EventArgs e)
        {
            GetAllContactPerson();
            ListviewContacts.EndRefresh();
        }

        private void onDeleteContactPerson(object sender, Person person)
        {
            contactDb.DeleteContactPerson(person.Id);
            GetAllContactPerson();            
        }

        async void gotoAddContactPerson(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise10AddContactPerson(onAddContactPerson));
        }
        private void onAddContactPerson(object sender, Person person)
        {
            contactDb.AddContactPerson(person);
            GetAllContactPerson();
        }

        private void GetAllContactPerson()
        {
            var contactPersons = contactDb.GetContactPersons();
           ListviewContacts.ItemsSource = contactPersons;
        }

    }
}