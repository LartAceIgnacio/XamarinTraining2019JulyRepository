using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercise1.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactListPage : ContentPage
    {
        ObservableCollection<Person> contactList;
        ObservableCollection<Person> filterGroup;
        
        public ContactListPage()
        {
            InitializeComponent();

            contactList = GetPeople();
            contactListView.ItemsSource = contactList;
        }
        ObservableCollection<Person> GetPeople(string searchText = null)
        {
            contactList = new ObservableCollection<Person>
            {
                new Person()
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNumber = "0999999999",
                    Email = "acustodio@blastasia.com",
                    ImageUrl = "https://media.licdn.com/dms/image/C4E03AQGn9BzvKcPDcg/profile-displayphoto-shrink_200_200/0?e=1570665600&v=beta&t=Q0GkFaOHj_bE73CMU7PP-TZua2SGwVeSJQ2MEiA0YSc"
                },
                new Person()
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNumber = "0999999998",
                    Email = "amendoza@blastasia.com",
                    ImageUrl = "https://media.licdn.com/dms/image/C5103AQGP4q7-XJhjWA/profile-displayphoto-shrink_200_200/0?e=1570665600&v=beta&t=MHL-GxW4k-Hxiu7rSMiQJJRXi62mcYNg6CzGe38HpYw"
                },
                new Person()
                {
                    FirstName = "Charles Kenichi",
                    LastName = "Nazareno",
                    ContactNumber = "0999999998",
                    Email = "cnazareno@blastasia.com",
                    ImageUrl = "https://scontent-hkg3-1.xx.fbcdn.net/v/t1.15752-9/67840454_474393120004110_4514064349546938368_n.jpg?_nc_cat=105&_nc_oc=AQko_dquDwWwkyhfzhhC5XNKbbEEpC4lmDEsX3IrngvsR7Idcd8utKqIY91zTYsLi_8&_nc_ht=scontent-hkg3-1.xx&oh=4fc1324f90d54e2177591c2ddd1c44f9&oe=5DEC8DB0"
                },
                new Person()
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNumber = "0999999998",
                    Email ="dreyes@blastasia.com",
                    ImageUrl ="https://pbs.twimg.com/profile_images/505519655746691072/whEP3pdn_400x400.jpeg"
                },
                new Person()
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNumber = "0999999998",
                    Email = "fcarao@blastasia.com",
                    ImageUrl ="https://media.licdn.com/dms/image/C4D03AQGIsZaAYQX_Zg/profile-displayphoto-shrink_200_200/0?e=1568246400&v=beta&t=brQaHB8_VUmKOh_4m0IrFrs7o2c58v-9bvV274QTCHU"
                },
                new Person()
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNumber = "0999999998",
                    Email = "jorilla@blastasia.com",
                    ImageUrl = "https://media.licdn.com/dms/image/C5603AQEh04u6uQg3jQ/profile-displayphoto-shrink_200_200/0?e=1570665600&v=beta&t=nQbCrvZ6d2NeFi1R8vVUuAzdeUWIjYETrCJnVfHbd6M"
                },
                new Person()
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNumber = "0999999998",
                    Email = "jdevera@blastasia.com",
                    ImageUrl = "https://media.licdn.com/dms/image/C5103AQHIVYYM8kejmg/profile-displayphoto-shrink_200_200/0?e=1570665600&v=beta&t=m1C3UewIxpuVmIHA1q6-rHDt6qiw0S6u81jUL6nlxCs"
                },
                new Person()
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNumber = "0999999998",
                    Email = "kcalpito@blastasia.com",
                    ImageUrl = "https://secure.meetupstatic.com/photos/member/a/7/a/4/highres_272802916.jpeg"
                },
                new Person()
                {
                    FirstName = "Marc Kenneth",
                    LastName = "Lomio",
                    ContactNumber = "0999999998",
                    Email = "mlomio@blastasia.com",
                    ImageUrl = "https://pbs.twimg.com/profile_images/734968927143399425/5eAAUi02_400x400.jpg"
                },
                new Person()
                {
                    FirstName = "Melrose",
                    LastName = "Mejidana",
                    ContactNumber = "0999999998",
                    Email = "mmejidana@blastasia.com",
                    ImageUrl = "https://media.licdn.com/dms/image/C5103AQHU3I0ZyVyE8Q/profile-displayphoto-shrink_200_200/0?e=1570665600&v=beta&t=_n11ujhm3gGZkTFZnGkkNC-7fuXoLQUKT2iiy4gw4ug"
                },
                new Person()
                {
                    FirstName = "Mermellah",
                    LastName = "Angni",
                    ContactNumber = "0999999998",
                    Email = "mangni@blastasia.com",
                    ImageUrl = "https://yt3.ggpht.com/a-/AN66SAxzuA-Ky7dusSsWPgEwYCYx0iVbdqq7LXt3CA=s900-mo-c-c0xffffffff-rj-k-no"
                },
            };
            var list = contactList;
            if (String.IsNullOrWhiteSpace(searchText))
            {
                return contactList;
            }
            else
            {
                var filter = list.Where(p => p.FullName.ToLower().Contains(searchText.ToLower()) || p.ContactNumber.ToLower().Contains(searchText.ToLower()));
                ObservableCollection<Person> filterGroup = new ObservableCollection<Person>(filter);
                return filterGroup;
            }
            
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Person;

            bool confirm = await DisplayAlert("Delete Contact", "Are you sure to delete this?", "Yes", "No");

            if (confirm == true)
            {
                contactList.Remove(contact);
            }
            
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            filterGroup = GetPeople(e.NewTextValue);
            contactListView.ItemsSource = filterGroup;
        }

        private void ContactListView_Refreshing(object sender, EventArgs e)
        {
            contactList = GetPeople();
            contactListView.ItemsSource = contactList;
            contactListView.EndRefresh();
        }

        async private void ContactListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Person person = e.Item as Person;
            var contact= new NavigationPage(new ContactProfilePage(person));
            await this.Navigation.PushModalAsync(contact);
        }
    }
}