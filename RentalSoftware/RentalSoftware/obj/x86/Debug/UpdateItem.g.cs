﻿#pragma checksum "..\..\..\UpdateItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0F08D34D6A13F77516B01701D424EB29"
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
    /// UpdateItem
    /// </summary>
    public partial class UpdateItem : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UpdateCategory;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateItemName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateItemDescription;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown UpdateUnitPrice;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown UpdateItemQuantity;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Item;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\UpdateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/RentalSoftware;component/updateitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpdateItem.xaml"
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
            
            #line 10 "..\..\..\UpdateItem.xaml"
            ((RentalSoftware.UpdateItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MetroWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UpdateCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\UpdateItem.xaml"
            this.UpdateCategory.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UpdateCategory_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateItemName = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\UpdateItem.xaml"
            this.UpdateItemName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextAndOtherCharatersValidation);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpdateItemDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\UpdateItem.xaml"
            this.UpdateItemDescription.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextAndOtherCharatersValidation);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdateUnitPrice = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 6:
            this.UpdateItemQuantity = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 7:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\UpdateItem.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Item = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.UpdateCancel = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\UpdateItem.xaml"
            this.UpdateCancel.Click += new System.Windows.RoutedEventHandler(this.UpdateCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

