using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarin
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
    }

    public class PeopleList : List<Person>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public PeopleList(string longName, string shortName)
        {
            LongName = longName;
            ShortName = shortName;
        }
    }

    public class CustomContactCell : StackLayout
    {
        BoxView Avatar = new BoxView();
        Label Initials = new Label();
        Label FullName = new Label();
        Label ContactNo = new Label();
        String initials = "";
        String fullname = "";
        String contactno = "";
        String hex = "";


        public CustomContactCell(Person person, string color)
        {
            initials = String.Format("{0}{1}", person.FirstName[0], person.LastName[0]);
            fullname = String.Format("{0} {1}", person.FirstName, person.LastName);
            contactno = person.ContactNo;
            hex = color;

            new BoxView()
            {
                BackgroundColor = Color.FromHex(color),
            };
            new Label()
            {
                Text = initials
            };
        }
    }

    public class CustomCell : ViewCell
    {
        //Initialization
        StackLayout cellWrapper = new StackLayout();

        AbsoluteLayout avatarLayout = new AbsoluteLayout();
        BoxView ContactAvatar = new BoxView();
        Label ContactInitials = new Label();

        StackLayout horizontalLayout = new StackLayout();
        StackLayout stackLabelsLayout = new StackLayout();
        Label ContactFullName = new Label();
        Label ContactNumber = new Label();

        public static readonly BindableProperty ContactFullNameProperty = BindableProperty.Create("FullName",
            typeof(string), typeof(CustomCell), "FullName");
        public static readonly BindableProperty ContactNumberProperty = BindableProperty.Create("ContactNumber",
            typeof(string), typeof(CustomCell), "ContactNumber");
        public static readonly BindableProperty ContactInitialsProperty = BindableProperty.Create("Initials",
            typeof(string), typeof(CustomCell), "Initials");
        public static readonly BindableProperty AvatarBackgroundColorProperty = BindableProperty.Create("Color",
            typeof(string), typeof(CustomCell), "Color");
        
        public string FullName
        {
            get { return (string)GetValue(ContactFullNameProperty); }
            set { SetValue(ContactFullNameProperty, value); }
        }

        public CustomCell()
        {
            //Set binding
            ContactInitials.SetBinding(Label.TextProperty, "IN");
            ContactFullName.SetBinding(Label.TextProperty, "Full Name");
            ContactNumber.SetBinding(Label.TextProperty, "Contact No.");
            
            //Set design properties
            cellWrapper.Orientation = StackOrientation.Vertical;
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            stackLabelsLayout.Orientation = StackOrientation.Vertical;

            ContactAvatar.BackgroundColor = Color.FromHex("#0093ff");
            ContactInitials.TextColor = Color.White;

            //Add to view
            stackLabelsLayout.Children.Add(ContactFullName);
            stackLabelsLayout.Children.Add(ContactNumber);

            horizontalLayout.Children.Add(stackLabelsLayout);

            cellWrapper.Children.Add(horizontalLayout);
            View = cellWrapper;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if(BindingContext != null)
            {
                
            }
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts_List : ContentPage
    {
        private readonly List<PeopleList> contacts = new List<PeopleList>
        {
            new PeopleList("Letter A", "A")
            {
                new Person
                {
                    FirstName = "Aaron Edwigg",
                    LastName = "Custodio",
                    ContactNo = "298395723"
                },
                new Person
                {
                    FirstName = "Arnold Allan",
                    LastName = "Mendoza",
                    ContactNo = "2389274832"
                },
            },
            new PeopleList("Letter C", "C")
            {
                new Person
                {
                    FirstName = "Charles Ken'ichi",
                    LastName = "Nazareno",
                    ContactNo = "297493824"
                }
            },
            new PeopleList("Letter D", "D")
            {
                new Person
                {
                    FirstName = "Dino Angelo",
                    LastName = "Reyes",
                    ContactNo = "297329"
                },
            },
            new PeopleList("Letter F", "F")
            {
                new Person
                {
                    FirstName = "Felix Alexander",
                    LastName = "Carao",
                    ContactNo = "09074932"
                },
            },
            new PeopleList("Letter J", "J")
            {                
                new Person
                {
                    FirstName = "Jasper",
                    LastName = "Orilla",
                    ContactNo = "30932874"
                },
                new Person
                {
                    FirstName = "Jelmarose Grace",
                    LastName = "De Vera",
                    ContactNo = "09556986121"
                },
            },
            new PeopleList("Letter K", "K")
            {
                new Person
                {
                    FirstName = "Kyla Gae",
                    LastName = "Calpito",
                    ContactNo = "238274832"
                },
            },
            new PeopleList("Letter M", "M")
            {
                new Person
            {
                FirstName = "Marc Kenneth",
                LastName = "Lomio",
                ContactNo = "349289"
            },
            new Person
            {
                FirstName = "Melrose",
                LastName = "Mejidana",
                ContactNo = "193812942"
            },
            new Person
            {
                FirstName = "Mermellah",
                LastName = "Angni",
                ContactNo = "289463287"
            },
            }
        };

        private ObservableCollection<PeopleList> _results = new ObservableCollection<PeopleList>();
        private readonly Dictionary<char, string> colors = new Dictionary<char, string>()
        {
            { 'A', "#000000" },
            { 'B', "#000000" },
            { 'C', "#000000" },
            { 'D', "#000000" },
            { 'E', "#000000" },
            { 'F', "#000000" },
            { 'G', "#000000" },
            { 'H', "#000000" },
            { 'I', "#000000" },
            { 'J', "#000000" },
            { 'K', "#000000" },
            { 'L', "#000000" },
            { 'M', "#000000" },
            { 'N', "#000000" },
            { 'O', "#000000" },
            { 'P', "#000000" },
            { 'Q', "#000000" },
            { 'R', "#000000" },
            { 'S', "#000000" },
            { 'T', "#000000" },
            { 'U', "#000000" },
            { 'V', "#000000" },
            { 'W', "#000000" },
            { 'X', "#000000" },
            { 'Y', "#000000" },
            { 'Z', "#000000" },

        };
        public Contacts_List()
        {
            InitializeComponent();
            //this.ContactsList.ItemTemplate = new DataTemplate(typeof(CustomCell));
            this.ContactsList.ItemsSource = contacts;
            
        }
        /*
        private ObservableCollection<PeopleList> GetSearchResults(string query)
        {
            var people = new ObservableCollection<PeopleList>();
            var results = people.Where(group => group.All(
                person => person.FirstName.ToLower().Contains(query.ToLower()) ||
                          person.LastName.ToLower().Contains(query.ToLower()) ||
                          person.ContactNo.Contains(query.ToLower())
            ));
            ObservableCollection<PeopleList> searchResults = new ObservableCollection<PeopleList>(results);
            return searchResults;
        }
        */
        private ObservableCollection<PeopleList> GetSearchResults(string query)
        {
            var people = new ObservableCollection<PeopleList>(contacts);
            var results = people.Where(group => group.All(
                person => person.FirstName.ToLower().Contains(query.ToLower()) ||
                          person.LastName.ToLower().Contains(query.ToLower()) ||
                          person.ContactNo.Contains(query.ToLower())
            ));
            ObservableCollection<PeopleList> searchResults = new ObservableCollection<PeopleList>(results);
            return searchResults;
        }

        private void ContactSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(String.IsNullOrEmpty(e.NewTextValue) || String.IsNullOrWhiteSpace(e.NewTextValue))
            {
                this.ContactsList.ItemsSource = contacts;
            }
            else
            {
                _results = GetSearchResults(e.NewTextValue);
                this.ContactsList.ItemsSource = _results;
            }
        }
    }
}