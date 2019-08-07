using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinActivities.Models;

namespace XamarinActivities
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>()
            {
                new MasterPageItem() { Title = "Home", Icon = "arrow_right.png", TargetType = typeof(WelcomePage) },
                new MasterPageItem() { Title = "Quotes", Icon = "arrow_right.png", TargetType = typeof(QuotesPage) },
                new MasterPageItem() { Title = "Box Color", Icon = "arrow_right.png", TargetType = typeof(BoxColorPage) },
                new MasterPageItem() { Title = "Calculator", Icon = "arrow_right.png", TargetType = typeof(CalculatorPage) },
                new MasterPageItem() { Title = "Dial Pad", Icon = "arrow_right.png", TargetType = typeof(DialPage) },
                new MasterPageItem() { Title = "Instagram", Icon = "arrow_right.png", TargetType = typeof(InstagramPage) },
                new MasterPageItem() { Title = "Gallery", Icon = "arrow_right.png", TargetType = typeof(GridImagePage) },
                new MasterPageItem() { Title = "Carousel", Icon = "arrow_right.png", TargetType = typeof(ImagePage) },
                new MasterPageItem() { Title = "Contacts", Icon = "arrow_right.png", TargetType = typeof(ContactsPage) },
            };
            navigationDrawer.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(WelcomePage)));
        }

        private void onMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
