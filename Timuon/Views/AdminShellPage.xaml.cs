using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    // TODO WTS: Change the icons and titles for all NavigationViewItems in AdminShellPage.xaml.
    public sealed partial class AdminShellPage : Page
    {
        public AdminShellViewModel ViewModel { get; } = new AdminShellViewModel();

        public AdminShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
        }
    }
}
