﻿#pragma checksum "..\..\..\wraps.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88FB690B5FFBD0475B86EC6344E272064B575091"
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
    /// wraps
    /// </summary>
    public partial class wraps : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid FoodMenu;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chicken_Cesar_Wrap;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buffalo_Chicken_Wrap;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Breakfast_Wrap;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Nashville_Chicken_Wrap;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Philly_Steak_Wrap;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chicken_Lettuce_Wrap;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\wraps.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Lemon_Chicken_Wrap;
        
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
            System.Uri resourceLocater = new System.Uri("/menu-repo;component/wraps.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\wraps.xaml"
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
            
            #line 16 "..\..\..\wraps.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoMain);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\..\wraps.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Chicken_Cesar_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Buffalo_Chicken_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Breakfast_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Nashville_Chicken_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Philly_Steak_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.Chicken_Lettuce_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.Lemon_Chicken_Wrap = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

