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
        ObservableCollection<Student> userContacts = new ObservableCollection<Student>();
        public ObservableCollection<Student> UserContacts { get { return userContacts; } }

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
                userContacts.Add(a);
            }
            
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
            CommonHours.Visibility = Windows.UI.Xaml.Visibility.Visible;
            SelectHour1.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }

        private void NewPeriod_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectHour1.SelectedValue.ToString() == "Other")
            {
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Visible;

            }
            else
            {
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
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
