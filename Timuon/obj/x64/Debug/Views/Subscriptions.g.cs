﻿#pragma checksum "C:\Users\A. Androutsopoulos\Documents\GitHub\TimuOn\Timuon\Views\Subscriptions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C68E29A94C097E42DF215022EBD9F11C91116D11A64E4D0EBB4AC52F775CCCAC"
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
    partial class Subscriptions : 
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
            case 2: // Views\Subscriptions.xaml line 126
                {
                    this.channel_list = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // Views\Subscriptions.xaml line 136
                {
                    this.subs_list = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4: // Views\Subscriptions.xaml line 148
                {
                    this.search_list = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 5: // Views\Subscriptions.xaml line 161
                {
                    this.FilterByLName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.FilterByLName).TextChanged += this.FilteredLV_LNameChanged;
                }
                break;
            case 9: // Views\Subscriptions.xaml line 45
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Button_Click;
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

