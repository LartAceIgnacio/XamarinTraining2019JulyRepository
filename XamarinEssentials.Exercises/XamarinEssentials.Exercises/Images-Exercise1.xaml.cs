using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Images_Exercise1 : ContentPage
    {
        int id = 1;
        string imgUrl = "http://lorempixel.com/320/240/city/";
        public Images_Exercise1()
        {
            InitializeComponent();

            imgDisplay.Source = new UriImageSource
            {
                Uri = new Uri(imgUrl + id),
                CachingEnabled = false
            };
        }

        private void btnChangeImage_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.ClassId == "btnNext")
            {
                if (id == 10)
                {
                    id = 1;
                }
                else
                {
                    id++;
                }
            }
            else if (btn.ClassId == "btnBack")
            {
                if (id == 1)
                {
                    id = 10;
                }
                else
                {
                    id--;
                }
            }

            imgDisplay.Source = new UriImageSource
            {
                Uri = new Uri(imgUrl + id),
                CachingEnabled = false
            };
        }
    }
}