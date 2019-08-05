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
    public partial class E4ImageExercised1 : ContentPage
    {
        private List<String> imgList = new List<String>();
        private int count = 0;
        public E4ImageExercised1()
        {
            InitializeComponent();

            ImgSourceInit();
        }

        private void ImgSourceInit()
        {
            var imgURL = "https://tinyurl.com/ex-img-";
            for (var i = 1; i < 10; i++)
            {
                imgList.Add(imgURL + i);
            }

            imgDisplayed.Source = new UriImageSource
            {
                Uri = new Uri(imgList[count]),
                CachingEnabled = false
            };
        }

        private void OnPreviousClicked(object sender, EventArgs e)
        {
            if (count == 0)
            {
                imgDisplayed.Source = new UriImageSource
                {
                    Uri = new Uri(imgList[imgList.Count - 1]),
                    CachingEnabled = false
                };

                count = imgList.Count - 1;
            }
            else
            {
                imgDisplayed.Source = new UriImageSource
                {
                    Uri = new Uri(imgList[count-1]),
                    CachingEnabled = false
                };

                count -= 1;
            }
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            if (count == imgList.Count - 1) //last index
            {
                count = 0;
                imgDisplayed.Source = new UriImageSource
                {
                    Uri = new Uri(imgList[count]),
                    CachingEnabled = false
                }; 
            }
            else
            {
                imgDisplayed.Source = new UriImageSource
                {
                    Uri = new Uri(imgList[count + 1]),
                    CachingEnabled = false
                };

                count += 1;
            }
        }
    }
}