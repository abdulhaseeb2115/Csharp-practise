﻿#pragma checksum "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F3CAB361006C4D3BBD6A27014E1781BA60482AE089518555A261ACF6C564CB6"
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
    /// DeleteStudent
    /// </summary>
    public partial class DeleteStudent : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputRegNo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameOutput;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FatherNameOutput;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DOBOutput;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmailOutput;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PhoneOutput;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete;
        
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/adminpages/adminclassespages/adminstudentspages/de" +
                    "letestudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
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
            
            #line 40 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
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
            case 8:
            this.message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.delete = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\..\..\AdminPages\AdminClassesPages\AdminStudentsPages\DeleteStudent.xaml"
            this.delete.Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

