using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectDemo
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public string[] quotes = {"Any fool can write code that a computer can understand. Good programmers write code that humans can understand.",
			"The most disastrous thing that you can ever learn is your first programming language",
			"Code is like humor. When you have to explain it, it’s bad.",
			"Before software can be reusable it first has to be usable.",
			"One of the best programming skills you can have is knowing when to walk away for awhile."
		};
		public MainPage()
		{
			InitializeComponent();
			slider.Value = 15;
			quote.Text = quotes[0];
		}

		private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			fontSize.Text = String.Format("Font Size: {0:F0}", e.NewValue);
		}
		int count = 0;
		private void Next_Quote(object sender, EventArgs e)
		{
			if(count==4)
			{
				count=0;
				quote.Text = quotes[count];
			}
			else
			{
				count++;
				quote.Text = quotes[count];
			}
			
		}
		private void Previous_Quote(object sender, EventArgs e)
		{
			if (count == 0)
			{
				count = 4;
				quote.Text = quotes[count];
			}
			else
			{
				count--;
				quote.Text = quotes[count];
			}

		}
	}
}
