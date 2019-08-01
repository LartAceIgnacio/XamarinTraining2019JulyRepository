using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExcercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExercise1 : ContentPage
    {
        public GridExercise1()
        {
            InitializeComponent();
        }

        private void Number_Clicked(object sender, EventArgs e)
        {
            this.numberLabel.Text = this.numberLabel.Text + (sender as Button).Text;
        }
    }
}