using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinEssentials.Exercises.Models;

namespace XamarinEssentials.Exercises
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

            menuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Quotes Page", Icon = "quote.png", TargetType = typeof(Exercise1) };
            var page2 = new MasterPageItem() { Title = "Box Color", Icon = "color.png", TargetType = typeof(Exercise2) };
            var page3 = new MasterPageItem() { Title = "Login Page", Icon = "login.png", TargetType = typeof(StackLayout_Exercise1) };
            var page4 = new MasterPageItem() { Title = "Wannabe Instagram", Icon = "instagram.png", TargetType = typeof(StackLayout_Exercise2) };
            var page5 = new MasterPageItem() { Title = "Phone", Icon = "phone.png", TargetType = typeof(Grid_Exercise1) };
            var page6 = new MasterPageItem() { Title = "Calculator", Icon = "calculator.png", TargetType = typeof(Grid_Exercise2) };
            var page7 = new MasterPageItem() { Title = "Relax with Flowers", Icon = "flower.png", TargetType = typeof(AbsoluteLayout_Exercise) };
            var page8 = new MasterPageItem() { Title = "Pay for Credits", Icon = "money.png", TargetType = typeof(RelativeLayout_Exercise) };
            var page9 = new MasterPageItem() { Title = "Image Gallery", Icon = "gallery.png", TargetType = typeof(Images_Exercise2) };
            var page10 = new MasterPageItem() { Title = "Image Slideshow", Icon = "image.png", TargetType = typeof(Images_Exercise1) };
            var page11 = new MasterPageItem() { Title = "Contacts", Icon = "contacts.png", TargetType = typeof(ListView_Exercise) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8);
            menuList.Add(page9);
            menuList.Add(page10);
            menuList.Add(page11);

            navigationDrawerList.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Exercise1)));
        }

        private void NavigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
