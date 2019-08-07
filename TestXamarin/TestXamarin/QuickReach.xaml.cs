using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;

namespace TestXamarin
{

    public class Category
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickReach : ContentPage
    {
        private const string localUrl = "https://10.10.1.20:45456/api/categories";
        private readonly HttpClient _httpClient = new HttpClient();
        private ObservableCollection<Category> _categories;
        public QuickReach()
        {
            InitializeComponent();
            this.Appearing += QuickReach_Appearing;
        }

        private async void QuickReach_Appearing(object sender, EventArgs e)
        {
            string content = await _httpClient.GetStringAsync(localUrl);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(content);
            _categories = new ObservableCollection<Category>(categories);

            this.categories.ItemsSource = _categories; ;
        }


        protected override async void OnAppearing()
        {
            string content = await _httpClient.GetStringAsync(localUrl);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(content);
            _categories = new ObservableCollection<Category>(categories);

            this.categories.ItemsSource = _categories;
        }
    }
}