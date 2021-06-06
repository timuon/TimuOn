using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace Timuon.Views
{
    public sealed partial class BlankPage : Page
    {
        public CoursesStudentViewModel ViewModel { get; } = new CoursesStudentViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
