﻿#pragma checksum "C:\Users\kolop\Downloads\TimuOn\Timuon\Views\CoursesStudentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD3CF98A0BC03E9F7770A583C3090F0E75716190E0575207E796C475C4656AF4"
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
    partial class CoursesStudentPage : 
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
            case 2: // Views\CoursesStudentPage.xaml line 14
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\CoursesStudentPage.xaml line 34
                {
                    this.Linee = (global::Windows.UI.Xaml.Shapes.Line)(target);
                }
                break;
            case 4: // Views\CoursesStudentPage.xaml line 39
                {
                    this.YesAdd = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.YesAdd).Checked += this.Box_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.YesAdd).Unchecked += this.Box_CheckedChanged;
                }
                break;
            case 5: // Views\CoursesStudentPage.xaml line 40
                {
                    this.NoAdd = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.NoAdd).Checked += this.Box_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.NoAdd).Unchecked += this.Box_CheckedChanged;
                }
                break;
            case 6: // Views\CoursesStudentPage.xaml line 51
                {
                    this.AddCombobox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.AddCombobox).SelectionChanged += this.AddCourses_SelectedIndexChanged;
                }
                break;
            case 7: // Views\CoursesStudentPage.xaml line 57
                {
                    this.CanAttend = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\CoursesStudentPage.xaml line 58
                {
                    this.AttendCheckYes = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.AttendCheckYes).Checked += this.Attend_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.AttendCheckYes).Unchecked += this.Attend_CheckedChanged;
                }
                break;
            case 9: // Views\CoursesStudentPage.xaml line 59
                {
                    this.AttendCheckNo = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.AttendCheckNo).Checked += this.Attend_CheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.AttendCheckNo).Unchecked += this.Attend_CheckedChanged;
                }
                break;
            case 10: // Views\CoursesStudentPage.xaml line 60
                {
                    this.ConflictBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Views\CoursesStudentPage.xaml line 61
                {
                    this.CantAttendBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\CoursesStudentPage.xaml line 62
                {
                    this.CantAttendCombo = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.CantAttendCombo).SelectionChanged += this.AddCourses_SelectedIndexChanged;
                }
                break;
            case 13: // Views\CoursesStudentPage.xaml line 69
                {
                    this.ReasonAttend = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Views\CoursesStudentPage.xaml line 70
                {
                    this.SubmitButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SubmitButton).Click += this.Button_Click;
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

