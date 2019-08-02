﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout1 : ContentPage
    {
        private List<string> _DialDisplay = new List<string>();
        public GridLayout1()
        {
            InitializeComponent();
        }

        private void UpdateLblDisplay()
        {
            this.LblDisplay.Text = String.Join(String.Empty, _DialDisplay);
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("1");
            UpdateLblDisplay();
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("2");
            UpdateLblDisplay();
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("3");
            UpdateLblDisplay();
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("4");
            UpdateLblDisplay();
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("5");
            UpdateLblDisplay();
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("6");
            UpdateLblDisplay();
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("7");
            UpdateLblDisplay();
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("8");
            UpdateLblDisplay();
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("9");
            UpdateLblDisplay();
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            _DialDisplay.Add("0");
            UpdateLblDisplay();
        }

        private void BtnBackspace_Clicked(object sender, EventArgs e)
        {
            if(_DialDisplay.Count() > 0)
            {
                _DialDisplay.Remove(_DialDisplay.Last());
                UpdateLblDisplay();
            }
        }
    }
}