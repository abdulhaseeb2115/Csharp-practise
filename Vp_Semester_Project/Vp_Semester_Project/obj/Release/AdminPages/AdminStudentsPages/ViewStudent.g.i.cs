﻿#pragma checksum "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D19FDD42AD3AFEF3F5C8D45E4E25DCEA15CBFC3A3BFC4346DA84122442FBA6E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Vp_Semester_Project.AdminPages.AdminStudentsPages;


namespace Vp_Semester_Project.AdminPages.AdminStudentsPages {
    
    
    /// <summary>
    /// ViewStudent
    /// </summary>
    public partial class ViewStudent : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputRegNo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameOutput;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FatherNameOutput;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DOBOutput;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmailOutput;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PhoneOutput;
        
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/adminpages/adminstudentspages/viewstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
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
            this.InputRegNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.search = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\AdminPages\AdminStudentsPages\ViewStudent.xaml"
            this.search.Click += new System.Windows.RoutedEventHandler(this.search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.FatherNameOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DOBOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.EmailOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PhoneOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

