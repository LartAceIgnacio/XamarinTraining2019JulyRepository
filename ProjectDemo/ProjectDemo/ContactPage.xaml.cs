using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public List<Contact> contacts = new List<Contact>
			{
				new Contact
				{
					Firstname = "Mermellah",
					Lastname = "Angni",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Kyla Gae",
					Lastname = "Calpito",
					PhoneNumber = "09095362345"
				},
				new Contact
				{
					Firstname = "Melrose",
					Lastname = "Mejidana",
					PhoneNumber = "09197638467"
				},
				new Contact
				{
					Firstname = "Jelmarose Grace",
					Lastname = "De Vera",
					PhoneNumber = "09297364098"
				},
				new Contact
				{
					Firstname = "Charles",
					Lastname = "Nazareno",
					PhoneNumber = "09156283615"
				},
				new Contact
				{
					Firstname = "Arnold Allan",
					Lastname = "Mendoza",
					PhoneNumber = "09176653725"
				},
				new Contact
				{
					Firstname = "Dino",
					Lastname = "Reyes",
					PhoneNumber = "09097622615"
				},
				new Contact
				{
					Firstname = "Marc Kenneth",
					Lastname = "Lomio",
					PhoneNumber = "09297658876"
				},
				new Contact
				{
					Firstname = "Aaron",
					Lastname = "Custodio",
					PhoneNumber = "09195564254"
				},
				new Contact
				{
					Firstname = "Jasper",
					Lastname = "Orilla",
					PhoneNumber = "09152235146"
				},
				new Contact
				{
					Firstname = "Felix",
					Lastname = "Carao",
					PhoneNumber = "09176782536"
				}
			};
		public List<Contact> temporaryContactList = new List<Contact>();
		public Boolean isRefreshed = false;
		public ContactPage()
		{
			InitializeComponent();

			cloneContactList();
			contactListView.ItemsSource = GetContacts();
			
		}
		public List<Contact> GetContacts()
		{
			List<Contact> SortedContact = temporaryContactList.OrderBy(o => o.Firstname).ToList();
			return SortedContact;
		}

		private void ContactListView_Refreshing(object sender, EventArgs e)
		{
			cloneContactList();
			contactListView.ItemsSource = GetContacts();
			contactListView.EndRefresh();
		}

		private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			string searchtext = e.NewTextValue;
			var contacts = new ObservableCollection<Contact>();
				foreach (var item in GetContacts())
				{
					contacts.Add(item);
				}

				if (String.IsNullOrWhiteSpace(searchtext))
				{
					contactListView.ItemsSource = GetContacts();
				}
				else
				{
					var filteredContact = temporaryContactList.Where(contact => contact.FullName.ToLower().Contains(searchtext.ToLower()) || contact.PhoneNumber.ToLower().Contains(searchtext.ToLower()));
					contactListView.ItemsSource = filteredContact;

				}

		}
		public void cloneContactList()
		{
			temporaryContactList.Clear();
			contacts.ForEach((item) =>
			{
				temporaryContactList.Add(item);
			});
		}
		private void Delete_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var _contact = menuItem.CommandParameter as Contact;
			temporaryContactList.Remove(_contact);
			contactListView.ItemsSource = GetContacts();
		}
	}

	public class Contact
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string PhoneNumber { get; set; }
		public string FullName {
			get
			{
				return Firstname + " " + Lastname;
			}
		}
		public string Initial
		{
			get
			{
				char[] chars = { Firstname[0] , Lastname[0] };
				string s = new string(chars);
				return s;
			}
		}
	}
}