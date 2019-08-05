using System;
using System.Collections.Generic;
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
		public ContactPage()
		{
			InitializeComponent();
			
			contactListView.ItemsSource = GetContacts();
		}
		public List<Contact> GetContacts()
		{
			List<Contact> contacts = new List<Contact>
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
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Melrose",
					Lastname = "Mejidana",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Jelmarose Grace",
					Lastname = "De Vera",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Charles",
					Lastname = "Nazareno",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Arnold Allan",
					Lastname = "Mendoza",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Dino",
					Lastname = "Reyes",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Marc Kenneth",
					Lastname = "Lomio",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Aaron",
					Lastname = "Custodio",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Jasper",
					Lastname = "Orilla",
					PhoneNumber = "09095229126"
				},
				new Contact
				{
					Firstname = "Felix",
					Lastname = "Carao",
					PhoneNumber = "09095229126"
				}
			};
			return contacts;
		}
	}

	public class Contact
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string PhoneNumber { get; set; }
		public string FullName { get; set; }
	}
}