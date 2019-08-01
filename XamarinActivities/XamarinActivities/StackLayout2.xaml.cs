using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayout2 : ContentPage
    {
        private int likes_count = 700;
        public StackLayout2()
        {
            InitializeComponent();

            lblLikes.Text = likes_count + " Likes";
            lblCaption.Text = "If you tell the truth, you don't have to remember anything.";

            if(Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
        }
    }
}