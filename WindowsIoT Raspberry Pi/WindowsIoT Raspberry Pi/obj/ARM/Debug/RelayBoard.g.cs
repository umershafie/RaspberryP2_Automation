﻿#pragma checksum "C:\Users\Anand\Google Drive\Raspberry Pi\WindowsIoT Raspberry Pi\WindowsIoT Raspberry Pi\RelayBoard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8541511D11F0CED3BD03039CB69F975"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsIoT_Raspberry_Pi
{
    partial class RelayBoard : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.device1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 11 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device1).Tapped += this.device1_Tapped;
                    #line 11 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device1).Unchecked += this.device1_Unchecked;
                    #line 11 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device1).Checked += this.device1_Checked;
                    #line default
                }
                break;
            case 2:
                {
                    this.device4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 12 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device4).Tapped += this.device4_Tapped;
                    #line 12 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device4).Checked += this.device4_Checked_1;
                    #line 12 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device4).Unchecked += this.device4_Unchecked;
                    #line default
                }
                break;
            case 3:
                {
                    this.device3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 13 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device3).Tapped += this.device3_Tapped;
                    #line 13 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device3).Checked += this.device3_Checked;
                    #line 13 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device3).Unchecked += this.device3_Unchecked;
                    #line default
                }
                break;
            case 4:
                {
                    this.device2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 14 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device2).Tapped += this.device2_Tapped;
                    #line 14 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device2).Checked += this.device2_Checked;
                    #line 14 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.device2).Unchecked += this.device2_Unchecked;
                    #line default
                }
                break;
            case 5:
                {
                    this.timer2_on = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 15 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.timer2_on).Toggled += this.timer2_on_Toggled;
                    #line default
                }
                break;
            case 6:
                {
                    this.timer3_on = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 16 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.timer3_on).Toggled += this.timer3_on_Toggled;
                    #line default
                }
                break;
            case 7:
                {
                    this.timer4_on = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 17 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.timer4_on).Toggled += this.timer4_on_Toggled;
                    #line default
                }
                break;
            case 8:
                {
                    this.timer1_on = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 18 "..\..\..\RelayBoard.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.timer1_on).Toggled += this.timer1_on_Toggled;
                    #line default
                }
                break;
            case 9:
                {
                    this.timer1_time = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 10:
                {
                    this.timer2_time = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 11:
                {
                    this.timer3_time = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 12:
                {
                    this.timer4_time = (global::Windows.UI.Xaml.Controls.TimePicker)(target);
                }
                break;
            case 13:
                {
                    this.devic1_second = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 14:
                {
                    this.devic2_second = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 15:
                {
                    this.devic3_second = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 16:
                {
                    this.devic4_second = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
