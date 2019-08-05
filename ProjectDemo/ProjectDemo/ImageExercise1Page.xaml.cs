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
	public partial class ImageExercise1Page : ContentPage
	{
		public ImageExercise1Page()
		{
			InitializeComponent();
			imgDisplayImage.Source = new UriImageSource
			{
				Uri = new Uri("http://lorempixel.com/800/600/city/1"),
				CachingEnabled = false
			};
		}
		private int _counter = 1;
		private string _imgUrl = "http://lorempixel.com/800/600/city/";
		private void NextImage(object sender, EventArgs e)
		{
			if(_counter<10)
			{
				_counter += 1;
				imgDisplayImage.Source = new UriImageSource
				{
					Uri = new Uri(_imgUrl + _counter),
					CachingEnabled = false
				};
			}
			if(_counter==10)
			{
				_counter = 1;
				imgDisplayImage.Source = new UriImageSource
				{
					Uri = new Uri(_imgUrl + _counter),
					CachingEnabled = false
				};
			}
		}

		private void PreviousImage(object sender, EventArgs e)
		{
			if (_counter > 0)
			{
				_counter -= 1;
				imgDisplayImage.Source = new UriImageSource
				{
					Uri = new Uri(_imgUrl + _counter),
					CachingEnabled = false
				};
			}
			if (_counter == 0)
			{
				_counter = 10;
				imgDisplayImage.Source = new UriImageSource
				{
					Uri = new Uri(_imgUrl + _counter),
					CachingEnabled = false
				};
			}
		}
	}
}