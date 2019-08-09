using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainNav : ContentPage
    {
        public MainNav()
        {
            InitializeComponent();
        }

        async void DatabaseButton_Clicked(object sender, EventArgs e)
        {
            var page = new DatabaseExercise();
            await Navigation.PushAsync(page);
        }
    }
}