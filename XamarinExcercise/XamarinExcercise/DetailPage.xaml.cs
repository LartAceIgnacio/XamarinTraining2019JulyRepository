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
    public partial class DetailPage : ContentPage
    {
        private Person _person;
        public DetailPage(Person person )
        {
            InitializeComponent();
            this._person = person;
            Name.Text = person.FullName;
            initial.Text = person.Initial;

        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PopModalAsync();
        }
    }
}