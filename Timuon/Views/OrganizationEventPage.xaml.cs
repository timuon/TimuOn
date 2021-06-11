using System;

using Timuon.ViewModels;
using System.Collections.ObjectModel;

using Timuon.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;
using System.Collections.Generic;

namespace Timuon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrganizationEventPage : Page
    {
        public OrganizationEventsViewModel ViewModel { get; } = new OrganizationEventsViewModel();
        ObservableCollection<String> availEvents = new ObservableCollection<String>();

        public ObservableCollection<String> AvailEvents { get { return availEvents; } }

        ObservableCollection<String> availAudit = new ObservableCollection<String>();

        public ObservableCollection<String> AvailAudit{ get { return availAudit; } }
        public OrganizationEventPage()
        {
            this.InitializeComponent();

            DateToday.Text = DateTime.Now.ToString();

            List<Event> Events = new List<Event>();
            EventsCombobox.ItemsSource = AvailEvents;
            TimeSpan interval = new TimeSpan(2, 14, 18);
            Events.Add(new Event("Patras IQ", DateTime.Now, "AFE", interval, "", "", "", ""));
            Events.Add(new Event("Students Elections", DateTime.Now, "CEID BA", interval, "", "", "", ""));
            Events.Add(new Event("Blood Donation", DateTime.Now, "CEID B4", interval, "", "", "", ""));

            foreach (Event a in Events)
            {
                availEvents.Add(a.Name);
            }

            List<Auditorium> Auditoriums = new List<Auditorium>();
            AuditoriumsEdit.ItemsSource = AvailAudit;
            Auditoriums.Add(new Auditorium("CEID BA","","",150, true,true));
            Auditoriums.Add(new Auditorium("CEID BA", "", "", 150, false, false));
            Auditoriums.Add(new Auditorium("CEID BA", "", "", 150, false, true));

            foreach (Auditorium a in Auditoriums)
            {
                availAudit.Add(a.Name);

            }

        }
        private void EventAction_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EventAction.SelectedValue.ToString() == "Add Event")
            {
                // Add event elements
                AddEventBox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                AddEventDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
                CalendarEvent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                AuditoriumAddEvent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                NumberLongAddEvent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                AuditoriumCombobox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MessageSec.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Linee.Visibility = Windows.UI.Xaml.Visibility.Visible;

                // Edit event elements
                ChangeTitle.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ChangesCombobox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ReasonEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumEditTitle.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CalendarPickerEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumsEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                EventsCombobox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                EditEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                // Delete event elements
                DeleteEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ChangeDelete.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            else if (EventAction.SelectedValue.ToString() == "Edit Event")
            {
                // Add event elements
                AddEventBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddEventDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CalendarEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumAddEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                NumberLongAddEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumCombobox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                MessageSec.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumsEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


                // Edit event elements
                ChangeTitle.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ChangesCombobox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ReasonEdit.Visibility = Windows.UI.Xaml.Visibility.Visible;
                AuditoriumsEdit.Visibility = Windows.UI.Xaml.Visibility.Visible;
                AuditoriumEditTitle.Visibility = Windows.UI.Xaml.Visibility.Visible;
                CalendarPickerEdit.Visibility = Windows.UI.Xaml.Visibility.Visible;
                EventsCombobox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                EditEvent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Linee.Visibility = Windows.UI.Xaml.Visibility.Visible;

                // Delete event elements
                DeleteEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ChangeDelete.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            else
            {
                // Add event elements
                AddEventBox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AddEventDate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CalendarEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumAddEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                NumberLongAddEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumCombobox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                MessageSec.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumsEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Linee.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                // Edit event elements
                ChangeTitle.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ChangesCombobox.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                ReasonEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumEditTitle.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                CalendarPickerEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                AuditoriumsEdit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                EventsCombobox.Visibility = Windows.UI.Xaml.Visibility.Visible;
                EditEvent.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

                // Delete event elements
                DeleteEvent.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ChangeDelete.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }


            
    }

        private void SubmitClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ContentDialog submitt = new ContentDialog()
            {
                Title = "Submit notification!",
                Content = "The departments are being informed of your change as we speak! You may continue to an other action.",
                CloseButtonText = "Close dialog"
            };
            submitt.ShowAsync();
        }
    }
}
