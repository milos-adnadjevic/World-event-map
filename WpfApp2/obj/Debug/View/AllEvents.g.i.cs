﻿#pragma checksum "..\..\..\View\AllEvents.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A4948B61F0FC5B82D33C5B6AA985B666734E2318374549334740F76EDC956BD"
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
using WpfApp2.View;


namespace WpfApp2.View {
    
    
    /// <summary>
    /// AllEvents
    /// </summary>
    public partial class AllEvents : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 11 "..\..\..\View\AllEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\AllEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterBinding;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\AllEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AllEventsBinding;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\AllEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllTags;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\AllEvents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllTypes;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/view/allevents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AllEvents.xaml"
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
            
            #line 8 "..\..\..\View\AllEvents.xaml"
            ((WpfApp2.View.AllEvents)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\View\AllEvents.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterBinding = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\View\AllEvents.xaml"
            this.FilterBinding.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterBinding_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AllEventsBinding = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\View\AllEvents.xaml"
            this.AllEventsBinding.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AllEventsBinding_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AllTags = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\View\AllEvents.xaml"
            this.AllTags.Click += new System.Windows.RoutedEventHandler(this.AllTags_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AllTypes = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\View\AllEvents.xaml"
            this.AllTypes.Click += new System.Windows.RoutedEventHandler(this.AllTypes_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 67 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEventTagWindow);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 70 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEventTypeWindow);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 73 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateEventWindow);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 76 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllEventsWindow);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 79 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HomeWindow);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 82 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HelpWindow);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 85 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 88 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditWindow);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 91 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MapWindow);
            
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
            case 5:
            
            #line 36 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditWindow);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 45 "..\..\..\View\AllEvents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

