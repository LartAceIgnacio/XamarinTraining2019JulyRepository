using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayout2Page : ContentPage
    {
        public StackLayout2Page()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(20, 0, 0, 0);
            }
        }
    }
}