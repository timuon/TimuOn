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
using System.Collections.ObjectModel;
using Timuon.Models;



// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    public sealed partial class Subscriptions : Page
    {

        ObservableCollection<Channel> user_channel = new ObservableCollection<Channel>();
        public ObservableCollection<Channel> User_channel { get { return user_channel; } }

        ObservableCollection<Channel> user_subs = new ObservableCollection<Channel>();
        public ObservableCollection<Channel> User_subs { get { return user_subs; } }

        ObservableCollection<Channel> user_search = new ObservableCollection<Channel>();
        public ObservableCollection<Channel> User_search { get { return user_search; } }

        IList<Channel> People = new List<Channel>();

        // Create PeopleFiltered collection and copy data from original People collection
        ObservableCollection<Channel> PeopleFiltered = new ObservableCollection<Channel>();

        // Set the ListView's ItemsSource property to the PeopleFiltered collection
        

        

        List<Schedule> list_schedule = new List<Schedule>();
        List<string> user_list = new List<string>();

        DateTime date1 = new DateTime(2016, 12, 25);
        DateTime date2 = new DateTime(2017, 4, 25);
        DateTime date3 = new DateTime(2018, 7, 25);

        public Subscriptions()
        {
            this.InitializeComponent();
            channel_list.ItemsSource = user_channel;
            user_channel.Add(new Channel("Up FM"));

            subs_list.ItemsSource = User_subs;
            user_subs.Add(new Channel("Ceid"));
            user_subs.Add(new Channel("TimuOn"));
            user_subs.Add(new Channel("LMS"));

            search_list.ItemsSource = User_search;
            search_list.ItemsSource = PeopleFiltered;
            People.Add(new Channel("Up FM"));
            People.Add(new Channel("Ceid"));
            People.Add(new Channel("Robotics Club"));
            People.Add(new Channel("LMS"));


        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void FilteredLV_LNameChanged(object sender, TextChangedEventArgs e)
        {
            /* Perform a Linq query to find all Person objects (from the original People collection)
            that fit the criteria of the filter, save them in a new List called TempFiltered. */
            List<Channel> TempFiltered;

            /* Make sure all text is case-insensitive when comparing, and make sure 
            the filtered items are in a List object */
            TempFiltered = People.Where(contact => contact.Name.Contains(FilterByLName.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();

            /* Go through TempFiltered and compare it with the current PeopleFiltered collection,
            adding and subtracting items as necessary: */

            // First, remove any Person objects in PeopleFiltered that are not in TempFiltered
            for (int i = PeopleFiltered.Count - 1; i >= 0; i--)
            {
                var item = PeopleFiltered[i];
                if (!TempFiltered.Contains(item))
                {
                    PeopleFiltered.Remove(item);
                }
            }

            /* Next, add back any Person objects that are included in TempFiltered and may 
            not currently be in PeopleFiltered (in case of a backspace) */

            foreach (var item in TempFiltered)
            {
                if (!PeopleFiltered.Contains(item))
                {
                    PeopleFiltered.Add(item);
                }
            }
        }

        private async void displayteam(Channel channel)
        {
            ContentDialog displayteam = new ContentDialog
            {
                Title = channel.Name,
                Content = "Channel " + channel.Name + ". Part of Organization TimuOn \n"+"Our organization Delivers excitement across the board, bringing you the best of content and articles.",
                CloseButtonText = "Ok",
            };

            ContentDialogResult result = await displayteam.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            displayteam(user_subs[2]);
        }
    }
}
