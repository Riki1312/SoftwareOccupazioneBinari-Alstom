﻿#pragma checksum "..\..\Window_conflitto.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52F49857E1A5E63FAB61B3AFDAF496419A4971A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
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
using project1_andromeda_0._0._2;


namespace project1_andromeda_0._0._2 {
    
    
    /// <summary>
    /// Window_conflitto
    /// </summary>
    public partial class Window_conflitto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Window_conflitto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlock_npCollidenti;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Window_conflitto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_progettiCollidenti;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window_conflitto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_conferma;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window_conflitto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_soluzione;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window_conflitto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_annulla;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window_conflitto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_progettoSelezionato;
        
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
            System.Uri resourceLocater = new System.Uri("/project1-andromeda_0.0.2;component/window_conflitto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window_conflitto.xaml"
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
            this.TextBlock_npCollidenti = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Grid_progettiCollidenti = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Button_conferma = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Window_conflitto.xaml"
            this.Button_conferma.Click += new System.Windows.RoutedEventHandler(this.Button_conferma_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Button_soluzione = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Window_conflitto.xaml"
            this.Button_soluzione.Click += new System.Windows.RoutedEventHandler(this.Button_soluzione_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_annulla = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Window_conflitto.xaml"
            this.Button_annulla.Click += new System.Windows.RoutedEventHandler(this.Button_annulla_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Grid_progettoSelezionato = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
