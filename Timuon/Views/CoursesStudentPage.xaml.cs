using System;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace Timuon.Views
{
    public sealed partial class CoursesStudentPage : Page
    {
        public CoursesStudentViewModel ViewModel { get; } = new CoursesStudentViewModel();

        public CoursesStudentPage()
        {
            InitializeComponent();
        }
    }
}
