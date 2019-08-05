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
    public partial class ImagePage : ContentPage
    {
        int currentIndex = 1;
        string imageUrl = "http://lorempixel.com/320/240/city/";
        public ImagePage()
        {
            InitializeComponent();

            string imageLink = imageUrl + currentIndex;
            //DisplayAlert("Image", imageLink, "OK");
            Image.Source = new UriImageSource
            {
                Uri = new Uri(imageLink),
                CachingEnabled = false
            };
        }

        private void Back_Button_Clicked(object sender, EventArgs e)
        {
            if(currentIndex == 1)
            {
                currentIndex = 10;
            }
            else
            {
                currentIndex = currentIndex - 1;
            }

            string imageLink = imageUrl + currentIndex;
            //DisplayAlert("Image", imageLink, "OK");
            Image.Source = new UriImageSource
            {
                Uri = new Uri(imageLink),
                CachingEnabled = false
            };
        }

        private void Next_Button_Clicked(object sender, EventArgs e)
        {
            if (currentIndex == 10)
            {
                currentIndex = 1;
            }
            else
            {
                currentIndex = currentIndex + 1;
            }

            string imageLink = imageUrl + currentIndex;
            //DisplayAlert("Image", imageLink, "OK");
            Image.Source = new UriImageSource
            {
                Uri = new Uri(imageLink),
                CachingEnabled = false
            };
        }
    }
}