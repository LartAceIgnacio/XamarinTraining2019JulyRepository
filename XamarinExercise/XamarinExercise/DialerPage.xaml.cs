using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DialerPage : ContentPage
    {
        public DialerPage()
        {
            InitializeComponent();           
        }

        void OnButtonPress(object sender ,EventArgs e)
        {

            string inputText = (sender as Button).Text;
            string labelText = LabelDisplay.Text;

            labelText = inputText;
            LabelDisplay.Text += labelText;
        }
    }
}