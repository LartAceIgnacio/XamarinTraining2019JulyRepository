using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormExercise.Model;

namespace XamarinFormExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercise10ListViewExercise : ContentPage
    {
        private ObservableCollection<Person> _persons;
        Person oldPerson;

        public Exercise10ListViewExercise()
        {
            
            InitializeComponent();
            _persons = GetPersons();
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
        }

        ObservableCollection<Person> GetPersons()
        {
            return _persons = new ObservableCollection<Person>
            {
                    new Person()
                    {
                        Firstname = "Aaron",
                        Lastname  =  "Custodio",
                        ContactNumber = "09261231345",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "S perm is the best perm #Rubiks"
                        
                      

             },
                    new Person()
                    {
                        Firstname = "Jelmarose",
                        Lastname  =  "De Vera",
                        ContactNumber = "09261231323",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Bayad muna bago baba"


                    },
                    new Person()
                    {
                        Firstname = "Jasper",
                        Lastname  =  "Orilla",
                        ContactNumber = "09321233456",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Marc Kenneth",
                        Lastname  =  "Lomio",
                        ContactNumber = "0942314532",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Melrose",
                        Lastname  =  "Mejidana",
                        ContactNumber = "0952122424",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Platino loves me"
                     

                    },
                    new Person()
                    {
                        Firstname = "Felix Alexander",
                        Lastname  =  "Carao",
                        ContactNumber = "09721231111",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Dino Angelo",
                        Lastname  =  "Reyes",
                        ContactNumber = "09121233456",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Kyla Gae",
                        Lastname  =  "Calpito",
                        ContactNumber = "09821233456",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Charles Kenichi",
                        Lastname  =  "Nazareno",
                        ContactNumber = "09821233456",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Mermellah",
                        Lastname  =  "Angni",
                        ContactNumber = "09821233456",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."


                    },
                    new Person()
                    {
                        Firstname = "Arnold Allan",
                        Lastname  =  "Mendoza",
                        ContactNumber = "09821233456",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Carlsen_Magnus_%2830238051906%29.jpg/220px-Carlsen_Magnus_%2830238051906%29.jpg",
                        Quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."
                    }

            };
        }
  
        private void SearchBar_TextChanged(object sender,TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue.ToLower()))
            {
                ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
            }
            else
            {
                ListviewContacts.ItemsSource = _persons.Where(x => x.Firstname.ToLower().StartsWith(e.NewTextValue.ToLower()) ||
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
            _persons.Remove(person);
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
        }
        async void Edit_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            oldPerson = menuItem.CommandParameter as Person;
            await Navigation.PushAsync(new Exercise10EditContactPerson(oldPerson, onEditContactPerson));
        }
       private void onEditContactPerson(object sender, Person person)
        {
            _persons.Remove(oldPerson);
            _persons.Add(person);
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
        }

        private void PersonListView_Refreshing(object sender, EventArgs e)
        {
            _persons = GetPersons();
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
            ListviewContacts.EndRefresh();
        }

        private void onDeleteContactPerson(object sender, Person person)
        {
            _persons.Remove(person);
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
        }

        async void gotoAddContactPerson(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercise10AddContactPerson(onAddContactPerson));
        }
        private void onAddContactPerson(object sender, Person person)
        {
            _persons.Add(person);
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
        }


    }
}