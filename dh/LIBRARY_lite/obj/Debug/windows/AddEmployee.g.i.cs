﻿#pragma checksum "..\..\..\windows\AddEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E4EEA1CA6EEE8177000E5E3B3012440429A76FE8840E0FF152FDE9B77EFD825"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LIBRARY_lite.windows;
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


namespace LIBRARY_lite.windows {
    
    
    /// <summary>
    /// AddEmployee
    /// </summary>
    public partial class AddEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\windows\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newname;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\windows\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameerror;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\windows\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newlogin;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\windows\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock loginerror;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\windows\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newpassword;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\windows\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock passworderror;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARY_lite;component/windows/addemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\AddEmployee.xaml"
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
            this.newname = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\windows\AddEmployee.xaml"
            this.newname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.name_typing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nameerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.newlogin = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\windows\AddEmployee.xaml"
            this.newlogin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.login_typing);
            
            #line default
            #line hidden
            return;
            case 4:
            this.loginerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.newpassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\windows\AddEmployee.xaml"
            this.newpassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.password_typing);
            
            #line default
            #line hidden
            return;
            case 6:
            this.passworderror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 35 "..\..\..\windows\AddEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_employee);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 36 "..\..\..\windows\AddEmployee.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

