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
	public partial class ContactForm : ContentPage
	{
		private Contact _contact;
		private EventHandler<Contact> _addContactEventHandler;
		public ContactForm(EventHandler<Contact> addContactEventHandler)
		{
			InitializeComponent();
			this._addContactEventHandler = addContactEventHandler;
		}

		public void tlb_Add(object sender, EventArgs e)
		{
			_contact = new Contact()
			{
				Firstname = lblfname.Text,
				Lastname = lblfname.Text,
				PhoneNumber = lblnumber.Text,
				Nickname = lblnickname.Text
			};
			this._addContactEventHandler?.Invoke(this, _contact);
		}
	}
}