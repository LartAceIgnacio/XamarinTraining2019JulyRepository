using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data;
using System.Linq.Expressions;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    { 
        string displayValue = "0";
        public CalculatorPage()
        {
            InitializeComponent();
            labelDisplay.Text = "0";
            
        }
        void OnButtonPress(object sender, EventArgs e)
        {
           
            if (this.displayValue.Equals("0"))
            {
                this.displayValue = "";
            }
            if (sender==btnOne)
            {
                this.displayValue += "1";
            }
            if (sender == btnTwo)
            {
                this.displayValue += "2";
            }
            if (sender == btnThree)
            {
                this.displayValue += "3";
            }
            if (sender == btnFour)
            {
                this.displayValue += "4";
            }
            if (sender == btnFive)
            {
                this.displayValue += "5";
            }
            if (sender == btnSix)
            {
                this.displayValue += "6";
            }
            if (sender == btnSeven)
            {
                this.displayValue += "7";
            }
            if (sender == btnEight)
            {
                this.displayValue += "8";
            }
            if (sender == btnNine)
            {
                this.displayValue += "9";
            }
            if (sender == btnZero)
            {
                this.displayValue += "0";
            }
            if (sender == btnDot)
            {
                this.displayValue += ".";
            }
            if (sender == btnAdd)
            {
                this.displayValue += "";
            }
            if (sender == btnMinus)
            {
                this.displayValue += "";
            }
            if (sender == btnDivide)
            {
                this.displayValue += "";
            }
            if (sender == btnMultiply)
            {
                this.displayValue += "";
            }
            if (sender == btnModulus)
            {
                this.displayValue += "";
            }
            if (sender == btnC)
            {
                if (this.displayValue.Length > 1)
                {
                    string newValue = this.displayValue;
                    this.displayValue = newValue.Substring(0,newValue.Length - 1);
                }
                else
                {
                    this.displayValue = "0";
                }
                
            }
            if (sender == btnAc)
            {
                this.displayValue = "0";
            }
            if (sender == btnEquals)
            {
                
            }
            labelDisplay.Text = Convert.ToDecimal(this.displayValue).ToString("N0");
        }
    }
}