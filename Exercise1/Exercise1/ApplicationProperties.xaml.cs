using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationProperties : ContentPage
    {
        public ApplicationProperties()
        {
            InitializeComponent();
            switch1.Toggled += Switch1_Toggled;
        }
        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            //Clear all Properties
            Application.Current.Properties.Clear();
            ClearAll();
            DisplayAlert("Success", "All Values Cleared", "OK");
        }
        
        private void BtnStore_Clicked(object sender, EventArgs e)
        {
            // Store all  Values
            Application.Current.Properties["ID"] = txtId.Text;
            Application.Current.Properties["Name"] = txtName.Text;
            Application.Current.Properties["Address"] = txtAddress.Text;
            Application.Current.Properties["IsActive"] = switch1.IsToggled;
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            DisplayAlert("Confirm", "Are you sure to add?", "OK", "Cancel");
            
            
        }
        
        private void Switch1_Toggled(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["IsActive"] = switch1.IsToggled;
        }
        private void BtnRemove_Clicked(object sender, EventArgs e)
        {
            //Remove all Properties
            if (Application.Current.Properties.ContainsKey("ID"))
            {
                Application.Current.Properties.Remove("ID");
                Application.Current.Properties.Remove("Name");
                Application.Current.Properties.Remove("Address");
                Application.Current.Properties.Remove("IsActive");
                ClearAll();
                DisplayAlert("Success", "All Vaues Removed", "OK");
            }
        }
        private void BtnGet_Clicked(object sender, EventArgs e)
        {
            //Get all Values
            if (Application.Current.Properties.ContainsKey("ID"))
            {
                lblId.Text = Application.Current.Properties["ID"].ToString();
                lblName.Text = Application.Current.Properties["Name"].ToString();
                lblAddress.Text = Application.Current.Properties["Address"].ToString();
                lblIsActive.Text = Application.Current.Properties["IsActive"].ToString();
            }
        }
        public void ClearAll()
        {
            lblId.Text = string.Empty;
            lblName.Text = string.Empty;
            lblAddress.Text = string.Empty;
            lblIsActive.Text = string.Empty;
        }
    }
}