using System;

using System.Collections.ObjectModel;

using Timuon.Models;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public sealed partial class AdminHomePage : Page
    {
        public AdminHomeViewModel ViewModel { get; } = new AdminHomeViewModel();
        ObservableCollection<Event> eventsToday = new ObservableCollection<Event>();
        public ObservableCollection<Event> EventsToday { get { return eventsToday; } }
        //private Event NewEvent;

        public AdminHomePage()
        {
            InitializeComponent();
            EventsList.ItemsSource = EventsToday;
        }

        private void AllDayCheckBox_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            StartTimePicker.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            EndTimePicker.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void AllDayCheckBox_Unchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            StartTimePicker.Visibility = Windows.UI.Xaml.Visibility.Visible;
            EndTimePicker.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
        private async void Button_ClickAsync(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string EventName = NameBox.Text;
            string EventDescription = DescriptionBox.Text;
            DateTime EventDate;
            TimeSpan EventDuration;

            if ((bool)AllDayCheckBox.IsChecked)
            {
                // All-day event
                EventDate = EventDatePicker.Date.DateTime;
                EventDuration = new TimeSpan(24, 0, 0);
            }
            else
            {
                // Specified start time
                EventDate = EventDatePicker.Date.DateTime + StartTimePicker.Time; 
                DateTime EndDateTime = EventDatePicker.Date.DateTime + EndTimePicker.Time;
                EventDuration = EndDateTime - EventDate;
            }

            EventDate = DateTime.SpecifyKind(EventDate, DateTimeKind.Local);
            Event NewEvent = new Event(EventName, EventDate, "", EventDuration, "", "", "", EventDescription);
            /*
             * Schedule userSchedule = currentUser.Schedule;
             * bool conflict = userSchedule.checkConflict(newEvent);
             */

            //bool Conflict = false;
            bool Conflict = true;
            ContentDialogResult result;
            if (Conflict)
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
                    // TODO: pass event to user
                    ContentDialog successDialog = new ContentDialog
                    {
                        Title = "Success!",
                        Content = "Event added successfully!",
                        CloseButtonText = "OK"
                    };

                    result = await successDialog.ShowAsync();

                    // TODO fix difference!!!
                    if (DateTime.Compare(NewEvent.Date, DateTime.Now) >= 0)
                    {
                        EventsToday.Add(NewEvent);
                    }
                }
            }
            else
            {
                // Event addition and confirmation
                // TODO: pass event to user
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
                if (DateTime.Compare(NewEvent.Date, DateTime.Now) == 0)
                {
                    EventsToday.Add(NewEvent);
                }

            }

            // Clear form
            NameBox.Text = "";
            DescriptionBox.Text = "";
            EventDatePicker.SelectedDate = null;
            AllDayCheckBox.IsChecked = false;
            StartTimePicker.SelectedTime = null;
            EndTimePicker.SelectedTime = null;
            RecipientsCombo.SelectedIndex = -1;

        }
    }
}
