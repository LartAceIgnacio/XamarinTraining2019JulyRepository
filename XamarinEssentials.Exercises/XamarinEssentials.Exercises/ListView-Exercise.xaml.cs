using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEssentials.Exercises.Models;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView_Exercise : ContentPage
    {
        ObservableCollection<Contact> ContactList;
        ObservableCollection<Contact> SearchList;
        ObservableCollection<Contact> SortedList;

        public ListView_Exercise()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<NavigationPage_Exercise, Contact>(this, "delete_contact", (sender, contact) => {
                ContactList.Remove(contact);
                lstContacts.ItemsSource = SortList(ContactList);
            });

            ContactList = new ObservableCollection<Contact>()
            {
                new Contact { Id = 1, FirstName = "Arnold Allan", LastName = "Schwarzenegger", ContactNumber = "09056484757", Email = "aschwarzenegger@yahoo.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://m.media-amazon.com/images/M/MV5BMTI3MDc4NzUyMV5BMl5BanBnXkFtZTcwMTQyMTc5MQ@@._V1_UY317_CR19,0,214,317_AL_.jpg" },
                new Contact { Id = 2, FirstName = "Charles Kenichi", LastName = "Onerazan", ContactNumber = "09156584566", Email = "conerazan@yahoo.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://i.pinimg.com/originals/e8/93/a9/e893a94e8fb400e9d3bdc6a8a0e28ae2.jpg" },
                new Contact { Id = 3, FirstName = "Mark Kenneth 'Hangsome'", LastName = "Lomio", ContactNumber = "09056484757", Email = "mlomio@gmail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://www.star2.com/wp-content/uploads/2016/02/str2_dklomio_dinesh.k_stefanie_chiuliet-1024x1024.jpg" },
                new Contact { Id = 4, FirstName = "Jasper 'Japs'", LastName = "Orilla", ContactNumber = "09056484757", Email = "jorilla@gmail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "http://www.nautiluskayaks.es/wp-content/uploads/photo-gallery/thumb/20.jpg" },
                new Contact { Id = 5, FirstName = "Jelmarose 'Grace'", LastName = "DeVera", ContactNumber = "09056484757", Email = "jdevera@rocketmail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://avatars2.githubusercontent.com/u/15888411?v=4" },
                new Contact { Id = 6, FirstName = "Felix 'S Perm'", LastName = "Carao", ContactNumber = "09167395531", Email = "fcarao@rocketmail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://media.licdn.com/dms/image/C4D03AQGIsZaAYQX_Zg/profile-displayphoto-shrink_200_200/0?e=1568246400&v=beta&t=brQaHB8_VUmKOh_4m0IrFrs7o2c58v-9bvV274QTCHU" },
                new Contact { Id = 7, FirstName = "Dino 'Saur' Angelo", LastName = "Reyes", ContactNumber = "09729588734", Email = "dreyes@aol.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://pbs.twimg.com/profile_images/505519655746691072/whEP3pdn_400x400.jpeg" },
                new Contact { Id = 8, FirstName = "Melrose 'Rosemel'", LastName = "Mejidana", ContactNumber = "09167755498", Email = "mmejidana@aol.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://media.licdn.com/dms/image/C5103AQHU3I0ZyVyE8Q/profile-displayphoto-shrink_200_200/0?e=1567036800&v=beta&t=j7FYyDhzLWQN7vKX7E7Zj5jh3Nj5H5ynTTHcp-uMgyk" },
                new Contact { Id = 9, FirstName = "Kyla Gae 'Turtle'", LastName = "Calpito", ContactNumber = "09167395531", Email = "kcalpito@zoho.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://secure.meetupstatic.com/photos/member/7/b/5/d/highres_271951581.jpeg" },
                new Contact { Id = 10, FirstName = "Mermellah 'lol'", LastName = "Angni", ContactNumber = "0988659931", Email = "mangni@zoho.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://yt3.ggpht.com/a-/AN66SAxzuA-Ky7dusSsWPgEwYCYx0iVbdqq7LXt3CA=s900-mo-c-c0xffffffff-rj-k-no" },
                new Contact { Id = 11, FirstName = "Barry 'Happy'", LastName = "Manilow", ContactNumber = "09285555784", Email = "bmanilow@mail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://www.biography.com/.image/ar_1:1%2Cc_fill%2Ccs_srgb%2Cg_face%2Cq_auto:good%2Cw_300/MTE4MDAzNDEwNzY3Njc2OTQy/barry-manilow-9542490-1-402.jpg" },
                new Contact { Id = 12, FirstName = "Erickson 'Jocson'", LastName = "Reyes", ContactNumber = "09195554491", Email = "ereyes@mail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://pbs.twimg.com/profile_images/808621107389534208/btnvxEWU.jpg" },
                new Contact { Id = 13, FirstName = "Gerald 'Alder'", LastName = "Anderson", ContactNumber = "09295550240", Email = "ganderson@protonmail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://philnews.ph/wp-content/uploads/2019/08/gerald-anderson.jpg" },
                new Contact { Id = 14, FirstName = "Holly 'Jolly'", LastName = "Mendoza", ContactNumber = "09167395531", Email = "hmendoza@protonmail.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://www.tricountybusts.com/inc/Images/bso-830314.jpg" },
                new Contact { Id = 15, FirstName = "Irejane 'Ire'", LastName = "Santos", ContactNumber = "0988659931", Email = "isantos@pornhub.com", Birthday = "January 1, 1990", Quote = "", AvatarUrl = "https://pbs.twimg.com/profile_images/663827465438130176/qSQnvHIL.jpg" }
            };

            lstContacts.ItemsSource = SortList(ContactList);
        }

        private void LstContacts_Refreshing(object sender, EventArgs e)
        {
            ContactList = GetContacts();
            lstContacts.ItemsSource = SortList(ContactList);
            lstContacts.EndRefresh();
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            string confirmDeleteMessage = string.Format("Delete {0} from contact list?", contact.FullName);

            bool answer = await DisplayAlert("Confirm Action", confirmDeleteMessage, "Yes", "No");

            if (answer)
            {
                ContactList.Remove(contact);
                lstContacts.ItemsSource = SortList(ContactList);
            }
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            var EditContactPage = new FormsAndSettings_Bonus(contact, EditContact);

            await this.Navigation.PushAsync(EditContactPage);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchList = GetContacts(e.NewTextValue);
            lstContacts.ItemsSource = SortList(SearchList);
        }

        ObservableCollection<Contact> SortList(ObservableCollection<Contact> list)
        {
            return SortedList = new ObservableCollection<Contact>(list.OrderBy(c => c.FullName));
        }

        ObservableCollection<Contact> GetContacts()
        {
            return new ObservableCollection<Contact>
            {
                new Contact { FirstName = "Arnold Allan", LastName = "Schwarzenegger", ContactNumber = "09056484757" },
                new Contact { FirstName = "Charles Kenichi", LastName = "Onerazan", ContactNumber = "09156584566" },
                new Contact { FirstName = "Mark Kenneth 'Hangsome'", LastName = "Lomio", ContactNumber = "09056484757" },
                new Contact { FirstName = "Jasper 'Japs'", LastName = "Orilla", ContactNumber = "09056484757" },
                new Contact { FirstName = "Jelmarose 'Grace'", LastName = "DeVera", ContactNumber = "09056484757" },
                new Contact { FirstName = "Felix 'S Perm'", LastName = "Carao", ContactNumber = "09167395531" },
                new Contact { FirstName = "Dino 'Saur' Angelo", LastName = "Reyes", ContactNumber = "09729588734" },
                new Contact { FirstName = "Melrose 'Rosemel'", LastName = "Mejidana", ContactNumber = "09167755498" },
                new Contact { FirstName = "Kyla Gae 'Turtle'", LastName = "Calpito", ContactNumber = "09167395531" },
                new Contact { FirstName = "Mermellah 'lol'", LastName = "Angni", ContactNumber = "0988659931" }
            };
        }

        ObservableCollection<Contact> GetContacts(string searchText = null)
        {
            var list = ContactList;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                return ContactList;
            }
            else
            {
                var filteredList = list.Where(
                    contact => contact.FullName.ToLower().Contains(searchText.ToLower()) ||
                               contact.ContactNumber.Contains(searchText)).ToList();
                ObservableCollection<Contact> searchResults = new ObservableCollection<Contact>(filteredList);
                return searchResults;
            }
        }

        private void LstContacts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;

            var ContactDetailsPage = new NavigationPage(new NavigationPage_Exercise(contact));
            this.Navigation.PushModalAsync(ContactDetailsPage);
        }

        private async void TlbrAdd_Clicked(object sender, EventArgs e)
        {
            int NewId = ContactList.Count + 1;
            var AddContactPage = new FormsAndSettings_Exercise(NewId, AddContact);

            await this.Navigation.PushAsync(AddContactPage);
        }

        public void AddContact(object sender, Contact contact)
        {
            ContactList.Add(contact);
            lstContacts.ItemsSource = SortList(ContactList);

            this.Navigation.PopAsync();

            string alertMessage = string.Format("'{0}' has been added to your contact list.", contact.FullName);
            DisplayAlert("Operation Success", alertMessage, "Ok");
        }

        public void EditContact(object sender, Contact UpdatedContact)
        {
            Contact ContactToUpdate = ContactList.FirstOrDefault(c => c.Id == UpdatedContact.Id);

            ContactToUpdate.FirstName = UpdatedContact.FirstName;
            ContactToUpdate.LastName = UpdatedContact.LastName;
            ContactToUpdate.ContactNumber = UpdatedContact.ContactNumber;
            ContactToUpdate.Email = UpdatedContact.Email;
            ContactToUpdate.AvatarUrl = UpdatedContact.AvatarUrl;
            ContactToUpdate.Birthday = UpdatedContact.Birthday;
            ContactToUpdate.Quote = UpdatedContact.Quote;

            lstContacts.ItemsSource = SortList(ContactList);

            this.Navigation.PopAsync();

            string alertMessage = string.Format("'{0}' has been updated.", ContactToUpdate.FullName);
            DisplayAlert("Operation Success", alertMessage, "Ok");
        }
    }
}