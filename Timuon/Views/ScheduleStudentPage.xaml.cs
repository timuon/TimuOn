using System;

using System.Collections.Generic;

using System.Collections.ObjectModel;

using System.Linq;

using Timuon.Models;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScheduleStudentPage : Page
    {
        ObservableCollection<String> userContacts = new ObservableCollection<String>();
        public ObservableCollection<String> UserContacts { get { return userContacts; } }

        ObservableCollection<String> coursess = new ObservableCollection<String>();
        public ObservableCollection<String> Coursess { get { return coursess; } }

        public ScheduleStudentPage()
        {
            this.InitializeComponent();
            List<Student> Students = new List<Student>();
            Userss.ItemsSource = UserContacts;
            Students.Add(new Student("aris", "magic", "aris@upatras.gr", 6930, "", DateTime.Now, "Aris", "Androutsopoulos", 0, "", "", "", 0, "", "Active", "", DateTime.Now, "", ""));
            Students.Add(new Student("klelia", "magic", "klelia@upatras.gr", 6930, "", DateTime.Now, "klelia", "Likothanasi", 0, "", "", "", 0, "", "Active", "", DateTime.Now, "", ""));
            Students.Add(new Student("panagiots", "magic", "panagiotis@upatras.gr", 6930, "", DateTime.Now, "Panagiotis", "Kavvadias", 0, "", "", "", 0, "", "Active", "", DateTime.Now, "", ""));

      
            foreach (Student a in Students)
            {
                userContacts.Add(a.Username);
            }

            Scheduleheader.Text = "Your schedule for Friday, 11 June 2021";

            List<Course> Courses = new List<Course>() ;
            List<Schedule> schedules = new List<Schedule>();

            EventCombo.ItemsSource = Coursess;
            var date1 = new DateTime(2021, 3, 1);
            var date2 = new DateTime(2021, 3, 1);
            var date3 = new DateTime(2021, 3, 2);
            var date4 = new DateTime(2021, 3, 3);
    
            Courses.Add(new Course("", "", "", "", "", "Scientific Computing", date1, date3, "", "", schedules, "", ""));
            Courses.Add(new Course("", "", "", "", "", "Thesis Meeting", date2, date4, "", "", schedules, "", ""));


            foreach (Course a in Courses)
            {
                coursess.Add(a.Title);
            }
            DateToday.Text = DateTime.Now.ToString();

        }

        private void Box_CheckedChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if ((Yes1.IsChecked == true) & (No1.IsChecked == false))
            {
                
                EventCombo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                HourCombo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Appointment.Visibility = Windows.UI.Xaml.Visibility.Visible;
                AppointLine.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Yes2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                No2.Visibility = Windows.UI.Xaml.Visibility.Visible;

            }
            else if ((No1.IsChecked == true) & (Yes1.IsChecked == false))
            {
                EventCombo.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }
        private void Event_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            HourCombo.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }

        private void NewHour_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            Appointment.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AppointLine.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Yes2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            No2.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }
        private void Box2_CheckedChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if ((Yes2.IsChecked == true) & (No2.IsChecked == false))
            {
                ReasonTimePeriod.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Userss.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            else if ((No2.IsChecked == true) & (Yes2.IsChecked == false))
            {

                ReasonTimePeriod.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                CommonHours.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SelectHour1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Userss.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
        }


        private void Contanct_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            CommonHours.Text = "You have 3 common hours with " + Userss.SelectedValue.ToString() + "!";
            CommonHours.Visibility = Windows.UI.Xaml.Visibility.Visible;
            SelectHour1.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }

        private void NewPeriod_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectHour1.SelectedValue.ToString() == "Other")
            {
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MessageMeeting.Header = "Message " + Userss.SelectedValue.ToString() + " about your meeting!";
                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Visible;

            }
            else
            {
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MessageMeeting.Header = "Message " + Userss.SelectedValue.ToString() + " about your meeting!";

                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Visible;

            }

        }
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialog submitt = new ContentDialog()
            {
                Title = "Submit condition",
                Content = "Your request of a meeting with Kavvadias has been submitted. He will be informed in a minute!",
                CloseButtonText = "Ok"
            };
            submitt.ShowAsync();
        }
    }
}
