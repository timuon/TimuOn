#pragma checksum "C:\Users\kolop\Downloads\TimuOn\Timuon\Views\ChartPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B8D9F3CB579D6AE3F3CC0BBFD76B860F4AEFCC7FE301B7BE58EFFECEB88F1718"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Timuon.Views
{
    partial class ChartPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Telerik_UI_Xaml_Controls_Chart_ChartSeries_ItemsSource(global::Telerik.UI.Xaml.Controls.Chart.ChartSeries obj, global::System.Collections.IEnumerable value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.IEnumerable) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.IEnumerable), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ChartPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IChartPage_Bindings
        {
            private global::Timuon.Views.ChartPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Telerik.UI.Xaml.Controls.Chart.BarSeries obj3;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3ItemsSourceDisabled = false;

            private ChartPage_obj1_BindingsTracking bindingsTracking;

            public ChartPage_obj1_Bindings()
            {
                this.bindingsTracking = new ChartPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 21 && columnNumber == 31)
                {
                    isobj3ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\ChartPage.xaml line 21
                        this.obj3 = (global::Telerik.UI.Xaml.Controls.Chart.BarSeries)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IChartPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Timuon.Views.ChartPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Timuon.Views.ChartPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Timuon.ViewModels.ChartViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Source(obj.Source, phase);
                    }
                }
            }
            private void Update_ViewModel_Source(global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Source(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ChartPage.xaml line 21
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Telerik_UI_Xaml_Controls_Chart_ChartSeries_ItemsSource(this.obj3, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ChartPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ChartPage_obj1_Bindings> weakRefToBindingObj; 

                public ChartPage_obj1_BindingsTracking(ChartPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ChartPage_obj1_Bindings>(obj);
                }

                public ChartPage_obj1_Bindings TryGetBindingObject()
                {
                    ChartPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Source(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ChartPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Timuon.ViewModels.ChartViewModel obj = sender as global::Timuon.ViewModels.ChartViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Source":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Source(obj.Source, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Timuon.ViewModels.ChartViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Timuon.ViewModels.ChartViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Source(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ChartPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Source(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    ChartPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint> cache_ViewModel_Source = null;
                public void UpdateChildListeners_ViewModel_Source(global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Core.Models.DataPoint> obj)
                {
                    if (obj != cache_ViewModel_Source)
                    {
                        if (cache_ViewModel_Source != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Source).PropertyChanged -= PropertyChanged_ViewModel_Source;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_Source).CollectionChanged -= CollectionChanged_ViewModel_Source;
                            cache_ViewModel_Source = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Source = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Source;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_Source;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\ChartPage.xaml line 11
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\ChartPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ChartPage_obj1_Bindings bindings = new ChartPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

