﻿#pragma checksum "..\..\..\View\UpdateType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "713AE1C05514848783708E7560FB87B3CC77F9BC7DF1D38F10DDB3307B2772BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp2.Validations;
using WpfApp2.View;


namespace WpfApp2.View {
    
    
    /// <summary>
    /// UpdateType
    /// </summary>
    public partial class UpdateType : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\UpdateType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdBinding;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\UpdateType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBinding;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\UpdateType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageBinding;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\View\UpdateType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/view/updatetype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\UpdateType.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.IdBinding = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NameBinding = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ImageBinding = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 68 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\View\UpdateType.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 76 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 94 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEventTagWindow);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 97 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEventTypeWindow);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 100 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEventWindow);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 103 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllEventsWindow);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 106 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HomeWindow);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 109 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HelpWindow);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 112 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 115 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditWindow);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 118 "..\..\..\View\UpdateType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MapWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

