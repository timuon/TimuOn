using System;

using Timuon.ViewModels;
using System.Collections.ObjectModel;

using Timuon.Models;
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

        private void Box_CheckedChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if ((YesAdd.IsChecked == true ) & (NoAdd.IsChecked == false))
            {
                AddCombobox.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else if ((NoAdd.IsChecked == true) &(YesAdd.IsChecked == false))
            {
                AddCombobox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                ContentDialog coursee = new ContentDialog()
                {
                    Title = "So, everything is ready for your courses!",
                    Content = "Maybe you want to redirect to Schedule tab to see your schedule!",
                    CloseButtonText = "Close dialog"
                };
                coursee.ShowAsync();
            }
        }
      
        private void AddCourses_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            CanAttend.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Linee.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AttendCheckYes.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AttendCheckNo.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }
        private void Attend_CheckedChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if ((AttendCheckYes.IsChecked == true) & (AttendCheckNo.IsChecked == false))
            {
                ConflictBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                CantAttendBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CantAttendCombo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ReasonAttend.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else if ((AttendCheckNo.IsChecked == true) & (AttendCheckYes.IsChecked == false))
            {
                ConflictBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CantAttendBlock.Visibility = Windows.UI.Xaml.Visibility.Visible;
                CantAttendCombo.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ReasonAttend.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialog submitt = new ContentDialog()
            {
                Title = "Submit notification!",
                Content = "Your request is being processed! You will be informed soon for its progress.",
                CloseButtonText = "Close dialog"
            };
            submitt.ShowAsync();
        }
    }
}
