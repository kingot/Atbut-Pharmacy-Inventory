﻿#pragma checksum "..\..\..\PurchaseOrder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D06E667548E947870BB5434DC74232C9"
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
    /// PurchaseOrder
    /// </summary>
    public partial class PurchaseOrder : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Item;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Vendor;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown UnitPrice;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown ItemQuantity;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalCost;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\PurchaseOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MakePurchaseOrder;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\PurchaseOrder.xaml"
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
            System.Uri resourceLocater = new System.Uri("/RentalSoftware;component/purchaseorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PurchaseOrder.xaml"
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
            
            #line 10 "..\..\..\PurchaseOrder.xaml"
            ((RentalSoftware.PurchaseOrder)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Item = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\PurchaseOrder.xaml"
            this.Item.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Item_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\PurchaseOrder.xaml"
            this.Item.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.Item_TextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Vendor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\PurchaseOrder.xaml"
            this.Vendor.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Vendor_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UnitPrice = ((MahApps.Metro.Controls.NumericUpDown)(target));
            
            #line 51 "..\..\..\PurchaseOrder.xaml"
            this.UnitPrice.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<double>>(this.UnitPrice_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ItemQuantity = ((MahApps.Metro.Controls.NumericUpDown)(target));
            
            #line 61 "..\..\..\PurchaseOrder.xaml"
            this.ItemQuantity.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<double>>(this.ItemQuantity_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TotalCost = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\PurchaseOrder.xaml"
            this.TotalCost.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\PurchaseOrder.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MakePurchaseOrder = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\PurchaseOrder.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

