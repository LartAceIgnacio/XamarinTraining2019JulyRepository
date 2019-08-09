using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinExercise.Models;

namespace XamarinExercise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MenuItems> menuList { get; set; }
        public MainPage()
        {
            InitializeComponent();

            menuList = new List<MenuItems>();

            var page1 = new MenuItems() { Title = "QuoteSlider", Icon = "About.png", TargetType = typeof(Exercise1) };
            var page2 = new MenuItems() { Title = "ColorPicker", Icon = "About.png", TargetType = typeof(Exercise2) };
            var page3 = new MenuItems() { Title = "Instagram", Icon = "About.png", TargetType = typeof(InstagramPage) };
            var page4 = new MenuItems() { Title = "Dialer", Icon = "About.png", TargetType = typeof(DialerPage) };
            var page5 = new MenuItems() { Title = "Calculator", Icon = "About.png", TargetType = typeof(CalculatorPage) };
            var page6 = new MenuItems() { Title = "AbsoluteLayout", Icon = "About.png", TargetType = typeof(AbsoluteLayoutPage) };
            var page7 = new MenuItems() { Title = "RelativeLayout", Icon = "About.png", TargetType = typeof(RelativeLayoutPage) };
            var page8 = new MenuItems() { Title = "Images", Icon = "About.png", TargetType = typeof(GridImages) };
            var page9 = new MenuItems() { Title = "GridImages", Icon = "About.png", TargetType = typeof(LoginPage) };
            var page10 = new MenuItems() { Title = "ImageGallery", Icon = "About.png", TargetType = typeof(ImageGallery) };
            var page11 = new MenuItems() { Title = "Contacts", Icon = "About.png", TargetType = typeof(ContactsPage) };

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
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ContactsPage)));
        }
        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuItems)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }


    }
}
