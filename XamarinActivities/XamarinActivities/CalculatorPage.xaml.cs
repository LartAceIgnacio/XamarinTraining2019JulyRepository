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
        String num1 = String.Empty;
        String num2 = String.Empty;
        char operation;
        Double result = 0.00;

        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void Number_Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var number = Number_Label.Text + button.Text;
            Number_Label.Text = String.Format("{0:n0}", Double.Parse(number)); 
        }

        private void Operator_Button_Clicked(object sender, EventArgs e)
        {
            num1 = Number_Label.Text;
            Number_Label.Text = String.Empty;
            var button = sender as Button;
            operation = Char.Parse(button.Text);
        }

        private void Equal_Button_Clicked(object sender, EventArgs e)
        {
            var operand1 = Double.Parse(num1);
            var operand2 = Double.Parse(Number_Label.Text);

            if (operation == '+')
            {
                result = operand1 + operand2;
            }
            else if (operation == '-')
            {
                result = operand1 - operand2;
            }
            else if (operation == '×')
            {
                result = operand1 * operand2;
            }
            else if (operation == '÷')
            {
                result = operand1 / operand2;
            }
            else if (operation == '%')
            {
                result = operand1 % operand2;
            }

            Number_Label.Text = String.Format("{0:n0}", result);
        }

        private void Clear_Button_Clicked(object sender, EventArgs e)
        {
            Number_Label.Text = String.Empty;
        }
    }
}