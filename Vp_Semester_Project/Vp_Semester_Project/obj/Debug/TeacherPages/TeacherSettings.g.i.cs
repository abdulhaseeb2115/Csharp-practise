﻿#pragma checksum "..\..\..\TeacherPages\TeacherSettings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4A615133A004C7A2D8D9A2A1C09B9837EB70E62F3EB0483056D5CAE8F92BCA5B"
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
    /// TeacherSettings
    /// </summary>
    public partial class TeacherSettings : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\TeacherPages\TeacherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox oldPass;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\TeacherPages\TeacherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPass1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\TeacherPages\TeacherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPass2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\TeacherPages\TeacherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock outMessage;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\TeacherPages\TeacherSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdatePasswordBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Vp_Semester_Project;component/teacherpages/teachersettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TeacherPages\TeacherSettings.xaml"
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
            this.oldPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.newPass1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.newPass2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.outMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.UpdatePasswordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\TeacherPages\TeacherSettings.xaml"
            this.UpdatePasswordBtn.Click += new System.Windows.RoutedEventHandler(this.UpdatePassword);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
