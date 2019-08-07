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
					Nickname = "Ellah",
					PhoneNumber = "09095229126",
					Picture = "ellah.jpg"
				},
				new Contact
				{
					Firstname = "Kyla Gae",
					Lastname = "Calpito",
					Nickname = "Turtle",
					PhoneNumber = "09095362345",
					Picture = "kyla.jpg"
				},
				new Contact
				{
					Firstname = "Melrose",
					Lastname = "Mejidana",
					Nickname ="Rosmel",
					PhoneNumber = "09197638467",
					Picture = "melrose.jpg"
				},
				new Contact
				{
					Firstname = "Jelmarose Grace",
					Lastname = "De Vera",
					Nickname = "Jelma",
					PhoneNumber = "09297364098",
					Picture = "jelma.jpg"
				},
				new Contact
				{
					Firstname = "Charles",
					Lastname = "Nazareno",
					Nickname = "Memelord",
					PhoneNumber = "09156283615",
					Picture = "charles.jpg"
				},
				new Contact
				{
					Firstname = "Arnold Allan",
					Lastname = "Mendoza",
					Nickname = "Arnold",
					PhoneNumber = "09176653725",
					Picture = "arnold.jpg"
				},
				new Contact
				{
					Firstname = "Dino",
					Lastname = "Reyes",
					Nickname = "Dina",
					PhoneNumber = "09097622615",
					Picture = "dino.jpg"
				},
				new Contact
				{
					Firstname = "Marc Kenneth",
					Lastname = "Lomio",
					Nickname = "Hangsome",
					PhoneNumber = "09297658876",
					Picture = "marc.jpg"
				},
				new Contact
				{
					Firstname = "Aaron",
					Lastname = "Custodio",
					Nickname = "EyEyron",
					PhoneNumber = "09195564254",
					Picture = "aaron.jpg"
				},
				new Contact
				{
					Firstname = "Jasper",
					Lastname = "Orilla",
					Nickname = "Hi Japs",
					PhoneNumber = "09152235146",
					Picture = "jasper.jpg"
				},
				new Contact
				{
					Firstname = "Felix",
					Lastname = "Carao",
					Nickname = "Lex",
					PhoneNumber = "09176782536",
					Picture = "lex.jpg"
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

				if (String.IsNullOrWhiteSpace(searchtext))
				{
					contactListView.ItemsSource = GetContacts();
				}
				else
				{
					var filteredContact = temporaryContactList.Where(contact => contact.FullName.ToLower().Contains(searchtext.ToLower()) || contact.PhoneNumber.Contains(searchtext));
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

		private void ViewCell_Tapped(object sender, ItemTappedEventArgs e)
		{
			Contact contact = e.Item as Contact;
			ContactDetails detailPage = new ContactDetails(contact);
			this.Navigation.PushModalAsync(detailPage);
		}
	}

	public class Contact
	{
		public Dictionary<char, string> colorDict = new Dictionary<char, string>()
		{
			{ 'A', "#ff5454" },
			{ 'C', "#ffb254" },
			{ 'D', "#5dff54" },
			{ 'F', "#54ffee" },
			{ 'J', "#5457ff" },
			{ 'K', "#ffab4a" },
			{ 'M', "#ff54b8" }
		};
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Nickname { get; set; }
		public string PhoneNumber { get; set; }
		public string Picture { get; set; }
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
		public string Color
		{
			get
			{
				string color = colorDict[Firstname[0]];
				return color;
			}
		}
	}
}