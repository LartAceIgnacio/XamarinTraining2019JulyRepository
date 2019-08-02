using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Image2Page : ContentPage
    {
        public Image2Page()
        {
            InitializeComponent();
            LucinaImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/2/20/Lucina_portrait_normal.png/revision/latest/scale-to-width-down/110?cb=20161025070337"),
                CachingEnabled = false
            };
            ChromImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/8/8b/Chromfacingleft.png/revision/latest/scale-to-width-down/110?cb=20161025065557"),
                CachingEnabled = false
            };    
            RobinImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/5/51/Robin_Avatar_M_F.png/revision/latest/scale-to-width-down/110?cb=20170501220038"),
                CachingEnabled = false
            };
            SeveraImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/2/29/Severa.png/revision/latest/scale-to-width-down/110?cb=20160420094019"),
                CachingEnabled = false
            };
            BradyImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/d/db/Owain.png/revision/latest/scale-to-width-down/110?cb=20160529043800"),
                CachingEnabled = false
            };
            CynthiaImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/3/37/Cynthia_Kakusei.png/revision/latest/scale-to-width-down/110?cb=20160529044003"),
                CachingEnabled = false
            };
            KjelleImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/4/46/Dezel.png/revision/latest/scale-to-width-down/110?cb=20160603023129"),
                CachingEnabled = false
            };
            CordeliaImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/8/87/Tiamo_Portrait.png/revision/latest/scale-to-width-down/110?cb=20160529042820"),
                CachingEnabled = false
            };
            MorganImage.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/fireemblem/images/f/f5/Morgans.png/revision/latest/scale-to-width-down/110?cb=20160503173548"),
                CachingEnabled = false
            };

        }
    }
}