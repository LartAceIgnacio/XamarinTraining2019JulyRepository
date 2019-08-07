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
		Contact contact;
		public ContactDetails(Contact contact)
		{
			InitializeComponent();
			this.BindingContext = contact;
			setContact(contact);
		}

		public void setContact(Contact contact)
		{
			this.contact = contact;
		}
		private void tlb_Delete(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
		}
	}
}