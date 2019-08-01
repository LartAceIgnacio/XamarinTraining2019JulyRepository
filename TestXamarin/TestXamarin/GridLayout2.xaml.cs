using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout2 : ContentPage
    {
        private List<string> Display = new List<string>();
        public GridLayout2()
        {
            InitializeComponent();
        }
        
        private void UpdateLblDisplay()
        {
            this.LblDisplay.Text = String.Format("{0:n}", String.Join(String.Empty, Display));
        }

        private void ComputeTotal()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            var result = table.Compute(String.Join(String.Empty, Display), String.Empty);
            this.LblDisplay.Text = String.Format("{0:n}", result.ToString());
        }

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            Display.Clear();
            UpdateLblDisplay();
        }

        private void BtnPosNeg_Clicked(object sender, EventArgs e)
        {
            UpdateLblDisplay();
        }

        private void BtnPercent_Clicked(object sender, EventArgs e)
        {
            UpdateLblDisplay();
        }

        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            Display.Add("/");
            UpdateLblDisplay();
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            Display.Add("7");
            UpdateLblDisplay();
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            Display.Add("8");
            UpdateLblDisplay();
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            Display.Add("9");
            UpdateLblDisplay();
        }

        private void BtnMultiply_Clicked(object sender, EventArgs e)
        {
            Display.Add("*");
            UpdateLblDisplay();
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            Display.Add("4");
            UpdateLblDisplay();
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            Display.Add("5");
            UpdateLblDisplay();
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            Display.Add("6");
            UpdateLblDisplay();
        }

        private void BtnSubtract_Clicked(object sender, EventArgs e)
        {
            Display.Add("-");
            UpdateLblDisplay();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Display.Add("1");
            UpdateLblDisplay();
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Display.Add("2");
            UpdateLblDisplay();
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Display.Add("3");
            UpdateLblDisplay();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            Display.Add("+");
            UpdateLblDisplay();
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            Display.Add("0");
            UpdateLblDisplay();
        }

        private void BtnDecimal_Clicked(object sender, EventArgs e)
        {
            Display.Add(".");
            UpdateLblDisplay();
        }

        private void BtnEquals_Clicked(object sender, EventArgs e)
        {
            ComputeTotal();
        }
    }
}