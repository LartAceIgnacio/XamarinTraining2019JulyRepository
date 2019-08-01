using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExcercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExercise2 : ContentPage
    {
        double output = 0;
        string equation = " ";
        bool equate = false;
        double result = 0;
        bool Reset = false;

        public GridExercise2()
        {
            InitializeComponent();
        }

        private void Number_Clicked(object sender, EventArgs e)
        {
            if(Reset)
            {
                if (numberLabel.Text.Length < 11)
                {
                    numberLabel.Text = "";
                    double holder = Double.Parse(numberLabel.Text + (sender as Button).Text);
                    numberLabel.Text = String.Format("{0:#,##0}", holder);
                    Reset = false;
                }
            }
            else
            {
                double holder = Double.Parse(numberLabel.Text + (sender as Button).Text);
                numberLabel.Text = String.Format("{0:#,##0}", holder);
            }
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            numberLabel.Text = "0";
            equation = "";
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {

                if (equate)
                {
                    equation += numberLabel.Text;
                    equation = equation.Replace(",", "");
                    result = Convert.ToDouble(new DataTable().Compute(equation, null));
                    //equate = true;
                    Reset = true;
                    numberLabel.Text = result.ToString("N0");
                    equation = numberLabel.Text + "+";
                }
                else
                {
                    equation += numberLabel.Text + "+";
                    equate = true;
                    Reset = true;

                }



            //equation += numberLabel.Text + "+";

        }
        private void Minus_Clicked(object sender, EventArgs e)
        {
            if (equate)
            {
                equation += numberLabel.Text;
                equation = equation.Replace(",", "");
                result = Convert.ToDouble(new DataTable().Compute(equation, null));
                //equate = true;
                Reset = true;
                numberLabel.Text = result.ToString("N0");
                equation = numberLabel.Text + "-";
            }
            else
            {
                equation += numberLabel.Text + "-";
                equate = true;
                Reset = true;

            }
        }
        private void Times_Clicked(object sender, EventArgs e)
        {
            if (equate)
            {
                equation += numberLabel.Text;
                equation = equation.Replace(",", "");
                result = Convert.ToDouble(new DataTable().Compute(equation, null));
                //equate = true;
                Reset = true;
                numberLabel.Text = result.ToString("N0");
                equation = numberLabel.Text + "*";
            }
            else
            {
                equation += numberLabel.Text + "*";
                equate = true;
                Reset = true;

            }
        }
        private void Divide_Clicked(object sender, EventArgs e)
        {
            if (equate)
            {
                equation += numberLabel.Text;
                equation = equation.Replace(",", "");
                result = Convert.ToDouble(new DataTable().Compute(equation, null));
                //equate = true;
                Reset = true;
                numberLabel.Text = result.ToString("N0");
                equation = numberLabel.Text + "/";
            }
            else
            {
                equation += numberLabel.Text + "/";
                equate = true;
                Reset = true;

            }
        }


    }
}