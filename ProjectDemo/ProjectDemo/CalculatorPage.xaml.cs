using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage()
		{
			InitializeComponent();
			lblCalculate.Text = "0";
		}
		string calculate = "";
		private void Button_Clicked(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			if(calculate.Length<18)
			{
				calculate = calculate + btn.Text;
				double calculateDoub = Convert.ToDouble(calculate);
				lblCalculate.Text = String.Format("{0:n0}", calculateDoub);
			}
			
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			lblCalculate.Text = "0";
		}

		private void Button_Clicked_2(object sender, EventArgs e)
		{
			//To do
		}
	}
}