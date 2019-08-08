using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDemo;

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

		async void ViewCell_Tapped(object sender, ItemTappedEventArgs e)
		{
			Contact contact = e.Item as Contact;
			var detailPage = new NavigationPage(new ContactDetails(contact,DeleteContact));
			await this.Navigation.PushModalAsync(detailPage);
		}

		public void DeleteContact(object sender, Contact contact)
		{
			this.temporaryContactList.Remove(contact);
			this.Navigation.PopModalAsync();
			contactListView.ItemsSource = GetContacts();
		}

		async void btn_AddContact(object sender, EventArgs e)
		{
			var detailPage = new NavigationPage(new ContactForm(AddContact));
			await this.Navigation.PushModalAsync(detailPage);
		}
		public void AddContact(object sender, Contact contact)
		{
			this.temporaryContactList.Add(contact);
			contactListView.ItemsSource = GetContacts();
			this.Navigation.PopModalAsync();
			
		}

	}

	public class Contact
	{
		public Dictionary<char, string> colorDict = new Dictionary<char, string>()
		{
			{ 'A', "#ff5454" },
			{ 'B', "#ff8254" },
			{ 'C', "#ffb254" },
			{ 'D', "#5dff54" },
			{ 'E', "#ffdd54" },
			{ 'F', "#54ffee" },
			{ 'G', "#9eff54" },
			{ 'H', "#54ff9b" },
			{ 'I', "#54d7ff" },
			{ 'J', "#5457ff" },
			{ 'K', "#ffab4a" },
			{ 'L', "#5465ff" },
			{ 'M', "#ff54b8" },
			{ 'N', "#ac54ff" },
			{ 'O', "#ff54bd" },
			{ 'P', "#d0ff61" },
			{ 'Q', "#e59cf0" },
			{ 'R', "#9cbff0" },
			{ 'S', "#ff545d" },
			{ 'T', "#ee54ff" },
			{ 'U', "#7654ff" },
			{ 'V', "#5496ff" },
			{ 'W', "#54ffe0" },
			{ 'X', "#54ff57" },
			{ 'Y', "#e0ff54" },
			{ 'Z', "#ffc354" },
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
				//string fname = Firstname.ToUpper();
				//string lname = Lastname.ToUpper();
				//char[] chars = { fname[0] , lname[0] };
				string s = String.Format("{0}{1}",Firstname.ToUpper()[0],Lastname.ToUpper()[0]);
				return s;
			}
		}
		public string Color
		{
			get
			{
				string color = colorDict.Where(c => c.Key == Initial[0]).FirstOrDefault().Value;
				return color;
			}
		}
	}
}