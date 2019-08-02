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
    public partial class GridImagePage : ContentPage
    {
        public GridImagePage()
        {
            InitializeComponent();

            Image1.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yypw59xh"),
                CachingEnabled = false
            };

            Image2.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y22razxu"),
                CachingEnabled = false
            };

            Image3.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y3bydso9"),
                CachingEnabled = false
            };

            Image4.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2hvt72y"),
                CachingEnabled = false
            };

            Image5.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yyuywv5l"),
                CachingEnabled = false
            };

            Image6.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y5hdz9l6"),
                CachingEnabled = false
            };

            Image7.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y697jezg"),
                CachingEnabled = false
            };

            Image8.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y6t2pfdv"),
                CachingEnabled = false
            };

            Image9.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2nt9kt9"),
                CachingEnabled = false
            };
        }
    }
}