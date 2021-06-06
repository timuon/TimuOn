using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class UserSettingsPage : Page
    {
        public UserSettingsViewModel ViewModel { get; } = new UserSettingsViewModel();

        public UserSettingsPage()
        {
            InitializeComponent();
        }
    }
}
