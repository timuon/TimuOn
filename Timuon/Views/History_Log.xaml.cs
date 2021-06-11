﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Timuon.Models;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    public sealed partial class History_Log : Page
    {
        ObservableCollection<Organization> user_org = new ObservableCollection<Organization>();
        public ObservableCollection<Organization> User_org { get { return user_org; } }
        public History_Log()
        {

            this.InitializeComponent();
            org_list.ItemsSource = User_org;
            user_org.Add(new Organization("3rd Highschool", "", "", 0, "", DateTime.Now, "", "", 0, "", "", "", "", "", "", true, ""));
            user_org.Add(new Organization("Incibio", "", "", 0, "", DateTime.Now, "", "", 0, "", "", "", "", "", "", true, ""));
            user_org.Add(new Organization("1st Elementary School", "", "", 0, "", DateTime.Now, "", "", 0, "", "", "", "", "", "", true, ""));
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }



        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add "using Windows.UI;" for Color and Colors.
            string colorName = e.AddedItems[0].ToString();
            //string color;
            //switch (colorName)
            //{
            //    case "Yellow":
            //        color = "Yellow";
            //        break;
            //    case "Green":
            //        color = "Green";
            //        break;
            //    case "Blue":
            //        color = "Blue";
            //        break;
            //    case "Red":
            //        color = "Red";
            //        break;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayDriveConnect();
            Drive_Title.Text = "Connected to Drive";
            Drive_sub.Text = "Everything looks good";   
        }
        private async void DisplayDriveConnect()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "Your Connection was successful",
                Content = "You have connected your Drive and you will now receive Log Info",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }

        //private void ToggleSwitch_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    if (Org.IsOn == true)
        //    {
        //        org_list.IsEnabled = true;
        //    }
        //    else
        //    {
        //        org_list.IsEnabled = false;
        //    }
        //}

        private void Org_Toggled(object sender, RoutedEventArgs e)
        {
            if (Org.IsOn == true)
            {
                org_list.IsEnabled = true;
            }
            else
            {
                org_list.IsEnabled = false;
            }
        }
    }
}
