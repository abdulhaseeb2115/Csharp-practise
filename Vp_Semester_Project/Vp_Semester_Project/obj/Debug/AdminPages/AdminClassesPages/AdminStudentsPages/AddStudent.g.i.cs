﻿#pragma checksum "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "45496247BAC97518FAF6351123A2E3ACA8EBA9D23F22A75C1B42DE6FCDD34809"
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
using Vp_Semester_Project.AdminPages.AdminStudentsPages;


namespace Vp_Semester_Project.AdminPages.AdminStudentsPages {
    
    
    /// <summary>
    /// AddStudent
    /// </summary>
    public partial class AddStudent : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FatherNameInput;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DOBInput;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailInput;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneInput;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addStudent;
        
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/adminpages/adminclassespages/adminstudentspages/ad" +
                    "dstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
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
            this.DOBInput = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.EmailInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PhoneInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.addStudent = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\AddStudent.xaml"
            this.addStudent.Click += new System.Windows.RoutedEventHandler(this.addStudent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
