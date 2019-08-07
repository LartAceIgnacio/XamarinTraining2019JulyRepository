using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact_Details : ContentPage
    {
        public Contact_Details(Person p)
        {
            InitializeComponent();
            this.lblFullName.Text = p.FullName;
        }
    }
}