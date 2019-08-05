using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageExercise1 : ContentPage
    {
        public int MinImageNumber = 1;
        public int ImageNumber = 1;
        public int MaxImageNumber = 5;
        public string ImageLink = "https://tinyurl.com/imgexercise-";
        public ImageExercise1()
        {
            InitializeComponent();
            imgMain.Source = ImageLink + ImageNumber.ToString();
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if (ImageNumber == MinImageNumber)
            {
                ImageNumber = MaxImageNumber;
            }
            else
            {
                ImageNumber -= 1;
            }
            imgMain.Source = ImageLink + ImageNumber.ToString();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            if (ImageNumber == MaxImageNumber)
            {
                ImageNumber = MinImageNumber;
            }
            else
            {
                ImageNumber += 1;
            }
            imgMain.Source = ImageLink + ImageNumber.ToString();
        }
    }
}