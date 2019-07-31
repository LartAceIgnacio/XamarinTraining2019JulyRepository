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
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
			colorbox.Color = Color.FromRgb(0, 0, 0);
			label1.Text = "Red : 0";
			label2.Text = "Gree : 0";
			label3.Text = "Blue : 0";
		}

		private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			colorbox.Color = Color.FromRgb((int)slider1.Value,
										  (int)slider2.Value,
										  (int)slider3.Value);
		}

	}
}