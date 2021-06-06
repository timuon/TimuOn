using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class AdminSysConstrPage : Page
    {
        public AdminSysConstrViewModel ViewModel { get; } = new AdminSysConstrViewModel();

        public AdminSysConstrPage()
        {
            InitializeComponent();
        }
    }
}
