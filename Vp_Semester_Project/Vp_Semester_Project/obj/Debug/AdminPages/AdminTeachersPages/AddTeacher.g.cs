﻿#pragma checksum "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D9BD4A89CF8DA4334B11466282E4175C966FAF238F2177C28BFDCB7C7577D11"
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
using Vp_Semester_Project.AdminPages.AdminTeachersPages;


namespace Vp_Semester_Project.AdminPages.AdminTeachersPages {
    
    
    /// <summary>
    /// AddTeacher
    /// </summary>
    public partial class AddTeacher : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FatherNameInput;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QualificationInput;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailInput;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneInput;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressInput;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTeacher;
        
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/adminpages/adminteacherspages/addteacher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
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
            this.NameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.FatherNameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.QualificationInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EmailInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PhoneInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AddressInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.addTeacher = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\AdminPages\AdminTeachersPages\AddTeacher.xaml"
            this.addTeacher.Click += new System.Windows.RoutedEventHandler(this.addTeacher_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

