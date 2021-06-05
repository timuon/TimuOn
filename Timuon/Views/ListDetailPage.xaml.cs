using System;

using Timuon.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class ListDetailPage : Page
    {
        public ListDetailViewModel ViewModel { get; } = new ListDetailViewModel();

        public ListDetailPage()
        {
            InitializeComponent();
            Loaded += ListDetailPage_Loaded;
        }

        private async void ListDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(ListDetailsViewControl.ViewState);
        }
    }
}
