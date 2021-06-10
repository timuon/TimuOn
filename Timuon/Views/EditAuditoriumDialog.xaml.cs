using System;

using System.Collections.ObjectModel;

using Timuon.Models;

using Timuon.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Timuon.Views
{
    public enum CustomDialogResult
    {
        Apply,
        Cancel
    }
    public sealed partial class EditAuditoriumDialog : ContentDialog
    {
        //public EditAuditoriumDialogViewModel ViewModel { get; } = new EditAuditoriumDialogViewModel();
        public CustomDialogResult DialogResult { get; set; }
        public ObservableCollection<Auditorium> Auditoriums;
        public int Index;

        public EditAuditoriumDialog(ObservableCollection<Auditorium> auditoriums, int index)
        {
            Auditoriums = auditoriums;
            Index = index;
            InitializeComponent();
        }
    }
}
