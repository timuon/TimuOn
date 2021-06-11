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
using Timuon.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class OrganizationSchedulePage : Page
    {
        public OrganizationScheduleViewModel ViewModel { get; } = new OrganizationScheduleViewModel();

        public OrganizationSchedulePage()
        {
            this.InitializeComponent();
        }
        private void Actionchanged_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ActionsCombobox.SelectedValue.ToString() == "Change the availability of an auditorium")
            {
                ChangeAvail.Visibility = Windows.UI.Xaml.Visibility.Visible;
                Audit.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                ChangeAvail.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Audit.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            WhichDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
            CalendarDate.Visibility = Windows.UI.Xaml.Visibility.Visible;
            ForHowLong.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Reason.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
