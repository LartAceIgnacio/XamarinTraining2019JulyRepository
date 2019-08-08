using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridImages : ContentPage
    {
        public GridImages()
        {
            InitializeComponent();
            image1.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yypw59xh"),
                CachingEnabled = false
            };
            image2.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y3bydso9"),
                CachingEnabled = false
            };
            image3.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yyuywv5l"),
                CachingEnabled = false
            };
            image4.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y22razxu"),
                CachingEnabled = false
            };
            image5.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2hvt72y"),
                CachingEnabled = false
            };
            image6.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y5hdz9l6"),
                CachingEnabled = false
            };
            image7.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y697jezg"),
                CachingEnabled = false
            };
            image8.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y6t2pfdv"),
                CachingEnabled = false
            };
            image9.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2nt9kt9"),
                CachingEnabled = false
            };

        }
    }
}