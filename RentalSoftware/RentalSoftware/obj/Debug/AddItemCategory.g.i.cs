﻿#pragma checksum "..\..\AddItemCategory.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "016EFDE23BFAB8EBDDD8429B22B9E0B9"
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
    /// AddItemCategory
    /// </summary>
    public partial class AddItemCategory : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\AddItemCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CategoryName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddItemCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CategoryDescription;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddItemCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddItemCategory.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AddCategory;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddItemCategory.xaml"
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
            System.Uri resourceLocater = new System.Uri("/RentalSoftware;component/additemcategory.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddItemCategory.xaml"
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
            this.CategoryName = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\AddItemCategory.xaml"
            this.CategoryName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CategoryDescription = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\AddItemCategory.xaml"
            this.CategoryDescription.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextAndOtherCharatersValidation);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AddItemCategory.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddCategory = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

