﻿#pragma checksum "C:\Users\klelia\Source\Repos\timuon\TimuOn\Timuon\Views\MapPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12AA1C95D4AC5860C0F7B0EBB637A7F08C45CD351EA23D3C197076F0F72CD3F6"
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
    partial class MapPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Maps_MapControl_Center(global::Windows.UI.Xaml.Controls.Maps.MapControl obj, global::Windows.Devices.Geolocation.Geopoint value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.Devices.Geolocation.Geopoint) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.Devices.Geolocation.Geopoint), targetNullValue);
                }
                obj.Center = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Maps_MapControl_ZoomLevel(global::Windows.UI.Xaml.Controls.Maps.MapControl obj, global::System.Double value)
            {
                obj.ZoomLevel = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MapPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMapPage_Bindings
        {
            private global::Timuon.Views.MapPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Maps.MapControl obj2;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CenterDisabled = false;
            private static bool isobj2ZoomLevelDisabled = false;

            private MapPage_obj1_BindingsTracking bindingsTracking;

            public MapPage_obj1_Bindings()
            {
                this.bindingsTracking = new MapPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 13)
                {
                    isobj2CenterDisabled = true;
                }
                else if (lineNumber == 17 && columnNumber == 13)
                {
                    isobj2ZoomLevelDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\MapPage.xaml line 14
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)target;
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

            // IMapPage_Bindings

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
                    this.dataRoot = (global::Timuon.Views.MapPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Timuon.Views.MapPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Timuon.ViewModels.MapViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Center(obj.Center, phase);
                        this.Update_ViewModel_ZoomLevel(obj.ZoomLevel, phase);
                    }
                }
            }
            private void Update_ViewModel_Center(global::Windows.Devices.Geolocation.Geopoint obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MapPage.xaml line 14
                    if (!isobj2CenterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Maps_MapControl_Center(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_ZoomLevel(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MapPage.xaml line 14
                    if (!isobj2ZoomLevelDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Maps_MapControl_ZoomLevel(this.obj2, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MapPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MapPage_obj1_Bindings> weakRefToBindingObj; 

                public MapPage_obj1_BindingsTracking(MapPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MapPage_obj1_Bindings>(obj);
                }

                public MapPage_obj1_Bindings TryGetBindingObject()
                {
                    MapPage_obj1_Bindings bindingObject = null;
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
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Timuon.ViewModels.MapViewModel obj = sender as global::Timuon.ViewModels.MapViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Center(obj.Center, DATA_CHANGED);
                                bindings.Update_ViewModel_ZoomLevel(obj.ZoomLevel, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Center":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Center(obj.Center, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ZoomLevel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ZoomLevel(obj.ZoomLevel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Timuon.ViewModels.MapViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Timuon.ViewModels.MapViewModel obj)
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
            case 2: // Views\MapPage.xaml line 14
                {
                    this.mapControl = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
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
            case 1: // Views\MapPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MapPage_obj1_Bindings bindings = new MapPage_obj1_Bindings();
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

