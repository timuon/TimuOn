using System;

using System.Collections.ObjectModel;

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
        public Auditorium NewAuditorium = null;

        public AdminSysConstrPage()
        {
            InitializeComponent();
            //string[] EmptyStrArr = new string[] { };
            //Event[] EmptyEventArr = new Event[] { };
            deptAuditoriums.Add(new Auditorium("BA", "CEID", "UPatras", 250, true, false));
            deptAuditoriums.Add(new Auditorium("B3", "CEID", "UPatras", 40, true, true));
            AuditoriumsList.ItemsSource = DeptAuditoriums;
            AuditoriumCombo.ItemsSource = DeptAuditoriums;
        }

        private async void test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int ind = deptAuditoriums.IndexOf((Auditorium)AuditoriumsList.SelectedItem);
            ContentDialogResult result;
            ContentDialog TestDialog = new ContentDialog
            {
                Title = "Status Check",
                Content = deptAuditoriums[ind].DisplayString,
                CloseButtonText = "OK"
            };
            result = await TestDialog.ShowAsync();
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

        private async void ApplyButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            int ind = DeptAuditoriums.IndexOf((Auditorium)AuditoriumCombo.SelectedItem);
            DeptAuditoriums[ind].Capacity = (int)EditCapacityBox.Value;
            DeptAuditoriums[ind].Accessibility = (bool)EditAccessibilityBox.IsChecked;
            DeptAuditoriums[ind].Availability = (bool)EditAvailabilityBox.IsChecked;
            DeptAuditoriums[ind].UpdateDisplayString();

            ContentDialogResult result;
            ContentDialog TestDialog = new ContentDialog
            {
                Title = "Status Check",
                Content = DeptAuditoriums[ind].DisplayString + " " + AuditoriumsList.Items.IndexOf(DeptAuditoriums[ind]).ToString(),
                CloseButtonText = "OK"
            };
            result = await TestDialog.ShowAsync();
        }

        private void EditCancelButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            EditCapacityBox.Value = 0;
            EditAccessibilityBox.IsChecked = false;
            EditAvailabilityBox.IsChecked = false;
            AuditoriumCombo.SelectedIndex = -1;
        }
    }
}
