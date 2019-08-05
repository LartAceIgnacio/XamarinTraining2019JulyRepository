using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageGalleryPage : ContentPage
    {
        public ImageGalleryPage()
        {
            InitializeComponent();
            Img1.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yypw59xh"),
                CachingEnabled = false
            };
            Img2.Source = new UriImageSource
            {
                Uri = new Uri ("https://tinyurl.com/y3bydso9"),
                CachingEnabled = false
            };
            Img3.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/yyuywv5l"),
                CachingEnabled = false
            };
            Img4.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y22razxu"),
                CachingEnabled = false
            };
            Img5.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2hvt72y"),
                CachingEnabled = false
            };
            Img6.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y5hdz9l6"),
                CachingEnabled = false
            };
            Img7.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y697jezg"),
                CachingEnabled = false
            };
            Img8.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y6t2pfdv"),
                CachingEnabled = false
            };
            Img9.Source = new UriImageSource
            {
                Uri = new Uri("https://tinyurl.com/y2nt9kt9"),
                CachingEnabled = false
            };
        }
    }
}