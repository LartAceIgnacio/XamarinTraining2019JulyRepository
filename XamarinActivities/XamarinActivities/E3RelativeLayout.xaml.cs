using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinActivities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E3RelativeLayout : ContentPage
    {
        public E3RelativeLayout()
        {
            InitializeComponent();
            lblPrice.Text = "$11.95";
            btnAddCredit.Text = "Add $7.99 Credit";
            lblDescription.Text = "Because you can reach people who aren't on SkyApp by calling mobile and landline numbers, or spending SMS, at low-cost rates.";
            lblTitle.Text = "Why pay for credit"; 
        }
    }
}