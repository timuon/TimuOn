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

        public UserSettingsPage()
        {
            InitializeComponent();
            ActiveRSSFeedsList.ItemsSource = ActiveFeeds;
            string[] EmptyArray = new string[] { };
            activeFeeds.Add(new RSSFeed("news.com", "News", EmptyArray));
            activeFeeds.Add(new RSSFeed("ceid.upatras.gr", "CEID", EmptyArray));
            URLStatusCheck = false;
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
    }
}
