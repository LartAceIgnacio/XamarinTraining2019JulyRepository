using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Images_Exercise2 : ContentPage
    {
        public Images_Exercise2()
        {
            InitializeComponent();

            imgHisone.Source = new UriImageSource
            {
                Uri = new Uri("https://img1.ak.crunchyroll.com/i/spire4/0f7b81e26849c40937e3bad68591f8a51541444404_full.jpg"),
                CachingEnabled = false
            };

            imgLotte.Source = new UriImageSource
            {
                Uri = new Uri("https://statici.behindthevoiceactors.com/behindthevoiceactors/_img/chars/lotte-little-witch-academia-8.89.jpg"),
                CachingEnabled = false
            };

            imgStevenTyler.Source = new UriImageSource
            {
                Uri = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Steven_Tyler_by_Gage_Skidmore_3.jpg/220px-Steven_Tyler_by_Gage_Skidmore_3.jpg"),
                CachingEnabled = false
            };

            imgRichie.Source = new UriImageSource
            {
                Uri = new Uri("https://m.media-amazon.com/images/M/MV5BMTkyNDI1MTcyMV5BMl5BanBnXkFtZTcwODM1MDYxMw@@._V1_UX214_CR0,0,214,317_AL_.jpg"),
                CachingEnabled = false
            };

            imgJonas.Source = new UriImageSource
            {
                Uri = new Uri("https://vignette.wikia.nocookie.net/jaygt/images/0/00/Jonasneubauer.png/revision/latest?cb=20180407054121"),
                CachingEnabled = false
            };

            imgRickBarry.Source = new UriImageSource
            {
                Uri = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Rick_Barry.jpg/220px-Rick_Barry.jpg"),
                CachingEnabled = false
            };

            imgGir.Source = new UriImageSource
            {
                Uri = new Uri("https://is1-ssl.mzstatic.com/image/thumb/Purple/v4/a4/11/91/a41191c6-6df8-91fb-1182-6e8113278e9b/source/512x512bb.jpg"),
                CachingEnabled = false
            };

            imgNL.Source = new UriImageSource
            {
                Uri = new Uri("https://i.redd.it/socqd0ez1mm01.jpg"),
                CachingEnabled = false
            };

            imgPewds.Source = new UriImageSource
            {
                Uri = new Uri("https://static.coindesk.com/wp-content/uploads/2019/04/Felix-Headshot-1-860x430.jpg"),
                CachingEnabled = false
            };

            imgDylanWang.Source = new UriImageSource
            {
                Uri = new Uri("https://i.ytimg.com/vi/lfmBuk22v2Q/maxresdefault.jpg"),
                CachingEnabled = false
            };
        }
    }
}