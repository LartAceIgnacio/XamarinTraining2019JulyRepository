using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinActivities.Models;

namespace XamarinActivities.Modals
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewContactPage : ContentPage
    {
        public ViewContactPage(Contact contact)
        {
            InitializeComponent();
            this.BindingContext = contact;
        }
    }
}