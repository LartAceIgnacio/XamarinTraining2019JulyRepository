using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAML.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using XAML.Database;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatabaseExercise : ContentPage
    {

        ObservableCollection<Person> peopleList;
        private PersonDb personDb=new PersonDb();

        public DatabaseExercise()
        {
            InitializeComponent();
            ListRefresh();
        }

        void ListRefresh()
        {
            peopleList = new ObservableCollection<Person>(personDb.GetPeople());
            personListView.ItemsSource = peopleList.OrderBy(p => p.FirstName);
        }


        private void PersonListView_Refreshing(object sender, EventArgs e)
        {
            ListRefresh();
            personListView.EndRefresh();
        }


        void AddContactButton_Clicked(object sender, EventArgs e)
        {
            var people = personDb.GetPeople();
            var addContactPage = new AddContact(AddContact);
            addContactPage.BindingContext = people;
            this.Navigation.PushAsync(addContactPage);
        }

        public void AddContact(object sender, Person person)
        {
            personDb = new PersonDb();
            personDb.AddUser(person);
            this.Navigation.PopAsync();
            ListRefresh();
        }

        private void DeleteItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var person = menuItem.CommandParameter as Person;
            personDb.DeleteUser(person.Id);
            ListRefresh();
        }


    }
}