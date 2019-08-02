using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayout : ContentPage
    {
        public RelativeLayout()
        {
            InitializeComponent();
            this.LblDescription.Text = "Because you can reach people who aren't on SkyApp by calling mobile and landline numbers, or spending SMS, at low-cost rates.";
        }
    }
}