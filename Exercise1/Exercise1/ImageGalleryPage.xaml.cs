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
        }
    }
}