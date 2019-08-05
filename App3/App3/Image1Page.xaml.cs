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
        int id = 1;
        public Image1Page()
        {
            InitializeComponent();
            BackButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0);
            BackButton.ImageSource = "leftarrow";
            NextButton.BackgroundColor = Color.FromRgba(0, 0, 0, 0);
            NextButton.ImageSource = "rightarrow";
            DisplayedImage.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/320/240/city/{0}", id)),
                CachingEnabled = false
            };
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            id -= 1;
            if (id == 0)
            {
                id = 10;
            }
            DisplayedImage.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/320/240/city/{0}", id)),
                CachingEnabled = false
            };
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            id += 1;
            if (id == 11)
            {
                id = 1;
            }
            DisplayedImage.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/320/240/city/{0}", id)),
                CachingEnabled = false
            };
        }
    }
}