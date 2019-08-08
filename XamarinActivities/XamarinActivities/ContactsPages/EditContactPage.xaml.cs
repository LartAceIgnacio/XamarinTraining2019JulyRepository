﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinActivities.Models;

namespace XamarinActivities.ContactsPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditContactPage : ContentPage
    {
        Contact _contact;
        private EventHandler<Contact> EditContactEventHandler;
        public EditContactPage(Contact contact, EventHandler<Contact> editContactEventHandler)
        {
            InitializeComponent();
            this.BindingContext = contact;
            _contact = contact;
            EditContactEventHandler = editContactEventHandler;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact newContact = new Contact(firstName.Text, lastName.Text, mobileNumber.Text, emailAddress.Text, facebookLink.Text, instagramLink.Text);
            EditContactEventHandler?.Invoke(this, newContact);
            Navigation.PopModalAsync();
            Navigation.PopModalAsync();
        }
    }
}