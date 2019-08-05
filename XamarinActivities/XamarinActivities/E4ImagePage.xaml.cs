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
    public partial class E4ImagePage : ContentPage
    {
        public E4ImagePage()
        {
            InitializeComponent();

            imgOne.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/myel-city-1"),
                CachingEnabled = false
            };

            imgTwo.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yypw59xh"),
                CachingEnabled = false
            };

            imgThree.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y3bydso9"),
                CachingEnabled = false
            };

            imgFour.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yyuywv5l"),
                CachingEnabled = false
            };

            imgFive.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2hvt72y"),
                CachingEnabled = false
            };

            imgSix.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y5hdz9l6"),
                CachingEnabled = false
            };


            imgSeven.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y697jezg"),
                CachingEnabled = false
            };


            imgEight.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y6t2pfdv"),
                CachingEnabled = false
            };

            imgNine.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2nt9kt9"),
                CachingEnabled = false
            };

        }
    }
}