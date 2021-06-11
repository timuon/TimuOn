using System;
using System.Collections.Generic;
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

using System.Collections.ObjectModel;

using Timuon.Models;

using Timuon.ViewModels;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    public sealed partial class Calendar : Page
    {

        public UserSettingsViewModel ViewModel { get; } = new UserSettingsViewModel();
        ObservableCollection<RSSFeed> activeFeeds = new ObservableCollection<RSSFeed>();
        public ObservableCollection<RSSFeed> ActiveFeeds { get { return activeFeeds; } }
        private RSSFeed NewFeed;
        private bool URLStatusCheck;
        ObservableCollection<EclassIntegration> eclassAccounts = new ObservableCollection<EclassIntegration>();
        public ObservableCollection<EclassIntegration> EclassAccounts { get { return eclassAccounts; } }
        ObservableCollection<Platform> activePlatforms = new ObservableCollection<Platform>();
        public ObservableCollection<Platform> ActivePlatforms { get { return activePlatforms; } }
        private bool[] PlatformsToAdd = new bool[] { false, false, false, false, false };
        public Calendar()
        {
            this.InitializeComponent();
            ConnectedPlatformsList.ItemsSource = ActivePlatforms;
            activePlatforms.Add(new Platform("Zoom", "someone@hotgmail.com"));
            activePlatforms.Add(new Platform("Teams", "someone@hotgmail.com"));
            activePlatforms.Add(new Platform("Discord", "BroThorPlaysVideogames"));
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

        private async void DisplayDriveConnect()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "Save your Life!!!",
                Content = "Choose one of the obligations in Conflicts",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayDriveConnect();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            soft.Background = new SolidColorBrush(Windows.UI.Colors.DarkGoldenrod);

            bar.Value = 0;
            Drive_Title.Text = "You have no Conflicts";
            Drive_sub.Text = "Well Done!";
            save_the_plan.IsEnabled = false;
        }

        private async void ConnectWebexButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialogResult result;
            ContentDialog ExternalPlatformInfoDialog = new ContentDialog
            {
                Title = "External Platform Connection",
                Content = "IMPORTANT INFO: This application does not connect to any external systems " +
                "(out of project scope), so let's pretend that the appropriate authorisation was given.",
                CloseButtonText = "OK"
            };
            result = await ExternalPlatformInfoDialog.ShowAsync();
            ConnectWebexButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            PlatformsToAdd[0] = true;
        }

        private async void ConnectSkypeButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialogResult result;
            ContentDialog ExternalPlatformInfoDialog = new ContentDialog
            {
                Title = "External Platform Connection",
                Content = "IMPORTANT INFO: This application does not connect to any external systems " +
                "(out of project scope), so let's pretend that the appropriate authorisation was given.",
                CloseButtonText = "OK"
            };
            result = await ExternalPlatformInfoDialog.ShowAsync();
            ConnectSkypeButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            PlatformsToAdd[1] = true;
        }

        private async void ConnectFbButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialogResult result;
            ContentDialog ExternalPlatformInfoDialog = new ContentDialog
            {
                Title = "External Platform Connection",
                Content = "IMPORTANT INFO: This application does not connect to any external systems " +
                "(out of project scope), so let's pretend that the appropriate authorisation was given.",
                CloseButtonText = "OK"
            };
            result = await ExternalPlatformInfoDialog.ShowAsync();
            ConnectFbButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            PlatformsToAdd[2] = true;
        }

        private void AddPlatformButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (PlatformsToAdd[0])
            {
                activePlatforms.Add(new Platform("Webex", "someone@upatras.gr"));
                // Move platform to active list
                WebexBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            if (PlatformsToAdd[1])
            {
                activePlatforms.Add(new Platform("Skype", "someone_98"));
                // Move platform to active list
                SkypeBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            if (PlatformsToAdd[2])
            {
                activePlatforms.Add(new Platform("Facebook", "someone@hotgmail.com"));
                // Move platform to active list
                FbBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }

            PlatformsToAdd = new bool[] { false, false, false, false, false };
        }

        private async void DisplayDriveConnect2()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "You Imported successfuly",
                Content = "Lets just say it works, ok? Assume file import of windows is on. Press ok",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }

        private void import_Click(object sender, RoutedEventArgs e)
        {
            DisplayDriveConnect2();
        }
    }
}
