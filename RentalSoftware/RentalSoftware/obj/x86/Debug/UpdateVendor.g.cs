﻿#pragma checksum "..\..\..\UpdateVendor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "489C9DF9561D325648429CC56ED97516"
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
    /// UpdateVendor
    /// </summary>
    public partial class UpdateVendor : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateCompanyName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateFirstName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateLastName;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateCity;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdatePhone;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateEmail;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UpdateAddress;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\UpdateVendor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UpdaterVendor;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\UpdateVendor.xaml"
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
            System.Uri resourceLocater = new System.Uri("/RentalSoftware;component/updatevendor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UpdateVendor.xaml"
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
            this.UpdateCompanyName = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\UpdateVendor.xaml"
            this.UpdateCompanyName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UpdateFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\UpdateVendor.xaml"
            this.UpdateFirstName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\UpdateVendor.xaml"
            this.UpdateLastName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpdateCity = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\UpdateVendor.xaml"
            this.UpdateCity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UpdatePhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\UpdateVendor.xaml"
            this.UpdatePhone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpdateEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\..\UpdateVendor.xaml"
            this.UpdateEmail.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextValidation);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UpdateAddress = ((System.Windows.Controls.TextBox)(target));
            
            #line 93 "..\..\..\UpdateVendor.xaml"
            this.UpdateAddress.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.BothNumberAndTextValidation);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\UpdateVendor.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.UpdaterVendor = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\UpdateVendor.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

