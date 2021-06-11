using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Timuon.Models;
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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    public sealed partial class History_Log : Page
    {
        ObservableCollection<Organization> user_org = new ObservableCollection<Organization>();
        public ObservableCollection<Organization> User_org { get { return user_org; } }

        ObservableCollection<Course> user_course = new ObservableCollection<Course>();
        public ObservableCollection<Course> User_course { get { return user_course; } }

        ObservableCollection<Teams> team_course = new ObservableCollection<Teams>();
        public ObservableCollection<Teams> Team_course { get { return team_course; } }

        List<Schedule> list_schedule = new List<Schedule>();
        List<string> user_list = new List<string>();

        DateTime date1 = new DateTime(2016, 12, 25);
        DateTime date2 = new DateTime(2017, 4, 25);
        DateTime date3 = new DateTime(2018, 7, 25);

        public History_Log()
        {

            this.InitializeComponent();
            user_list.Add("Klelia");
            user_list.Add("Labros");
            user_list.Add("Aristeidis");
            org_list.ItemsSource = User_org;
            user_org.Add(new Organization("3rd Highschool", "", "", 0, "", DateTime.Now, "", "", 0, "", "", "", "", "", "", true, ""));
            user_org.Add(new Organization("Incibio", "", "", 0, "", DateTime.Now, "", "", 0, "", "", "", "", "", "", true, ""));
            user_org.Add(new Organization("1st Elementary School", "", "", 0, "", DateTime.Now, "", "", 0, "", "", "", "", "", "", true, ""));
            course_list.ItemsSource = User_course;
            user_course.Add(new Course("", "", "", "", "", "Mathematics 2", date1, date1, "", "",list_schedule, "", "Pass"));
            user_course.Add(new Course("", "", "", "", "", "Linear Algebra", date2, date2, "", "", list_schedule, "", "Failed"));
            user_course.Add(new Course("", "", "", "", "", "Pattern Recognition", date3, date3, "", "", list_schedule, "", "Pass"));
            teams_list.ItemsSource = Team_course;
            team_course.Add(new Teams(user_list, 3, "Pattern Recognition", "Team Flake"));
            team_course.Add(new Teams(user_list, 3, "The Greatest Evil, Desolation of Doom", "Shh, don't talk about it"));
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }



        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add "using Windows.UI;" for Color and Colors.
            string colorName = e.AddedItems[0].ToString();
            //string color;
            //switch (colorName)
            //{
            //    case "Yellow":
            //        color = "Yellow";
            //        break;
            //    case "Green":
            //        color = "Green";
            //        break;
            //    case "Blue":
            //        color = "Blue";
            //        break;
            //    case "Red":
            //        color = "Red";
            //        break;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayDriveConnect();
            Drive_Title.Text = "Connected to Drive";
            Drive_sub.Text = "Everything looks good";   
        }
        private async void DisplayDriveConnect()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "Your Connection was successful",
                Content = "You have connected your Drive and you will now receive Log Info",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }

        private async void DisplayDriveConnect2()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "Are you sure you want to Save",
                Content = "Save your Preferences?",
                PrimaryButtonText = "Save",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                // Delete the file.
            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }
        }

        //private void ToggleSwitch_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    if (Org.IsOn == true)
        //    {
        //        org_list.IsEnabled = true;
        //    }
        //    else
        //    {
        //        org_list.IsEnabled = false;
        //    }
        //}

        private void Org_Toggled(object sender, RoutedEventArgs e)
        {
            if (Org.IsOn == true)
            {
                org_list.IsEnabled = true;
            }
            else
            {
                org_list.IsEnabled = false;
            }
        }

        private async void displayteam(Teams team)
        {
            ContentDialog displayteam = new ContentDialog
            {
                Title = team.Team_name,
                Content = "Team made for the " + team.Name + " project. The team had " + team.num_of + " members: \n" + team.get_Team_Info(team.Students_teams),
                CloseButtonText = "Ok",
            };

            ContentDialogResult result = await displayteam.ShowAsync();
        }

        private void course_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Teams team = (Teams)teams_list.SelectedItem;
            displayteam(team);
        }

        private void subs_Toggled(object sender, RoutedEventArgs e)
        {
            if (courses.IsOn == true)
            {
                course_list.IsEnabled = true;
            }
            else
            {
                course_list.IsEnabled = false;
            }
        }

        private void teams_Toggled(object sender, RoutedEventArgs e)
        {
            if (teams.IsOn == true)
            {
                teams_list.IsEnabled = true;
            }
            else
            {
                teams_list.IsEnabled = false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayDriveConnect2();
        }
    }
}
