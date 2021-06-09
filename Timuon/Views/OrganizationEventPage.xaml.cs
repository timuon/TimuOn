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
            InitializeComponent();
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


            }
        }
    }
}
