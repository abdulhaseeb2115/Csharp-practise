﻿#pragma checksum "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1BC64E9E937608615EE6DF54C2C3EC5B21D1550807AD36B9B66B789BD10560E"
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
using Vp_Semester_Project.AdminPages.AdminClassesPages;


namespace Vp_Semester_Project.AdminPages.AdminClassesPages {
    
    
    /// <summary>
    /// AddSubjectClass
    /// </summary>
    public partial class AddSubjectClass : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CreditHrsInput;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrerequisitesInput;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TeacherIdInput;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock msgOutput;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/adminpages/adminclassespages/addsubjectclass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
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
            this.CreditHrsInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PrerequisitesInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TeacherIdInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.msgOutput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.addStudent = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
            this.addStudent.Click += new System.Windows.RoutedEventHandler(this.addStudent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

