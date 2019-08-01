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
    public partial class CalculatorPage : ContentPage
    {

        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void Number_Button_Clicked(object sender, EventArgs e)
        {
            String numberFormat = "#,##0";
            var button = sender as Button;

            var number = Number_Label.Text + button.Text;
            Number_Label.Text = Convert.ToDecimal(number).ToString(numberFormat);
        }

        private void Operator_Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
        }

        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            Number_Label.Text = "";
        }
    }
}