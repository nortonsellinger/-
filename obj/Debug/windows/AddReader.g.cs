﻿#pragma checksum "..\..\..\windows\AddReader.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74DA7B678E237F1732694DE203CCC27139755F50BC7FCE87A5FFB27710992804"
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
    /// AddReader
    /// </summary>
    public partial class AddReader : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newname;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameerror;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newbirth;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock birthlackerror;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock birtherror;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newphone;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock phonelackerror;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\windows\AddReader.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock phoneerror;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARY_lite;component/windows/addreader.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\AddReader.xaml"
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
            
            #line 23 "..\..\..\windows\AddReader.xaml"
            this.newname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.name_typing);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\windows\AddReader.xaml"
            this.newname.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.name_check);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nameerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.newbirth = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\windows\AddReader.xaml"
            this.newbirth.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.birth_check);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\windows\AddReader.xaml"
            this.newbirth.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.birth_typing);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\windows\AddReader.xaml"
            this.newbirth.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.space_check);
            
            #line default
            #line hidden
            return;
            case 4:
            this.birthlackerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.birtherror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.newphone = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\windows\AddReader.xaml"
            this.newphone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.phone_typing_check);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\windows\AddReader.xaml"
            this.newphone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.phone_typing);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\windows\AddReader.xaml"
            this.newphone.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.space_check);
            
            #line default
            #line hidden
            return;
            case 7:
            this.phonelackerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.phoneerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 52 "..\..\..\windows\AddReader.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_reader);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 54 "..\..\..\windows\AddReader.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

