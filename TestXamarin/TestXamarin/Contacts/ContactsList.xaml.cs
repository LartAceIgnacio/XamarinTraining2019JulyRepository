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
        AvatarBackground _avatarBGColor = new AvatarBackground();

        private ObservableCollection<Person> _people = new ObservableCollection<Person>
        {
            new Person
                {
                    FirstName = "Charles Ken'ichi",
                    LastName = "Nazareno",
                    ContactNo = "297493824",
                    Color = AvatarBackground.GetColor('C'),
                    Image = "https://avatar.skype.com/v1/avatars/live:nazarenocharleskenichi/public?returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    Color = AvatarBackground.GetColor('A'),
                    ContactNo = "2389274832"
                },
            new Person
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNo = "298395723",
                    Color = AvatarBackground.GetColor('A'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3Adfa057eb515496eb?auth_key=1375881640&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNo = "297329",
                    Color = AvatarBackground.GetColor('D'),
                    Image = "https://avatar.skype.com/v1/avatars/d1noang3lo?auth_key=1277327930&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNo = "30932874",
                    Color = AvatarBackground.GetColor('J'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3Ajasper.orilla915?auth_key=2080568440&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNo = "09074932",
                    Color = AvatarBackground.GetColor('F'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3A5ed07cb7b4b3fb2b?auth_key=201496878&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNo = "09556986121",
                    Color = AvatarBackground.GetColor('J'),
                    Image = "https://avatar.skype.com/v1/avatars/live:jelmarosegracedevera?auth_key=-258509251&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNo = "349289",
                    Color = AvatarBackground.GetColor('M'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3Af8a34600249204b2?auth_key=605533976&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNo = "238274832",
                    Color = AvatarBackground.GetColor('K'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3Akyla.calpito?auth_key=-1912757957&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNo = "289463287",
                    Color = AvatarBackground.GetColor('M'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3Aangni.01?auth_key=884833331&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
            new Person
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    ContactNo = "193812942",
                    Color = AvatarBackground.GetColor('M'),
                    Image = "https://avatar.skype.com/v1/avatars/live%3Amhelrosemejidana?auth_key=370822452&cacheHeaders=true&returnDefaultImage=false&size=l"
                },
        };

        public ContactsList()
        {
            InitializeComponent();
            GetContacts();
        }

        private void GetContacts()
        {
            this.listContacts.ItemsSource = new ObservableCollection<Person>(
                _people.OrderBy(person => person.FirstName).ToList());
        }

        private void GetContacts(ObservableCollection<Person> people)
        {
            this.listContacts.ItemsSource = people;
        }

        private void AddContact(object sender, Person p)
        {
            p.Color = AvatarBackground.GetColor(p.FirstName[0]);

            List<Person> tempCollection = new List<Person>(_people) { p };
            ObservableCollection<Person> people = new ObservableCollection<Person>(
                tempCollection.OrderBy(person => person.FirstName).ToList());

            GetContacts(people);

            this.Navigation.PopAsync();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(e.NewTextValue) || String.IsNullOrWhiteSpace(e.NewTextValue))
            {
                GetContacts();
            }
            else
            {
                ObservableCollection<Person> people = new ObservableCollection<Person>(
                        _people.Where(person => person.FullName.ToLower().Contains(e.NewTextValue.ToLower()) ||
                                                person.ContactNo.Contains(e.NewTextValue))
                               .OrderBy(person => person.FirstName)
                               .ToList()
                    );
                GetContacts(people);
            }
        }   

        async void BtnAddNewContact_Clicked(object sender, EventArgs e)
        {
            var page = new AddContactsForm(AddContact);
            NavigationPage.SetHasNavigationBar(page, false);
            await Navigation.PushAsync(page);
        }

        private async void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = e.Item as Person;
            var page = new ContactsInfo(person);
            NavigationPage.SetHasNavigationBar(page, false);
            await Navigation.PushAsync(page);
        }
    }
}