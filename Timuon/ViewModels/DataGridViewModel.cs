﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.ComponentModel;

using Timuon.Core.Models;
using Timuon.Core.Services;

namespace Timuon.ViewModels
{
    public class DataGridViewModel : ObservableObject
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
