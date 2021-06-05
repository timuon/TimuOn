using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class AdminHomePage : Page
    {
        public AdminHomeViewModel ViewModel { get; } = new AdminHomeViewModel();

        public AdminHomePage()
        {
            InitializeComponent();
        }
    }
}
