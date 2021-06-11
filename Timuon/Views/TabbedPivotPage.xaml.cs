using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class TabbedPivotPage : Page
    {
        public TabbedPivotViewModel ViewModel { get; } = new TabbedPivotViewModel();

        public TabbedPivotPage()
        {
            InitializeComponent();
            Loaded += Page_Loaded;
            history_frame.Loaded += PivotItem_Loaded_1;
            subs_frame.Loaded += PivotItem_Loaded_2;
            calendar_frame.Loaded += PivotItem_Loaded_3;
            Teams_frame.Loaded += PivotItem_Loaded_4;
            rss_frame.Loaded += PivotItem_Loaded_5;
            
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {


        }

        private void PivotItem_Loaded_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            history_frame.Navigate(typeof(History_Log));
        }

        private void PivotItem_Loaded_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
           subs_frame.Navigate(typeof(Subscriptions));
        }

        private void PivotItem_Loaded_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            calendar_frame.Navigate(typeof(Calendar));
        }

        private void PivotItem_Loaded_4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void PivotItem_Loaded_5(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            rss_frame.Navigate(typeof(RSSFeedSettingsPage));
        }
    }
}
