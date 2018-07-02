﻿#pragma checksum "..\..\..\AddItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93EBD712D4D2DF9FA7894BEBFCD2791D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using RentalSoftware;
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


namespace RentalSoftware {
    
    
    /// <summary>
    /// AddItem
    /// </summary>
    public partial class AddItem : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Category;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Vendor;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemName;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemDescription;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown UnitPrice;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown ItemQuantity;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AddNewItem;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\AddItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/RentalSoftware;component/additem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddItem.xaml"
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
            
            #line 10 "..\..\..\AddItem.xaml"
            ((RentalSoftware.AddItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Category = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\AddItem.xaml"
            this.Category.Loaded += new System.Windows.RoutedEventHandler(this.Category_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Vendor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\AddItem.xaml"
            this.Vendor.Loaded += new System.Windows.RoutedEventHandler(this.Category_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ItemName = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\AddItem.xaml"
            this.ItemName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextAndOtherCharatersValidation);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ItemDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\AddItem.xaml"
            this.ItemDescription.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextAndOtherCharatersValidation);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UnitPrice = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 7:
            this.ItemQuantity = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 8:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\AddItem.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddNewItem = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\AddItem.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

