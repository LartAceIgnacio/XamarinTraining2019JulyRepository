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
        private int count = 0;
        public GridLayout2()
        {
            InitializeComponent();

        }
        private void LblResult_ValueChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (count == 3)
            {
                lblResult.Text += ",";
                count = 0;
            }

            if(pressed == btnDot.Text)
            {
                count = 0;
            }

            lblResult.Text += pressed;
            count += 1;
            result += pressed;
        }

        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(new DataTable().Compute(result, null));
            lblResult.Text = String.Format("{0:n}", total);
            result = "";
            count = 0;
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            count = 0;
        }

        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += "/";
            count = 0;
        }

        private void BtnMultiply_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += "*";
            count = 0;
        }

        private void BtnSubtract_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += btnSubtract.Text;
            count = 0;
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            lblResult.Text = "";
            result += btnAdd.Text;
            count = 0;
        }


    }
}