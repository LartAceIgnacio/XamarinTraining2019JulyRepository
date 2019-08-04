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
    public partial class Image1Page : ContentPage
    {
        int ctr = 1;
        public Image1Page()
        {
            InitializeComponent();
            BackButton.ImageSource = "leftarrow";
            NextButton.ImageSource = "rightarrow";
            DisplayedImage.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/320/240/city/{0}", ctr)),
                CachingEnabled = false
            };
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            ctr -= 1;
            if (ctr == 0)
            {
                ctr = 10;
            }
            DisplayedImage.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/320/240/city/{0}", ctr)),
                CachingEnabled = false
            };
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            ctr += 1;
            if (ctr == 11)
            {
                ctr = 1;
            }
            DisplayedImage.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/320/240/city/{0}", ctr)),
                CachingEnabled = false
            };
        }
    }
}