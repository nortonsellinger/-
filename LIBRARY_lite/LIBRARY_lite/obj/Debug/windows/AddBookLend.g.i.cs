﻿#pragma checksum "..\..\..\windows\AddBookLend.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DE71E0895509C8B49BE292AC6461D548DDD742F275ADE3D0F75330DD4B4A8E9"
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
    /// AddBookLend
    /// </summary>
    public partial class AddBookLend : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ReadersDG;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock readererror;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid books;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock booklackerror;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock reader;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock booklist;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid bookstogive;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lenddate;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\windows\AddBookLend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock returndate;
        
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
            System.Uri resourceLocater = new System.Uri("/LIBRARY_lite;component/windows/addbooklend.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\AddBookLend.xaml"
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
            
            #line 34 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.reader_search);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ReadersDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.readererror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 73 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.book_search);
            
            #line default
            #line hidden
            return;
            case 6:
            this.books = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.booklackerror = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.reader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.booklist = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.bookstogive = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            this.lenddate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.returndate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            
            #line 173 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_booklend);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 174 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 51 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.select_reader);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 105 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.add_book);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 149 "..\..\..\windows\AddBookLend.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.remove_book);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

