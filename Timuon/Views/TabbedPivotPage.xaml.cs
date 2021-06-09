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
            Rss_Feed_frame.Loaded += PivotItem_Loaded;
            
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {


        }

        private void PivotItem_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Rss_Feed_frame.Navigate(typeof(Rss_Feed));
            Calendar_frame.Navigate(typeof(MainPage));
        }
    }
}
