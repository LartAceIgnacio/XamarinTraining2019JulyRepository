using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinActivities.Model;

namespace XamarinActivities
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> lstMenu { get; set; }
        public MainPage()
        {
            InitializeComponent();
            lstMenu = new List<MasterPageItem>();

            InitMenuList();
            
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(E6ContactDetailsPage)));
        }

        private void InitMenuList()
        {
            lstMenu = new List<MasterPageItem>()
            {
                new MasterPageItem() { Title = "Quote Page", Icon = "", TargetType = typeof(QuotePage) },
                new MasterPageItem() { Title = "RGB Page", Icon = "", TargetType = typeof(RGBPage) },
                new MasterPageItem() { Title = "StackLayout 1", Icon = "", TargetType = typeof(StackLayout1) },
                new MasterPageItem() { Title = "StackLayout 2", Icon = "", TargetType = typeof(StackLayout2) },
                new MasterPageItem() { Title = "GridLayout1", Icon = "", TargetType = typeof(GridLayout1) },
                new MasterPageItem() { Title = "GridLayout2", Icon = "", TargetType = typeof(GridLayout2) },
                new MasterPageItem() { Title = "AbsoluteLayout", Icon = "", TargetType = typeof(E3AbsoluteLayout1) },
                new MasterPageItem() { Title = "RelativeLayout", Icon = "", TargetType = typeof(E3RelativeLayout) },
                new MasterPageItem() { Title = "Image Page 1", Icon = "", TargetType = typeof(E4ImageExercised1) },
                new MasterPageItem() { Title = "Image Page 2", Icon = "", TargetType = typeof(E4ImagePage) },
                new MasterPageItem() { Title = "Contact Page", Icon = "", TargetType = typeof(E5ContactPage) }
            };

            lstNavigationDrawer.ItemsSource = lstMenu;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
