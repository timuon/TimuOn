﻿#pragma checksum "D:\User\Documents\Visual Studio 2019\Projects\TimuOn\Timuon\Views\TwoPaneViewListItemControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D6ECD474CBA4E0593CE99EA3C62896C4D9458F0BECE5C92A92F63819447E72ED"
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
    partial class TwoPaneViewListItemControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Timuon_StateTriggers_ControlSizeTrigger_TargetElement(global::Timuon.StateTriggers.ControlSizeTrigger obj, global::Windows.UI.Xaml.FrameworkElement value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.FrameworkElement) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.FrameworkElement), targetNullValue);
                }
                obj.TargetElement = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(global::Windows.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Glyph = value ?? global::System.String.Empty;
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
        private class TwoPaneViewListItemControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITwoPaneViewListItemControl_Bindings
        {
            private global::Timuon.Views.TwoPaneViewListItemControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Timuon.StateTriggers.ControlSizeTrigger obj4;
            private global::Windows.UI.Xaml.Controls.FontIcon obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4TargetElementDisabled = false;
            private static bool isobj5GlyphDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj13TextDisabled = false;

            private TwoPaneViewListItemControl_obj1_BindingsTracking bindingsTracking;

            public TwoPaneViewListItemControl_obj1_Bindings()
            {
                this.bindingsTracking = new TwoPaneViewListItemControl_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 21 && columnNumber == 74)
                {
                    isobj4TargetElementDisabled = true;
                }
                else if (lineNumber == 38 && columnNumber == 13)
                {
                    isobj5GlyphDisabled = true;
                }
                else if (lineNumber == 76 && columnNumber == 67)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 72 && columnNumber == 75)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 67 && columnNumber == 72)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 69 && columnNumber == 72)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 67)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 49 && columnNumber == 68)
                {
                    isobj13TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Views\TwoPaneViewListItemControl.xaml line 21
                        this.obj4 = (global::Timuon.StateTriggers.ControlSizeTrigger)target;
                        break;
                    case 5: // Views\TwoPaneViewListItemControl.xaml line 34
                        this.obj5 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 8: // Views\TwoPaneViewListItemControl.xaml line 76
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // Views\TwoPaneViewListItemControl.xaml line 72
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10: // Views\TwoPaneViewListItemControl.xaml line 67
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // Views\TwoPaneViewListItemControl.xaml line 69
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12: // Views\TwoPaneViewListItemControl.xaml line 51
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13: // Views\TwoPaneViewListItemControl.xaml line 49
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // ITwoPaneViewListItemControl_Bindings

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
                    this.dataRoot = (global::Timuon.Views.TwoPaneViewListItemControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Timuon.Views.TwoPaneViewListItemControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_mainGrid(obj.mainGrid, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Item(obj.Item, phase);
                    }
                }
            }
            private void Update_mainGrid(global::Windows.UI.Xaml.Controls.Grid obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TwoPaneViewListItemControl.xaml line 21
                    if (!isobj4TargetElementDisabled)
                    {
                        XamlBindingSetters.Set_Timuon_StateTriggers_ControlSizeTrigger_TargetElement(this.obj4, obj, null);
                    }
                }
            }
            private void Update_Item(global::Timuon.Core.Models.SampleOrder obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Item_Symbol(obj.Symbol, phase);
                        this.Update_Item_ShipTo(obj.ShipTo, phase);
                        this.Update_Item_OrderDate(obj.OrderDate, phase);
                        this.Update_Item_OrderID(obj.OrderID, phase);
                        this.Update_Item_Status(obj.Status, phase);
                    }
                }
            }
            private void Update_Item_Symbol(global::System.Char obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TwoPaneViewListItemControl.xaml line 34
                    if (!isobj5GlyphDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(this.obj5, obj.ToString(), null);
                    }
                }
            }
            private void Update_Item_ShipTo(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TwoPaneViewListItemControl.xaml line 76
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_Item_OrderDate(global::System.DateTime obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TwoPaneViewListItemControl.xaml line 72
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, (global::System.String)this.LookupConverter("dateTimeFormatConverter").Convert(obj, typeof(global::System.String), "dd/MM/yy hh:mm", null), null);
                    }
                }
            }
            private void Update_Item_OrderID(global::System.Int64 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TwoPaneViewListItemControl.xaml line 67
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj.ToString(), null);
                    }
                    // Views\TwoPaneViewListItemControl.xaml line 49
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj.ToString(), null);
                    }
                }
            }
            private void Update_Item_Status(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TwoPaneViewListItemControl.xaml line 69
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                    }
                    // Views\TwoPaneViewListItemControl.xaml line 51
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TwoPaneViewListItemControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<TwoPaneViewListItemControl_obj1_Bindings> weakRefToBindingObj; 

                public TwoPaneViewListItemControl_obj1_BindingsTracking(TwoPaneViewListItemControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TwoPaneViewListItemControl_obj1_Bindings>(obj);
                }

                public TwoPaneViewListItemControl_obj1_Bindings TryGetBindingObject()
                {
                    TwoPaneViewListItemControl_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_Item(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    TwoPaneViewListItemControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Timuon.Views.TwoPaneViewListItemControl obj = sender as global::Timuon.Views.TwoPaneViewListItemControl;
                        if (obj != null)
                        {
                            bindings.Update_Item(obj.Item, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Item = 0;
                public void UpdateChildListeners_(global::Timuon.Views.TwoPaneViewListItemControl obj)
                {
                    TwoPaneViewListItemControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Timuon.Views.TwoPaneViewListItemControl.ItemProperty, tokenDPC_Item);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Item = obj.RegisterPropertyChangedCallback(global::Timuon.Views.TwoPaneViewListItemControl.ItemProperty, DependencyPropertyChanged_Item);
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
            case 2: // Views\TwoPaneViewListItemControl.xaml line 14
                {
                    this.dateTimeFormatConverter = (global::Timuon.Converters.DateTimeFormatConverter)(target);
                }
                break;
            case 3: // Views\TwoPaneViewListItemControl.xaml line 16
                {
                    this.mainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // Views\TwoPaneViewListItemControl.xaml line 42
                {
                    this.shortItemPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 7: // Views\TwoPaneViewListItemControl.xaml line 54
                {
                    this.extendedItemPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
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
            case 1: // Views\TwoPaneViewListItemControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    TwoPaneViewListItemControl_obj1_Bindings bindings = new TwoPaneViewListItemControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
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

