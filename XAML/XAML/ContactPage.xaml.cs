using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAML.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage(Person person)
        {
            InitializeComponent();
            this.BindingContext = person;
            lblName.Text = person.FullName;

        }
    }
}