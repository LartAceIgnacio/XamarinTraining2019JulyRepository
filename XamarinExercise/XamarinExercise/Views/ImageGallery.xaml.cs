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
    public partial class ImageGallery : ContentPage
    {
        
        String images= "http://lorempixel.com/320/240/city/";
        int id=1;


        public ImageGallery()
        {
            InitializeComponent();
            image.Source = new UriImageSource
            {
                Uri = new Uri(this.images + id.ToString()),
                CachingEnabled = false
            };
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
  
            if (sender == next)
            {
                this.id++;
                if (id > 10)
                {
                    id= 1;
                }
                image.Source = new UriImageSource
                {
                    Uri = new Uri(this.images + id.ToString()),
                    CachingEnabled = false
                };
            }
            else if (sender == back)
            {
                this.id--;
                if (id < 1)
                {
                    id=10;
                }
                image.Source = new UriImageSource
                {
                    Uri = new Uri(this.images + id.ToString()),
                    CachingEnabled = false
                };
            }
        }
    }
}