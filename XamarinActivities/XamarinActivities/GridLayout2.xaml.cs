using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout2 : ContentPage
    {
        private string result;
        public GridLayout2()
        {
            InitializeComponent();
            lblResult.Text = "";

        }
        private void LblResult_ValueChanged(object sender, EventArgs e)
        {
            if (lblResult.Text.Length+1 <= 11)
            {
                Button button = (Button)sender;
                var number = lblResult.Text;

                number = number + button.Text;
                lblResult.Text = String.Format("{0:n0}", Double.Parse(number));

                result += button.Text;
            }

        }

        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(new DataTable().Compute(result, null));
            lblResult.Text = total.ToString();
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result = "";
        }

        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += "/";
        }

        private void BtnMultiply_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += "*";
        }

        private void BtnSubtract_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += btnSubtract.Text;
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += btnAdd.Text;
        }


    }
}