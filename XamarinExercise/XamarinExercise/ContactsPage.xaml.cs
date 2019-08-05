using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExercise.Models;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        List<Contacts> contactList;
        List<ContactDisplay> contactDisplay;
        public ContactsPage()
        {
            InitializeComponent();
            contactDisplay = new List<ContactDisplay>();
            contactList = new List<Contacts>() {
                new Contacts() { FirstName = "Jelma Grace", LastName = "DeVera", ContactNo = "09111111111"},
                new Contacts() { FirstName = "Aaron Edwigg", LastName = "Custodio", ContactNo = "0922222222" },
                new Contacts() { FirstName = "Mark Kenneth", LastName = "Lomio", ContactNo = "09333333333" },
                new Contacts() { FirstName = "Melrose", LastName = "Mejidana", ContactNo = "09444444444" },
                new Contacts() { FirstName = "Felix Alexander", LastName = "Carao", ContactNo = "09555555555" },
                new Contacts() { FirstName = "Dino Angelo", LastName = "Reyes", ContactNo = "09666666666" },
                new Contacts() { FirstName = "Charles Kenichi", LastName = "Nazareno", ContactNo = "09777777777" },
                new Contacts() { FirstName = "Kyla Gae", LastName = "Calpito", ContactNo = "09888888888" },
                new Contacts() { FirstName = "Arnold", LastName = "Mendoza", ContactNo = "09999999999" },
                new Contacts() { FirstName = "Mermela", LastName = "Angni", ContactNo = "09101010101" }
            };
            
            foreach(var contact in contactList)
            {
                contactDisplay.Add(new ContactDisplay()
                {
                    FullName = contact.FirstName + " " + contact.LastName,
                    ContactNo = contact.ContactNo,
                    Initials = contact.FirstName[0].ToString()+contact.LastName[0].ToString()
                });
            }
            contactListView.ItemsSource = contactDisplay;
        }
    }
}