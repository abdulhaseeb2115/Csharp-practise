﻿#pragma checksum "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A675C981A98171E11B9FEB2157A0A15F762EDA3A69BB21D193CEE2110C3A0E29"
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
        
        
        #line 49 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox className;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox courseName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox teacherName;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
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
            this.className = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.courseName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.teacherName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\AdminPages\AdminClassesPages\AddSubjectClass.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

