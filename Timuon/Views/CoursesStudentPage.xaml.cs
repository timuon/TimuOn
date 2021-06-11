using System;

using Timuon.ViewModels;
using System.Collections.ObjectModel;

using Timuon.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using System.Collections.Generic;

namespace Timuon.Views
{
    public sealed partial class CoursesStudentPage : Page
    {
        public CoursesStudentViewModel ViewModel { get; } = new CoursesStudentViewModel();
        ObservableCollection<String> availCourses = new ObservableCollection<String>();
        ObservableCollection<String> availCourses2 = new ObservableCollection<String>();

        public ObservableCollection<String> AvailCourses { get { return availCourses; } }
        public ObservableCollection<String> AvailCourses2 { get { return availCourses2; } }

        public DateTime date1;
        public DateTime date2;
        public DateTime date3;
        public DateTime date4;
        public DateTime date5;
        public DateTime date6;
        public DateTime date7;
        public DateTime date8;
        public CoursesStudentPage()
        {
            InitializeComponent();
            List<Course> Courses = new List<Course>();
            List<Schedule> schedules = new List<Schedule>();
            AddCombobox.ItemsSource = AvailCourses;
            date1 = new DateTime(2021, 3, 1);
            date2 = new DateTime(2021, 3, 1);
            date3 = new DateTime(2021, 3, 2);
            date4 = new DateTime(2021, 3, 3);
            date5 = new DateTime(2021, 6, 1);
            date6 = new DateTime(2021, 6, 2);
            date7 = new DateTime(2021, 6, 3);
            date8 = new DateTime(2021, 6, 3);
            Courses.Add(new Course("","","","","","Object-oriented Programming", date1, date5,"","",schedules,"",""));
            Courses.Add(new Course("", "", "", "", "", "Quantum Physics", date2, date6, "", "", schedules, "", ""));
            Courses.Add(new Course("", "", "", "", "", "Molecular Biology", date3, date7, "", "", schedules, "", ""));
            Courses.Add(new Course("", "", "", "", "", "Python programming", date4, date8, "", "", schedules, "", ""));


            foreach (Course a in Courses)
            {
                availCourses.Add(a.Title);
            }

            Courses.Add(new Course("", "", "", "", "", "Data Mining", date4, date8, "", "", schedules, "", ""));

            CantAttendCombo.ItemsSource = AvailCourses2;

            foreach (Course a in Courses)
            {
                availCourses2.Add(a.Title);
            }
            DateToday.Text = DateTime.Now.ToString();
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
                if (AddCombobox.SelectedValue.ToString() == "Object-oriented Programming")
                {
                    if (DateTime.Compare(date1.Date.Date, date2.Date.Date) == 0)
                    {
                        ConflictBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                        ConflictBox.Text = "Object-oriented Programming";
                    }
                }
                
                CantAttendBlock.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CantAttendCombo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ReasonAttend.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else if ((AttendCheckNo.IsChecked == true) & (AttendCheckYes.IsChecked == false))
            {
                ConflictBox.Text = "";
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
