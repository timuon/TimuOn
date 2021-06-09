using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class UserSettingsPage : Page
    {
        public UserSettingsViewModel ViewModel { get; } = new UserSettingsViewModel();
        private bool URLStatusCheck;

        public UserSettingsPage()
        {
            InitializeComponent();
            URLStatusCheck = false;
        }

        private void ClearButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            URLBox.Text = "";
            SyncFeedButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            FeedStatusBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            NameBox.Text = "";
            CategoryCombo.SelectedIndex = -1;
        }

        private void AddButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (URLStatusCheck)
            {
                // stuff
            }
            else
            {
                // Not in project use cases
            }
        }

        private async void SyncFeedButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            SyncFeedButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            FeedStatusBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            URLStatusCheck = true;
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
