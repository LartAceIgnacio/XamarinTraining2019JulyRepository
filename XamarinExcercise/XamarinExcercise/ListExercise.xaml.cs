using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExcercise.Db;

namespace XamarinExcercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExercise : ContentPage
    {
        //public List<Person> deletedList = new List<Person>();
        //public List<Person> PersonList;
        private ContactDb _contactDb;
        public ListExercise(ContactDb ContactDb)
        {
            InitializeComponent();
            _contactDb = ContactDb;
            //PersonList = _contactDb.GetContacts().ToList();
            ContactList.ItemsSource = GetContact();
            //GetContact();
            //ContactList.ItemsSource = deletedList.OrderBy(f => f.FirstName);
        }

        private List<Person> GetContact()
        {
            //    List<Person> Persons = new List<Person>()
            //{
            //    new Person(){FirstName= "Aaron Edwigg", LastName="Custodio", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Arnold Allan", LastName="Mendoza", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Jasper", LastName="Orilla", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Felix Alexander", LastName="Carao", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Kyla Gae", LastName="Calpito", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Mermellah", LastName="Angni", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Jelmarose Grace", LastName="De Vera", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Marc Kenneth", LastName="Lomio", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Melrose", LastName="Mejidana", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Dino Angelo", LastName="Reyes", ContactNumber= "1234567"},
            //    new Person(){FirstName= "Charles Kenichi", LastName="Nazareno", ContactNumber= "1234567"},
            //};
            //    deletedList.Clear();
            //    Persons.ForEach(x => deletedList.Add(x));
            //    deletedList = deletedList.OrderBy(f => f.FirstName).ToList();
            //    return deletedList.OrderBy(f => f.FirstName).ToList();

            return _contactDb.GetContacts().OrderBy(c => c.FirstName).ToList();
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = searchString.Text;
            if (String.IsNullOrEmpty(search))
            {
                ContactList.ItemsSource = _contactDb.GetContacts();
            }
            else
            {
                ContactList.ItemsSource = _contactDb.GetContacts().Where(c => c.FullName.ToLower().Contains(search.ToLower()) || c.ContactNumber.ToString().Contains(search)).OrderBy(f => f.FirstName).ToList();

            }
        }

        private void ContactList_Refreshing(object sender, EventArgs e)
        {
            //ContactList.ItemsSource = null;
            ContactList.ItemsSource = GetContact();
            //ContactList.ItemsSource = GetContact();
            ContactList.EndRefresh();
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var item = sender as MenuItem;
            var person = item.CommandParameter as Person;
            //deletedList.Remove(person);
            //ContactList.ItemsSource = deletedList.OrderBy(f => f.FirstName).ToList();
            _contactDb.DeleteContact(person.Id);
            ContactList.ItemsSource = GetContact();
        }
        private async void Add_Clicked(object sender, EventArgs e)
        {
            var addPage = new NavigationPage(new ContactFormPage(AddContact));
            await this.Navigation.PushModalAsync(addPage);
        }

        private async void ContactList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = ((ListView)sender).SelectedItem as Person ;
            var modalPage = new NavigationPage(new DetailPage(person,DeleteContact));
            await this.Navigation.PushModalAsync(modalPage);
        }
        public void DeleteContact(object sender,Person person)
        {
            _contactDb.DeleteContact(person.Id);
            ContactList.ItemsSource = GetContact();

            //this.deletedList.Remove(person);
            //ContactList.ItemsSource = deletedList.ToList();
            //this.Navigation.PopModalAsync();
        }
        public void AddContact(object sender,Person newPerson)
        {
            _contactDb.AddContact(newPerson);
            //this.deletedList.Add(newPerson);
            ContactList.ItemsSource = GetContact();
            //this.ContactList.ItemsSource = deletedList.OrderBy(f => f.FirstName).ToList();
        }
    }


}