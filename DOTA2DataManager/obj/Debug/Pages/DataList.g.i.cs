﻿#pragma checksum "..\..\..\Pages\DataList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D14D45F874A02BB061338C6124607C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DOTA2DataManager;
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


namespace DOTA2DataManager {
    
    
    /// <summary>
    /// DataList
    /// </summary>
    public partial class DataList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\DataList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Grid_Team;
        
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
            System.Uri resourceLocater = new System.Uri("/DOTA2DataManager;component/pages/datalist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\DataList.xaml"
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
            
            #line 15 "..\..\..\Pages\DataList.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ViewTeams);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Grid_Team = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 31 "..\..\..\Pages\DataList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshTeam);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\..\Pages\DataList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTeam);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\..\Pages\DataList.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ViewPlayers);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

