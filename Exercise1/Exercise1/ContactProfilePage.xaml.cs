using Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactProfilePage : ContentPage
    {
        public ContactProfilePage(Person contact)
        {
            InitializeComponent();
            this.BindingContext = contact;
            
        }

        private void DeleteContact_Clicked(object sender, EventArgs e)
        {
            //MessagingCenter.Send<ContactListPage>(this, Delete_Clicked);
        }
    }
}