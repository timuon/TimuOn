﻿#pragma checksum "C:\Users\klelia\Source\Repos\timuon\TimuOn\Timuon\Views\TabViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10539942E93B6F82F6FB797342FE3F0A114BADB0A9C981DC7C8663ED31BC3CD1"
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
    partial class TabViewPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TabView_TabItemsSource(global::Microsoft.UI.Xaml.Controls.TabView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.TabItemsSource = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TabView_AddTabButtonCommand(global::Microsoft.UI.Xaml.Controls.TabView obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.AddTabButtonCommand = value;
            }
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TabViewItem_Header(global::Microsoft.UI.Xaml.Controls.TabViewItem obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
            public static void Set_Windows_UI_Xaml_Automation_AutomationProperties_Name(global::Windows.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Windows.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TabViewPage_obj7_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITabViewPage_Bindings
        {
            private global::System.String dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8TextDisabled = false;

            public TabViewPage_obj7_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 33 && columnNumber == 44)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // Views\TabViewPage.xaml line 32
                        this.obj7 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 8: // Views\TabViewPage.xaml line 33
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj7.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::System.String) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ITabViewPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::System.String)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TabViewPage.xaml line 33
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TabViewPage_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITabViewPage_Bindings
        {
            private global::Timuon.Models.TabViewItemData dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5HeaderDisabled = false;
            private static bool isobj5NameDisabled = false;
            private static bool isobj5ContentDisabled = false;

            public TabViewPage_obj5_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 27 && columnNumber == 21)
                {
                    isobj5HeaderDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 21)
                {
                    isobj5NameDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 21)
                {
                    isobj5ContentDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Views\TabViewPage.xaml line 26
                        this.obj5 = new global::System.WeakReference((global::Microsoft.UI.Xaml.Controls.TabViewItem)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Timuon.Models.TabViewItemData) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ITabViewPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Timuon.Models.TabViewItemData)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Timuon.Models.TabViewItemData obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Header(obj.Header, phase);
                        this.Update_Content(obj.Content, phase);
                    }
                }
            }
            private void Update_Header(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TabViewPage.xaml line 26
                    if (!isobj5HeaderDisabled)
                    {
                        if ((this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem) != null)
                        {
                            XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TabViewItem_Header((this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem), obj, null);
                        }
                    }
                    // Views\TabViewPage.xaml line 26
                    if (!isobj5NameDisabled)
                    {
                        if ((this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Automation_AutomationProperties_Name((this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem), obj, null);
                        }
                    }
                }
            }
            private void Update_Content(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TabViewPage.xaml line 26
                    if (!isobj5ContentDisabled)
                    {
                        if ((this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content((this.obj5.Target as global::Microsoft.UI.Xaml.Controls.TabViewItem), obj, null);
                        }
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TabViewPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITabViewPage_Bindings
        {
            private global::Timuon.Views.TabViewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TabView obj2;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj3;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TabItemsSourceDisabled = false;
            private static bool isobj2AddTabButtonCommandDisabled = false;
            private static bool isobj3CommandDisabled = false;

            public TabViewPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 9)
                {
                    isobj2TabItemsSourceDisabled = true;
                }
                else if (lineNumber == 18 && columnNumber == 9)
                {
                    isobj2AddTabButtonCommandDisabled = true;
                }
                else if (lineNumber == 21 && columnNumber == 41)
                {
                    isobj3CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\TabViewPage.xaml line 15
                        this.obj2 = (global::Microsoft.UI.Xaml.Controls.TabView)target;
                        break;
                    case 3: // Views\TabViewPage.xaml line 21
                        this.obj3 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
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

            // ITabViewPage_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Timuon.Views.TabViewPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Timuon.Views.TabViewPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::Timuon.ViewModels.TabViewViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Tabs(obj.Tabs, phase);
                        this.Update_ViewModel_AddTabCommand(obj.AddTabCommand, phase);
                        this.Update_ViewModel_CloseTabCommand(obj.CloseTabCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_Tabs(global::System.Collections.ObjectModel.ObservableCollection<global::Timuon.Models.TabViewItemData> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TabViewPage.xaml line 15
                    if (!isobj2TabItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TabView_TabItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_AddTabCommand(global::Microsoft.Toolkit.Mvvm.Input.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TabViewPage.xaml line 15
                    if (!isobj2AddTabButtonCommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TabView_AddTabButtonCommand(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_CloseTabCommand(global::Microsoft.Toolkit.Mvvm.Input.RelayCommand<global::Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TabViewPage.xaml line 21
                    if (!isobj3CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj3, obj, null);
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
            case 1: // Views\TabViewPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TabViewPage_obj1_Bindings bindings = new TabViewPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 5: // Views\TabViewPage.xaml line 26
                {                    
                    global::Microsoft.UI.Xaml.Controls.TabViewItem element5 = (global::Microsoft.UI.Xaml.Controls.TabViewItem)target;
                    TabViewPage_obj5_Bindings bindings = new TabViewPage_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element5, bindings);
                }
                break;
            case 7: // Views\TabViewPage.xaml line 32
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element7 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    TabViewPage_obj7_Bindings bindings = new TabViewPage_obj7_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element7.DataContext);
                    element7.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element7, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element7, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

