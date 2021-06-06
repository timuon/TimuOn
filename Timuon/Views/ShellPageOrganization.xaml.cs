using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    // TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    public sealed partial class ShellPageOrganization : Page
    {
        public ShellOrganizationViewModel ViewModel { get; } = new ShellOrganizationViewModel();

        public ShellPageOrganization()
        {
            //geia
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame, navigationView, KeyboardAccelerators);
        }
    }
}
