#pragma checksum "C:\Users\A. Androutsopoulos\Documents\GitHub\TimuOn\Timuon\Views\History_Log.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B921DACFC132C3D80EE11A6B04E608AC1D8C9A6B5992F4C1A541D40F4FF2692B"
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
    partial class History_Log : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\History_Log.xaml line 188
                {
                    this.Drive_Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Views\History_Log.xaml line 189
                {
                    this.Drive_sub = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Views\History_Log.xaml line 190
                {
                    this.Drive_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Drive_Button).Click += this.Button_Click;
                }
                break;
            case 5: // Views\History_Log.xaml line 133
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Button_Click_1;
                }
                break;
            case 6: // Views\History_Log.xaml line 118
                {
                    this.courses = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.courses).Toggled += this.subs_Toggled;
                }
                break;
            case 7: // Views\History_Log.xaml line 119
                {
                    this.Org = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.Org).Toggled += this.Org_Toggled;
                }
                break;
            case 8: // Views\History_Log.xaml line 120
                {
                    this.teams = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.teams).Toggled += this.teams_Toggled;
                }
                break;
            case 9: // Views\History_Log.xaml line 122
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element9 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element9).SelectionChanged += this.ColorComboBox_SelectionChanged;
                }
                break;
            case 10: // Views\History_Log.xaml line 42
                {
                    this.org_list = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11: // Views\History_Log.xaml line 52
                {
                    this.course_list = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.course_list).SelectionChanged += this.course_list_SelectionChanged;
                }
                break;
            case 12: // Views\History_Log.xaml line 66
                {
                    this.teams_list = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.teams_list).SelectionChanged += this.course_list_SelectionChanged;
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
            return returnValue;
        }
    }
}

