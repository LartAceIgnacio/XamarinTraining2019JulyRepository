using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAML.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercise : ContentPage
    {
        public ListExercise()
        {
            InitializeComponent();

            #region List of Persons
            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNumber = "09123456789"
                },
                new Person
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNumber = "09123456790"
                },
                new Person
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNumber = "09123456791"
                },
                new Person
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNumber = "09123456792"
                },
                new Person
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNumber = "09123456793"
                },
                new Person
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNumber = "09123456794"
                },
                new Person
                {
                    FirstName = "Charles Kenichi",
                    LastName = "Nazareno",
                    ContactNumber = "09123456795"
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
                    ContactNumber = "09123456797"
                },
                new Person
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNumber = "09123456798"
                },
                new Person
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNumber = "09123456799"
                },
            };
            personListView.ItemsSource = people;
            #endregion
        }
    }
}