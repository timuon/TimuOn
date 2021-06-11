using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Timuon.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Timuon.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (email.Text.Equals("student@upatras.gr") && password.Password.Equals("student"))
            {
                NavigationService.Navigate<Views.ShellPageStudent>();
                NavigationService.Navigate<Views.StudentHomePage>();
            }
            else if (email.Text.Equals("upatras@upatras.gr") && password.Password.Equals("upatras"))
            {
                NavigationService.Navigate<Views.ShellPageOrganization>();
                NavigationService.Navigate<Views.OrganizationHomePage>();
            }
            else if (email.Text.Equals("professor@upatras.gr") && password.Password.Equals("professor"))
            {
                NavigationService.Navigate<Views.ShellPageCoordinator>();
                NavigationService.Navigate<Views.CoordinatorHome>();
            }
            else if (email.Text.Equals("secretary@upatras.gr") && password.Password.Equals("secretary"))
            {
                NavigationService.Navigate<Views.AdminShellPage>();
                NavigationService.Navigate<Views.AdminHomePage>();
            }
            else
            {
                ContentDialog wrongPass = new ContentDialog()
                {
                    Title = "Wrong credetials",
                    Content = "Wrong email or password. Please try again.",
                    CloseButtonText = "Ok"
                };
                ContentDialogResult result = await wrongPass.ShowAsync();
            }
        }
    }
}
