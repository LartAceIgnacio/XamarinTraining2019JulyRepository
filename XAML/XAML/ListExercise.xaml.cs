using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAML.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercise : ContentPage
    {

        ObservableCollection<Person> DeletedList = new ObservableCollection<Person>();
        public ListExercise()
        {
            InitializeComponent();
            InitialList();
            
        }

        private ObservableCollection<Person> InitialList()
        {
            ObservableCollection<Person> People = new ObservableCollection<Person>
            {
                new Person
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNumber = "09123456789",
                    ImageUrl = "@drawable/aaron.jpg"

                },
                new Person
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNumber = "09123456790",
                    ImageUrl = "@drawable/jasper.jpg"
                },
                new Person
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNumber = "09123456791",
                    ImageUrl = "@drawable/felix.jpg"
                },
                new Person
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNumber = "09123456792",
                    ImageUrl = "@drawable/kyla.jpg"
                },
                new Person
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNumber = "09123456793",
                    ImageUrl = "@drawable/mermellah.jpg"
                },
                new Person
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNumber = "09123456794",
                    ImageUrl = "@drawable/arnold.jpg"
                },
                new Person
                {
                    FirstName = "Charles Kenichi",
                    LastName = "Nazareno",
                    ContactNumber = "09123456795",
                    ImageUrl = "@drawable/charles.jpg"
                },
                new Person
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNumber = "09957505763"
                },
                new Person
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    ContactNumber = "09123456797",
                    ImageUrl = "@drawable/melrose.jpg"
                },
                new Person
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNumber = "09123456798",
                    ImageUrl = "@drawable/mkc.jpg"
                },
                new Person
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNumber = "09123456799",
                    ImageUrl = "@drawable/jelma.jpg"
                },
            };
            personListView.ItemsSource = People.OrderBy(p => p.FirstName);
            DeletedList = People;
            return People;
        }

        

        ObservableCollection<Person> SearchContacts(string searchText = null)
        {
            if (String.IsNullOrWhiteSpace(searchText))
            {
                return InitialList();
            }
            else
            {
                var searchPeople = InitialList().Where(p => p.FullName.ToLower().Contains(searchText.ToLower()) || p.ContactNumber.Contains(searchText));
                ObservableCollection<Person> filteredPeople = new ObservableCollection<Person>(searchPeople);
                return filteredPeople;
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _people = SearchContacts(e.NewTextValue).OrderBy(p => p.FirstName);
            personListView.ItemsSource = _people;
        }

        private void DeleteItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var person = menuItem.CommandParameter as Person;
            DeletedList.Remove(person);
            personListView.ItemsSource = DeletedList.OrderBy(p => p.FirstName);
            
        }

        private void PersonListView_Refreshing(object sender, EventArgs e)
        {
            InitialList();
            personListView.EndRefresh();
        }


        async void PersonListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Person person = e.SelectedItem as Person;
            var page = new ContactPage(person);
            page.BindingContext = person;
            await Navigation.PushAsync(page);
        }
    }
}