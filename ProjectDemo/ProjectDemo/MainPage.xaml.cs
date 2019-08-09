using ProjectDemo.Menuitems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectDemo
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

			var page1 = new MenuItems() { Title = "Contacts", Icon = "About.png", TargeType = typeof(ContactPage) };
			var page2 = new MenuItems() { Title = "ColorPicker", Icon = "About.png", TargeType = typeof(Page1) };
			var page3 = new MenuItems() { Title = "Instagram", Icon = "About.png", TargeType = typeof(InstagramPage) };
			var page5 = new MenuItems() { Title = "Calculator", Icon = "About.png", TargeType = typeof(CalculatorPage) };
			var page6 = new MenuItems() { Title = "AbsoluteLayout", Icon = "About.png", TargeType = typeof(AbsoluteLayoutExercise1) };
			var page7 = new MenuItems() { Title = "RelativeLayout", Icon = "About.png", TargeType = typeof(RelativeLayoutPage) };
			var page8 = new MenuItems() { Title = "Images", Icon = "About.png", TargeType = typeof(ImageExercise1Page) };
			var page9 = new MenuItems() { Title = "GridExercise", Icon = "About.png", TargeType = typeof(GridExercise1Page) };
			var page10 = new MenuItems() { Title = "StackLayout", Icon = "About.png", TargeType = typeof(StackLayoutExercise1Page) };


			menuList.Add(page1);
			menuList.Add(page2);
			menuList.Add(page3);
			menuList.Add(page5);
			menuList.Add(page6);
			menuList.Add(page7);
			menuList.Add(page8);
			menuList.Add(page9);
			menuList.Add(page10);
			navigationDrawerList.ItemsSource = menuList;
			// Initial navigation, this can be used for our home page
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CalculatorPage)));
		}
		void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = (MenuItems)e.SelectedItem;
			Type page = item.TargeType;

			Detail = new NavigationPage((Page)Activator.CreateInstance(page));
			IsPresented = false;
		}


	}
}
