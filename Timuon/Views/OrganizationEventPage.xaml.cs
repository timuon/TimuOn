using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Timuon.Models;
using Timuon.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrganizationEventPage : Page
    {
        public OrganizationEventsViewModel ViewModel { get; } = new OrganizationEventsViewModel();
        public OrganizationEventPage()
        {
            this.InitializeComponent();
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
    }
}
