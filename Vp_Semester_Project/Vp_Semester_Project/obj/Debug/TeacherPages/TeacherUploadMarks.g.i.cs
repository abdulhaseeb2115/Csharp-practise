﻿#pragma checksum "..\..\..\TeacherPages\TeacherUploadMarks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "336DD80D7B1E2C45D53C94CD1327A4AE77912222C6B859122EBEF84C7768B2FE"
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
using Vp_Semester_Project.TeacherPages;


namespace Vp_Semester_Project.TeacherPages {
    
    
    /// <summary>
    /// TeacherUploadMarks
    /// </summary>
    public partial class TeacherUploadMarks : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox className;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox assesmentName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox totalMarks;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel topHeadings;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl attendanceList;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/teacherpages/teacheruploadmarks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
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
            
            #line 52 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
            this.className.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.className_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.assesmentName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.totalMarks = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.topHeadings = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 5:
            this.attendanceList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 6:
            this.message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.submitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\TeacherPages\TeacherUploadMarks.xaml"
            this.submitBtn.Click += new System.Windows.RoutedEventHandler(this.submitBtn_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

