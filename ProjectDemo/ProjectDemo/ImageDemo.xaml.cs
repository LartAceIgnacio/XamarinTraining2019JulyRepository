using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageDemo : ContentPage
	{
		public ImageDemo()
		{
			InitializeComponent();
			imgKevin.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/yypw59xh"),
				CachingEnabled = false
			};
			imgLart.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y22razxu"),
				CachingEnabled = false
			};
			imgKhen.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y5hdz9l6"),
				CachingEnabled = false
			};
			imgRaum.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/yyuywv5l"),
				CachingEnabled = false
			};
			imgMoira.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y2hvt72y"),
				CachingEnabled = false
			};
			imgChris.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y2nt9kt9"),
				CachingEnabled = false
			};
			imgSteph.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y6t2pfdv"),
				CachingEnabled = false
			};
			imgGillian.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y3bydso9"),
				CachingEnabled = false
			};
			imgEm.Source = new UriImageSource
			{
				Uri = new Uri("https://tinyurl.com/y697jezg"),
				CachingEnabled = false
			};
		}
	}
}