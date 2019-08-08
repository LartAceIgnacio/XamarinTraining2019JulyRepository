using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDemo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetails : ContentPage
	{
		private Contact _contact;
		private EventHandler<Contact> _deleteContactEventHandler;
		public ContactDetails(Contact contact, EventHandler<Contact> deleteContactEventHandler)
		{
			InitializeComponent();
			this.BindingContext = contact;
			this._contact = contact;
			this._deleteContactEventHandler = deleteContactEventHandler;
		}

		public void tlb_Delete(object sender, EventArgs e)
		{
			this._deleteContactEventHandler?.Invoke(this, this._contact);
			this.Navigation.PopModalAsync();
		}
	}
}