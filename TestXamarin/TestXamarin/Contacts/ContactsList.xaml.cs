using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TestXamarin.Contacts.Model;

namespace TestXamarin.Contacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsList : ContentPage
    {
        private ObservableCollection<Person> _people = new ObservableCollection<Person>
        {
            new Person
                {
                    FirstName = "Charles Ken'ichi",
                    LastName = "Nazareno",
                    ContactNo = "297493824"
                },
            new Person
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNo = "2389274832"
                },
            new Person
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNo = "298395723"
                },
            new Person
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNo = "297329"
                },
            new Person
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNo = "30932874"
                },
            new Person
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNo = "09074932"
                },
            new Person
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNo = "09556986121"
                },
            new Person
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNo = "349289"
                },
            new Person
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNo = "238274832"
                },
            new Person
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNo = "289463287"
                },
            new Person
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    ContactNo = "193812942"
                },
        };

        public ContactsList()
        {
            InitializeComponent();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}