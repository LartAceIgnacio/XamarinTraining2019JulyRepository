﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExercise1Page : ContentPage
    {
        public GridExercise1Page()
        {
            InitializeComponent();
        }

        private void Number_Input(object sender, EventArgs e)
        {
            var _button = (Button)sender;
            displayedNumbers.Text += _button.Text;         
        }
      
    }
}