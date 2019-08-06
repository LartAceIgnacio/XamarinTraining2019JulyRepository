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
        private Dictionary<string, string> ColorDictionary = new Dictionary<string, string>();

        public Exercise10ListViewExercise()
        {
            
            InitializeComponent();
            
            _persons = GetPersons();
            GetColor();
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
                        ContactNumber = "09261231345"
                        
                      

             },
                    new Person()
                    {
                        Firstname = "Jelmarose",
                        Lastname  =  "De Vera",
                        ContactNumber = "09261231323"
        

                    },
                    new Person()
                    {
                        Firstname = "Jasper",
                        Lastname  =  "Orilla",
                        ContactNumber = "09321233456"
                       

                    },
                        new Person()
                    {
                        Firstname = "Marc Kenneth",
                        Lastname  =  "Lomio",
                        ContactNumber = "0942314532"
                     

                    },
                            new Person()
                    {
                        Firstname = "Melrose",
                        Lastname  =  "Mejidana",
                        ContactNumber = "0952122424"
                     

                    },
                                new Person()
                    {
                        Firstname = "Felix Alexander",
                        Lastname  =  "Carao",
                        ContactNumber = "09721231111"
                  

                    },
                                    new Person()
                    {
                        Firstname = "Dino Angelo",
                        Lastname  =  "Reyes",
                        ContactNumber = "09121233456"
                     

                    },
                               new Person()
                    {
                        Firstname = "Kyla Gae",
                        Lastname  =  "Calpito",
                        ContactNumber = "09821233456"
                       

                    },
                               new Person()
                    {
                        Firstname = "Charles Kenichi",
                        Lastname  =  "Nazareno",
                        ContactNumber = "09821233456"
                        

                    },           new Person()
                    {
                        Firstname = "Mermellah",
                        Lastname  =  "Angni",
                        ContactNumber = "09821233456"
                      

                    },
                                 new Person()
                    {
                        Firstname = "Arnold Allan",
                        Lastname  =  "Mendoza",
                        ContactNumber = "09821233456"
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
       
        private void PersonListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = e.Item as Person;
            DisplayAlert("Person", person.Firstname + " " + person.Lastname, "OK");
        }
        
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var person = menuItem.CommandParameter as Person;
            _persons.Remove(person);
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
        }

        private void PersonListView_Refreshing(object sender, EventArgs e)
        {
            _persons = GetPersons();
            ListviewContacts.ItemsSource = _persons.OrderBy(contactPerson => contactPerson.Firstname);
            ListviewContacts.EndRefresh();
        }

        private void GetColor()
        {
            ColorDictionary.Add("A", "#800000");
            ColorDictionary.Add("J", "#000000");
            ColorDictionary.Add("M", "#191970");
            ColorDictionary.Add("F", "#800080");
            ColorDictionary.Add("D", "#556B2F");
            ColorDictionary.Add("K", "#006400");
            ColorDictionary.Add("C", "#2F4F4F");
            
          foreach (var selectPerson in _persons)
            {
                foreach (var selectColor in ColorDictionary)
                {
                    if (selectColor.Key == selectPerson.Firstname.Substring(0, 1))
                    {
                        selectPerson.ColorLogo = selectColor.Value;
                    }
                }
            }

        }

    }
}