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

    public sealed partial class OrganizationSchedulePage : Page
    {
        public OrganizationScheduleViewModel ViewModel { get; } = new OrganizationScheduleViewModel();


        ObservableCollection<String> availAudit = new ObservableCollection<String>();

        public ObservableCollection<String> AvailAudit { get { return availAudit; } }
        
        public OrganizationSchedulePage()
        {
                this.InitializeComponent();
                DateToday.Text = DateTime.Now.ToString();

                List<Auditorium> Auditoriums = new List<Auditorium>();
                Audit.ItemsSource = AvailAudit;
                Auditoriums.Add(new Auditorium("CEID BA", "", "", 150, true, true));
                Auditoriums.Add(new Auditorium("AFE", "", "", 150, false, false));
                Auditoriums.Add(new Auditorium("Event and Cultural Centre", "", "", 150, false, true));

                foreach (Auditorium a in Auditoriums)
                {
                    availAudit.Add(a.Name);

                }
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

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
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
