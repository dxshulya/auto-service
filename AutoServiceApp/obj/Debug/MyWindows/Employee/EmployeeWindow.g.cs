#pragma checksum "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48F0D2CAA908883748C97B105CDAFDFA3814D37E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoServiceApp.MyWindows.Employee;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AutoServiceApp.MyWindows.Employee {
    
    
    /// <summary>
    /// EmployeeWindow
    /// </summary>
    public partial class EmployeeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid clientsGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_btn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_btn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button change_btn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update_table_btn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid bookingServicesGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button update_btn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoServiceApp;component/mywindows/employee/employeewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.clientsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.add_btn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
            this.add_btn.Click += new System.Windows.RoutedEventHandler(this.Add_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delete_btn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
            this.delete_btn.Click += new System.Windows.RoutedEventHandler(this.Delete_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.change_btn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
            this.change_btn.Click += new System.Windows.RoutedEventHandler(this.Change_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.update_table_btn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
            this.update_table_btn.Click += new System.Windows.RoutedEventHandler(this.Update_table_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bookingServicesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.update_btn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\MyWindows\Employee\EmployeeWindow.xaml"
            this.update_btn.Click += new System.Windows.RoutedEventHandler(this.Update_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

