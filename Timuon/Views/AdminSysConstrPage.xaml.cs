using System;

using System.Collections.Generic;

using System.Collections.ObjectModel;

using System.Linq;

using Timuon.Models;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class AdminSysConstrPage : Page
    {
        public AdminSysConstrViewModel ViewModel { get; } = new AdminSysConstrViewModel();
        ObservableCollection<Auditorium> deptAuditoriums = new ObservableCollection<Auditorium>();
        public ObservableCollection<Auditorium> DeptAuditoriums { get { return deptAuditoriums; } }
        ObservableCollection<Request> studentRequests = new ObservableCollection<Request>();
        public ObservableCollection<Request> StudentRequests { get { return studentRequests; } }
        public Admin CurrentUser;

        public AdminSysConstrPage()
        {
            InitializeComponent();
            // Dummy data
            string[] EmptyStrArr = new string[] { };
            Event[] DeptEvents = new Event[] { };
            List<Auditorium> Auditoriums = new List<Auditorium>();
            Auditoriums.Add(new Auditorium("BA", "CEID", "UPatras", 250, true, false));
            Auditoriums.Add(new Auditorium("B3", "CEID", "UPatras", 40, true, true));
            List<Request> Requests = new List<Request>();
            Requests.Add(new Request("Introduction to Signals and Systems", 200, "Conflict with Numerical Analysis", "Tuesday 11:00-13:00"));
            Requests.Add(new Request("Software Engineering", 400, "Four hours straight is inhumane.", "Tuesday 17:00-19:00, Thursday 17:00-19:00"));
            CurrentUser = new Admin("Secretary", "secretary", "secretary@upatras.gr", 996981, "Rion",
                DateTime.Now, "Secretary", "CEID", 2, "Ceid Calendar", "", "", "University of Patras",
                "ComputerEngineering and Informatics", Auditoriums, EmptyStrArr, EmptyStrArr, DeptEvents, Requests, "");
            foreach (Auditorium a in Auditoriums)
            {
                deptAuditoriums.Add(a);
            }
            AuditoriumsList.ItemsSource = DeptAuditoriums;
            AuditoriumCombo.ItemsSource = DeptAuditoriums;
            foreach (Request r in Requests)
            {
                studentRequests.Add(r);
            }
            RequestsList.ItemsSource = StudentRequests;
            RequestCombo.ItemsSource = StudentRequests;
        }

        private void AuditoriumCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuditoriumCombo.SelectedIndex != -1)
            {
                int ind = deptAuditoriums.IndexOf((Auditorium)AuditoriumCombo.SelectedItem);
                //ContentDialogResult result;
                //ContentDialog TestDialog = new ContentDialog
                //{
                //    Title = "Status Check",
                //    Content = deptAuditoriums[ind].DisplayString,
                //    CloseButtonText = "OK"
                //};
                //result = await TestDialog.ShowAsync();
                EditCapacityBox.Value = deptAuditoriums[ind].Capacity;
                EditAccessibilityBox.IsChecked = deptAuditoriums[ind].Accessibility;
                EditAvailabilityBox.IsChecked = deptAuditoriums[ind].Availability;
            }
        }

        private void ApplyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (AuditoriumCombo.SelectedIndex != -1)
            {
                Auditorium Temp = (Auditorium)AuditoriumCombo.SelectedItem;

                // Update entry in observable collection
                int ind = DeptAuditoriums.IndexOf(Temp);
                Auditorium ToChange = DeptAuditoriums[ind];
                Temp = new Auditorium(ToChange.Name, "", "", (int)EditCapacityBox.Value,
                    (bool)EditAccessibilityBox.IsChecked, (bool)EditAvailabilityBox.IsChecked);
                DeptAuditoriums.RemoveAt(ind);
                DeptAuditoriums.Insert(ind, Temp);

                // Update entry in user object
                foreach (Auditorium a in CurrentUser.Auditoriums)
                {
                    if (a.Name == Temp.Name)
                    {
                        ind = CurrentUser.Auditoriums.IndexOf(a);
                    }
                }
                CurrentUser.Auditoriums[ind].Capacity = Temp.Capacity;
                CurrentUser.Auditoriums[ind].Accessibility = Temp.Accessibility;
                CurrentUser.Auditoriums[ind].Availability = Temp.Availability;
                CurrentUser.Auditoriums[ind].UpdateDisplayString();

                // Clear form
                EditCapacityBox.Value = 0;
                EditAccessibilityBox.IsChecked = false;
                EditAvailabilityBox.IsChecked = false;
                AuditoriumCombo.SelectedIndex = -1;
            }
        }

        private void EditCancelButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Clear form
            EditCapacityBox.Value = 0;
            EditAccessibilityBox.IsChecked = false;
            EditAvailabilityBox.IsChecked = false;
            AuditoriumCombo.SelectedIndex = -1;
        }

        private void AddButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (AuditoriumCombo.SelectedIndex != -1)
            {
                Auditorium Temp = new Auditorium(NewNameBox.Text, "", "", (int)NewCapacityBox.Value,
                (bool)EditAccessibilityBox.IsChecked, (bool)NewAvailabilityBox.IsChecked);

                // Add to user
                CurrentUser.Auditoriums.Add(Temp);

                // Add to observable collection
                deptAuditoriums.Add(Temp);

                // Clear form
                NewNameBox.Text = "";
                NewCapacityBox.Value = 0;
                NewAccessibilityBox.IsChecked = false;
                NewAvailabilityBox.IsChecked = false;
            }
        }

        private void NewCancelButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Clear form
            NewNameBox.Text = "";
            NewCapacityBox.Value = 0;
            NewAccessibilityBox.IsChecked = false;
            NewAvailabilityBox.IsChecked = false;
        }

        private void RequestCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RequestCombo.SelectedIndex != -1)
            {
                int ind = studentRequests.IndexOf((Request)RequestCombo.SelectedItem);
                DispStrBox.Text = studentRequests[ind].DisplayString;
                ReasonBox.Text = studentRequests[ind].Reason;
                NewSchedBox.Text = studentRequests[ind].NewSchedule;
            }
        }

        private void RequestCancelButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Clear form
            DispStrBox.Text = "";
            ReasonBox.Text = "";
            NewSchedBox.Text = "";
            RequestCombo.SelectedIndex = -1;
        }

        private void DenyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (RequestCombo.SelectedIndex != -1)
            {
                // Mark as denied and remove from list
                Request Temp = (Request)RequestCombo.SelectedItem;
                int ind = studentRequests.IndexOf(Temp);
                foreach (Request r in CurrentUser.RescheduleRequests)
                {
                    if (r.CourseName == studentRequests[ind].CourseName)
                    {
                        studentRequests[ind].Decision = "Denied";
                    }
                }
                studentRequests.RemoveAt(ind);

                // Clear form
                DispStrBox.Text = "";
                ReasonBox.Text = "";
                NewSchedBox.Text = "";
                RequestCombo.SelectedIndex = -1;
            }
        }

        private void AllowButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (RequestCombo.SelectedIndex != -1)
            {
                // Mark as allowed and remove from list
                Request Temp = (Request)RequestCombo.SelectedItem;
                int ind = studentRequests.IndexOf(Temp);
                foreach (Request r in CurrentUser.RescheduleRequests)
                {
                    if (r.CourseName == studentRequests[ind].CourseName)
                    {
                        studentRequests[ind].Decision = "Allowed";
                    }
                }

                // Clear form
                studentRequests.RemoveAt(ind);
                DispStrBox.Text = "";
                ReasonBox.Text = "";
                NewSchedBox.Text = "";
                RequestCombo.SelectedIndex = -1;
            }
        }  
    }
}
