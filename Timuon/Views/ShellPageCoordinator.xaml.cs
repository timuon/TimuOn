using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    // TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    public sealed partial class ShellPageCoordinator : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPageCoordinator()
        {

            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
        }
    }
}
