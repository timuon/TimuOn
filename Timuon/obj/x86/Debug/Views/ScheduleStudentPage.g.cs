﻿#pragma checksum "C:\Users\kolop\Downloads\TimuOn\Timuon\Views\ScheduleStudentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56BBD04774CA03283191765D5DEA5FC7412600AB2C161B4389038981A45D7B74"
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
    partial class ScheduleStudentPage : 
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
            case 2: // Views\ScheduleStudentPage.xaml line 12
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\ScheduleStudentPage.xaml line 26
                {
                    this.ScheduleLine = (global::Windows.UI.Xaml.Shapes.Line)(target);
                }
                break;
            case 4: // Views\ScheduleStudentPage.xaml line 36
                {
                    this.AppointLine = (global::Windows.UI.Xaml.Shapes.Line)(target);
                }
                break;
            case 5: // Views\ScheduleStudentPage.xaml line 41
                {
                    this.Yes1 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Yes1).Checked += this.Box_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Yes1).Unchecked += this.Box_CheckedChanged;
                }
                break;
            case 6: // Views\ScheduleStudentPage.xaml line 42
                {
                    this.No1 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.No1).Checked += this.Box_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.No1).Unchecked += this.Box_CheckedChanged;
                }
                break;
            case 7: // Views\ScheduleStudentPage.xaml line 51
                {
                    this.CalendarPickk = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 8: // Views\ScheduleStudentPage.xaml line 52
                {
                    this.Scheduleheader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\ScheduleStudentPage.xaml line 55
                {
                    this.EventCombo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.EventCombo).SelectionChanged += this.Event_SelectedIndexChanged;
                }
                break;
            case 10: // Views\ScheduleStudentPage.xaml line 59
                {
                    this.HourCombo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.HourCombo).SelectionChanged += this.NewHour_SelectedIndexChanged;
                }
                break;
            case 11: // Views\ScheduleStudentPage.xaml line 64
                {
                    this.Appointment = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\ScheduleStudentPage.xaml line 65
                {
                    this.Yes2 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Yes2).Checked += this.Box2_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.Yes2).Unchecked += this.Box2_CheckedChanged;
                }
                break;
            case 13: // Views\ScheduleStudentPage.xaml line 66
                {
                    this.No2 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.No2).Checked += this.Box2_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.No2).Unchecked += this.Box2_CheckedChanged;
                }
                break;
            case 14: // Views\ScheduleStudentPage.xaml line 67
                {
                    this.ReasonTimePeriod = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Views\ScheduleStudentPage.xaml line 68
                {
                    this.SubmitButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SubmitButton).Click += this.Button_Click;
                }
                break;
            case 16: // Views\ScheduleStudentPage.xaml line 69
                {
                    this.Userss = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.Userss).SelectionChanged += this.Contanct_SelectedIndexChanged;
                }
                break;
            case 17: // Views\ScheduleStudentPage.xaml line 74
                {
                    this.CommonHours = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\ScheduleStudentPage.xaml line 75
                {
                    this.SelectHour1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.SelectHour1).SelectionChanged += this.NewPeriod_SelectedIndexChanged;
                }
                break;
            case 19: // Views\ScheduleStudentPage.xaml line 81
                {
                    this.SelectHour2 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 20: // Views\ScheduleStudentPage.xaml line 86
                {
                    this.MessageMeeting = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

