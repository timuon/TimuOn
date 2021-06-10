﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScheduleStudentPage : Page
    {
        public ScheduleStudentPage()
        {
            this.InitializeComponent();
        }
        private void Box_CheckedChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if ((Yes1.IsChecked == true) & (No1.IsChecked == false))
            {
                EventCombo.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else if ((No1.IsChecked == true) & (Yes1.IsChecked == false))
            {
                EventCombo.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
        }
        private void Event_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            HourCombo.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }

        private void NewHour_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            Appointment.Visibility = Windows.UI.Xaml.Visibility.Visible;
            AppointLine.Visibility = Windows.UI.Xaml.Visibility.Visible;
            Yes2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            No2.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }
        private void Box2_CheckedChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if ((Yes2.IsChecked == true) & (No2.IsChecked == false))
            {
                ReasonTimePeriod.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Userss.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            else if ((No2.IsChecked == true) & (Yes2.IsChecked == false))
            {
                
                ReasonTimePeriod.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                CommonHours.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SelectHour1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                Userss.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
        }

        private void Contanct_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            CommonHours.Visibility = Windows.UI.Xaml.Visibility.Visible;
            SelectHour1.Visibility = Windows.UI.Xaml.Visibility.Visible;

        }

        private void NewPeriod_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectHour1.SelectedValue.ToString() == "Other")
            {
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Visible;

            }
            else
            {
                SelectHour2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                SubmitButton.Visibility = Windows.UI.Xaml.Visibility.Visible;
                MessageMeeting.Visibility = Windows.UI.Xaml.Visibility.Visible;



            }
        }
    }
}