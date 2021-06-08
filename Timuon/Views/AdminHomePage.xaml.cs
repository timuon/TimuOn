using System;

using Timuon.Models;

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

        private void AllDayCheckBox_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // TODO: make time pickers invisible
            StartTimePicker.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            EndTimePicker.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void AllDayCheckBox_Unchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // TODO: make time pickers visible
            StartTimePicker.Visibility = Windows.UI.Xaml.Visibility.Visible;
            EndTimePicker.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
        private async void Button_ClickAsync(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string eventName = NameBox.Text;
            string eventDescription = DescriptionBox.Text;
            DateTime eventDate = new DateTime();
            double eventDuration;

            if ((bool)AllDayCheckBox.IsChecked)
            {
                // All-day event
                eventDate = EventDatePicker.Date.DateTime;
                eventDuration = 24.0;
            }
            else
            {
                // Specified start time
                eventDate = EventDatePicker.Date.DateTime + StartTimePicker.Time;
                DateTime endDateTime = EventDatePicker.Date.DateTime + EndTimePicker.Time;
                TimeSpan interval = endDateTime - eventDate;
                eventDuration = interval.TotalHours;
            }

            Event newEvent = new Event(eventName, eventDate, "", eventDuration, "", "", "");
            //string test = newEvent.Name;
            // TODO: handle description
            /*
             * Schedule userSchedule = currentUser.Schedule;
             * bool conflict = userSchedule.checkConflict(newEvent);
             */

            //bool conflict = false;
            bool conflict = true;
            ContentDialogResult result;
            if (conflict)
            {
                // Option to proceed with the new event addition or cancel it
                ContentDialog overlappingEventsDialog = new ContentDialog
                {
                    Title = "Overlapping Events",
                    Content = "IMPORTANT INFO: Conflict checking method is too complex " +
                    "for the scope of this project. The result displayed below is randomly determined " +
                    "(conflict and no-conflict probabilities set to 50%). \n\n" +
                    "It appears that there is an overlapping event:" +
                    "[Event Details]. Do you still want to proceed with the addition of the new event?",
                    PrimaryButtonText = "Yes",
                    CloseButtonText = "Cancel"
                };

                result = await overlappingEventsDialog.ShowAsync();
                if (result == ContentDialogResult.Primary)
                {
                    // Event addition and confirmation
                    // TODO: add event as above
                    ContentDialog successDialog = new ContentDialog
                    {
                        Title = "Success!",
                        Content = "Event added successfully!",
                        CloseButtonText = "OK"
                    };

                    result = await successDialog.ShowAsync();
                    // TODO update today's events list if applicable
                }
            }
            else
            {
                // Event addition and confirmation
                ContentDialog overlappingEventsDialog = new ContentDialog
                {
                    Title = "Success!",
                    Content = "IMPORTANT INFO: Conflict checking method is too complex for the scope of this project. " +
                    "The result displayed below is randomly determined " +
                    "(conflict and no-conflict probabilities set to 50%). \n\n" +
                    "No conflicts detected. Event added successfully!",
                    CloseButtonText = "OK"
                };

                result = await overlappingEventsDialog.ShowAsync();
                // TODO update today's events list if applicable
                
            }

            // Clear form
            NameBox.Text = "";
            DescriptionBox.Text = "";
            EventDatePicker.Date = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks);
            AllDayCheckBox.IsChecked = false;
            StartTimePicker.Time = timeSpan;
            EndTimePicker.Time = timeSpan;
            RecipientsCombo.SelectedIndex = -1;

        }

    }
}
