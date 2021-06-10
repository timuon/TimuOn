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
            if (email.Text.Equals("student@upatras.gr") && password.Text.Equals("student"))
            {
                NavigationService.Navigate<Views.ShellPageStudent>();
                NavigationService.Navigate<Views.MainPage>();
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
