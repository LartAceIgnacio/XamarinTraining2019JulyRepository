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
    public partial class ImageGallerySwitchPage : ContentPage
    {
        public String[] imageID;
        public string imageUrl = "http://lorempixel.com/320/240/city/";
        public int index = 0;
        

        public ImageGallerySwitchPage()
        {
            InitializeComponent();
            imageID = new String[10]
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
            };
            this.ImageGallery.Source = imageUrl+imageID[index];

        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                this.ImageGallery.Source = imageUrl+imageID[index];
            }
            else
            {
                index = 9;
                this.ImageGallery.Source = imageUrl+imageID[index];
            }

        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            if (index < 9)
            {
                index++;
                this.ImageGallery.Source = imageUrl + imageID[index];
            }
            else
            {
                index = 0;
                this.ImageGallery.Source = imageUrl + imageID[index];
            }
        }
        //<StackLayout Orientation = "Horizontal" >


        //        < Button Text="Back"
        //        HorizontalOptions="Start"
        //        VerticalOptions="Start"
        //        Clicked="BackButton_Clicked"/>
                
        //        <Button Text = "Next"
        //        HorizontalOptions="EndAndExpand"
        //        VerticalOptions="End"
        //        Clicked="NextButton_Clicked"/>
        //    </StackLayout>
        //    <Image x:Name="ImageGallery"
                   
        //           Aspect="AspectFill"/>
    }
}