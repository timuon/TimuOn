using System;

using System.Collections.ObjectModel;

using Timuon.Models;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class UserSettingsPage : Page
    {
        public UserSettingsViewModel ViewModel { get; } = new UserSettingsViewModel();
        ObservableCollection<RSSFeed> activeFeeds = new ObservableCollection<RSSFeed>();
        public ObservableCollection<RSSFeed> ActiveFeeds { get { return activeFeeds; } }
        private RSSFeed NewFeed;
        private bool URLStatusCheck;
        ObservableCollection<Platform> activePlatforms = new ObservableCollection<Platform>();
        public ObservableCollection<Platform> ActivePlatforms { get { return activePlatforms; } }
        private bool[] PlatformsToAdd = new bool[] { false, false, false, false, false };
        //private Platform NewPlatform;

        public UserSettingsPage()
        {
            InitializeComponent();
            ActiveRSSFeedsList.ItemsSource = ActiveFeeds;
            string[] EmptyArray = new string[] { };
            activeFeeds.Add(new RSSFeed("news.com", "News", EmptyArray));
            activeFeeds.Add(new RSSFeed("ceid.upatras.gr", "CEID", EmptyArray));
            URLStatusCheck = false;
            ConnectedPlatformsList.ItemsSource = ActivePlatforms;
            activePlatforms.Add(new Platform("Zoom", "someone@hotgmail.com"));
            activePlatforms.Add(new Platform("Teams", "someone@hotgmail.com"));
            activePlatforms.Add(new Platform("Discord", "BroThorPlaysVideogames"));
        }

        private void ClearButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Clear inputs
            URLBox.Text = "";
            SyncFeedButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            FeedStatusBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            NameBox.Text = "";
            CategoryCombo.SelectedIndex = -1;
            NewFeed = null;
            URLStatusCheck = false;
        }

        private async void AddButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (URLStatusCheck)
            {
                // Update RSS Feed info
                string[] Categories = new string[] { (string)CategoryCombo.SelectedValue };
                NewFeed.UpdateFeed(NameBox.Text, Categories);
                // TODO: add feed to user
                // Add it to list
                activeFeeds.Add(NewFeed);
                NewFeed = null;
                // Clear inputs
                URLBox.Text = "";
                SyncFeedButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                FeedStatusBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                NameBox.Text = "";
                CategoryCombo.SelectedIndex = -1;
                URLStatusCheck = false;
            }
            else
            {
                // Force status check
                ContentDialogResult result;
                ContentDialog StatusCheckRequiredDialog = new ContentDialog
                {
                    Title = "RSS Feed Status Check",
                    Content = "Please check the status of the URL you provided before adding it. " +
                    "There is a handy sync button right next to the URL field.",
                    CloseButtonText = "OK"
                };
                result = await StatusCheckRequiredDialog.ShowAsync();
            }
        }

        private async void SyncFeedButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Dummy URL status check & relevant info message
            SyncFeedButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            FeedStatusBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            URLStatusCheck = true;
            NewFeed = new RSSFeed(URLBox.Text);
            ContentDialogResult result;
            ContentDialog FeedStatusCheckInfoDialog = new ContentDialog
            {
                Title = "RSS Feed Status Check",
                Content = "IMPORTANT INFO: This application does not connect to any external systems " +
                "(out of project scope), so any URL entered is considered valid by the status check.",
                CloseButtonText = "OK"
            };
            result = await FeedStatusCheckInfoDialog.ShowAsync();
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
            if (PlatformsToAdd[3])
            {
                activePlatforms.Add(new Platform("Google", "someone@hotgmail.com"));
                // Move platform to active list
                OtherPlatformCombo.Items.Remove(OtherPlatformCombo.SelectedItem);
                // TODO: merge calendar
            }
            if (PlatformsToAdd[4])
            {
                activePlatforms.Add(new Platform("Yahoo", "someone@yahoo.gr"));
                // Move platform to active list
                OtherPlatformCombo.Items.Remove(OtherPlatformCombo.SelectedItem);
                // TODO: merge calendar
            }

            PlatformsToAdd = new bool[] { false, false, false, false, false };
        }

        private async void OtherPlatformCombo_DropDownClosed(object sender, object e)
        {
            if (OtherPlatformCombo.SelectedValue != null)
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

                if ((string)OtherPlatformCombo.SelectedValue == "Google")
                {
                    PlatformsToAdd[3] = true;
                }
                else
                {
                    PlatformsToAdd[4] = true;
                }
            }
        }
    }
}
