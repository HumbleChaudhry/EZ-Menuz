﻿#pragma checksum "..\..\..\beers.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130EC9780707D81739B40B7C1D3168322BF1F271"
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
using menu_repo;


namespace menu_repo {
    
    
    /// <summary>
    /// beers
    /// </summary>
    public partial class beers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FoodMenu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Corona;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BudLight;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Yuengling;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Budweiser;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MichelobUltra;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\beers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CoorsLight;
        
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
            System.Uri resourceLocater = new System.Uri("/menu-repo;component/beers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\beers.xaml"
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
            this.FoodMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 16 "..\..\..\beers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoMain);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\..\beers.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Corona = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\beers.xaml"
            this.Corona.Click += new System.Windows.RoutedEventHandler(this.Corona_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BudLight = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\beers.xaml"
            this.BudLight.Click += new System.Windows.RoutedEventHandler(this.BudL_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Yuengling = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\beers.xaml"
            this.Yuengling.Click += new System.Windows.RoutedEventHandler(this.YL_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Budweiser = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\beers.xaml"
            this.Budweiser.Click += new System.Windows.RoutedEventHandler(this.Bud_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MichelobUltra = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\beers.xaml"
            this.MichelobUltra.Click += new System.Windows.RoutedEventHandler(this.Michel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CoorsLight = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\beers.xaml"
            this.CoorsLight.Click += new System.Windows.RoutedEventHandler(this.CoronaL_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

