﻿#pragma checksum "..\..\..\BlogWindow - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B6F7A8B85CDD3A9E7544AE3697FE68553144130"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GUILayer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GUILayer {
    
    
    /// <summary>
    /// BlogWindow
    /// </summary>
    public partial class BlogWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BlogGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeFromBlogButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewBlogButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBlogButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBlogButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewPostsButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox BlogList;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\BlogWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BlogUrl;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUILayer;V1.0.0.0;component/blogwindow%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BlogWindow - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BlogGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.HomeFromBlogButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\BlogWindow - Copy.xaml"
            this.HomeFromBlogButton.Click += new System.Windows.RoutedEventHandler(this.HomeButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewBlogButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\BlogWindow - Copy.xaml"
            this.NewBlogButton.Click += new System.Windows.RoutedEventHandler(this.NewBlogButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteBlogButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\BlogWindow - Copy.xaml"
            this.DeleteBlogButton.Click += new System.Windows.RoutedEventHandler(this.DeleteBlogButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdateBlogButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\BlogWindow - Copy.xaml"
            this.UpdateBlogButton.Click += new System.Windows.RoutedEventHandler(this.UpdateBlogButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ViewPostsButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\BlogWindow - Copy.xaml"
            this.ViewPostsButton.Click += new System.Windows.RoutedEventHandler(this.ViewPostsButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BlogList = ((System.Windows.Controls.ListBox)(target));
            
            #line 30 "..\..\..\BlogWindow - Copy.xaml"
            this.BlogList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BlogList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BlogUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

