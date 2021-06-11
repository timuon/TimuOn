using System;

using System.Collections.Generic;

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
        public Admin CurrentUser;

        public AdminHomePage()
        {
            InitializeComponent();

            // Dummy data
            string[] EmptyStrArr = new string[] { };
            List<Event> DeptEvents = new List<Event>();
            DeptEvents.Add(new Event("Head of Division Elections", DateTime.Today, "BA", new TimeSpan(24, 0, 0),
                "", "", "", "Let the Hunger Games begin!"));
            DeptEvents.Add(new Event("Faculty Meeting", new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 10, 0, 0, 0),
                "Online", new TimeSpan(2, 0, 0), "", "", "", "Bring your own popcorn... ;)"));
            List<Auditorium> Auditoriums = new List<Auditorium>();
            Auditoriums.Add(new Auditorium("BA", "CEID", "UPatras", 250, true, false));
            Auditoriums.Add(new Auditorium("B3", "CEID", "UPatras", 40, true, true));
            List<Request> Requests = new List<Request>();
            Requests.Add(new Request("Introduction to Signals and Systems", 200, "Conflict with Numerical Analysis", "Tuesday 11:00-13:00"));
            Requests.Add(new Request("Software Engineering", 400, "Four hours straight is inhumane.", "Tuesday 17:00-19:00, Thursday 17:00-19:00"));
            CurrentUser = new Admin("Secretary", "secretary", "secretary@upatras.gr", 996981, "Rion",
                DateTime.Now, "Secretary", "CEID", 2, "Ceid Calendar", "", "", "University of Patras",
                "ComputerEngineering and Informatics", Auditoriums, EmptyStrArr, EmptyStrArr, DeptEvents, Requests, "");
            DeptEvents = CurrentUser.getEventsToday();
            foreach (Event e in DeptEvents)
            {
                eventsToday.Add(e);
            }

            EventsList.ItemsSource = EventsToday;
            DateBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
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
                EventDate = EventDatePicker.Date.DateTime.Date + StartTimePicker.Time; 
                DateTime EndDateTime = EventDatePicker.Date.DateTime.Date + EndTimePicker.Time;
                EventDuration = EndDateTime - EventDate;
            }

            EventDate = DateTime.SpecifyKind(EventDate, DateTimeKind.Local);
            Event NewEvent = new Event(EventName, EventDate, "", EventDuration, "", "", "", EventDescription);

            // Randomly determine if there is a conflict
            var Rand = new Random();
            bool Conflict = Rand.NextDouble() < 0.5 ? true : false;
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
                    // Pass event to user
                    CurrentUser.DepartmentCalendar.Add(NewEvent);

                    // Info dialogue box
                    ContentDialog successDialog = new ContentDialog
                    {
                        Title = "Success!",
                        Content = "Event added successfully!",
                        CloseButtonText = "OK"
                    };
                    result = await successDialog.ShowAsync();

                    // Add to today's events list
                    if (DateTime.Compare(NewEvent.Date.Date, DateTime.Today) == 0)
                    {
                        EventsToday.Add(NewEvent);
                    }
                }
            }
            else
            {
                // Event addition and confirmation
                // Pass event to user
                CurrentUser.DepartmentCalendar.Add(NewEvent);

                // Info dialogue box
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

                // Add to today's events list
                if (DateTime.Compare(NewEvent.Date.Date, DateTime.Today) == 0)
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
