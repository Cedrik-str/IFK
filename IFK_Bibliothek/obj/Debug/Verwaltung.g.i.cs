﻿#pragma checksum "..\..\Verwaltung.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E72AAA36467DC869CA7EE8BFA11BE056FA268E41B21BD1789DCB01859FDE434"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IFK_Bibliothek;
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


namespace IFK_Bibliothek {
    
    
    /// <summary>
    /// Verwaltung
    /// </summary>
    public partial class Verwaltung : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Autor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Titel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Signatur;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Person;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Datum;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CdbHinzufügen;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CdbLöschen;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CdbZurück;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Verwaltung.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid pog;
        
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
            System.Uri resourceLocater = new System.Uri("/IFK_Bibliothek;component/verwaltung.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Verwaltung.xaml"
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
            this.ID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Autor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Titel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Signatur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Person = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Datum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.CdbHinzufügen = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Verwaltung.xaml"
            this.CdbHinzufügen.Click += new System.Windows.RoutedEventHandler(this.CdbHinzufügen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CdbLöschen = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Verwaltung.xaml"
            this.CdbLöschen.Click += new System.Windows.RoutedEventHandler(this.CdbLöschen_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CdbZurück = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Verwaltung.xaml"
            this.CdbZurück.Click += new System.Windows.RoutedEventHandler(this.CdbZurück_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.pog = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
