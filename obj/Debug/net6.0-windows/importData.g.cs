﻿#pragma checksum "..\..\..\importData.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ADA7A05F30F1D999090E9966C97367530F9025A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using data_report7;


namespace data_report7 {
    
    
    /// <summary>
    /// importData
    /// </summary>
    public partial class importData : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid cboxFilterDepartments;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbInformationImport;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImportData;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPieChartPage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgData;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLetters;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbInformationFilter;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\importData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart Chart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/data-report7;component/importdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\importData.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cboxFilterDepartments = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.lbInformationImport = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnImportData = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\importData.xaml"
            this.btnImportData.Click += new System.Windows.RoutedEventHandler(this.btnImportData_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnPieChartPage = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\importData.xaml"
            this.btnPieChartPage.Click += new System.Windows.RoutedEventHandler(this.btnPieChartPage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.cbLetters = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\importData.xaml"
            this.cbLetters.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSelect);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbInformationFilter = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Chart = ((LiveCharts.Wpf.PieChart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

