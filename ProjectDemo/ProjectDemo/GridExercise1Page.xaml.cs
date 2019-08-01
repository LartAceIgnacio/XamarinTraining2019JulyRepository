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
	public partial class GridExercise1Page : ContentPage
	{
		string phoneNum = "";
		public GridExercise1Page()
		{
			InitializeComponent();
		}

		private void UpdatelblPhoneNum(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			if(phoneNum.Length<=10)
			{
				phoneNum = phoneNum + btn.Text;
				lblPhoneNum.Text = phoneNum;
			}
				
		}
	}
}