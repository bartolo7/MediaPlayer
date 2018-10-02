﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45E791A3E7AE431652B0D344548F7A708E9B51F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MediaPlayer;
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


namespace MediaPlayer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkJPG;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkPNG;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkMP4;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView trvStructure;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstThumbNails;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid daGPlaylist;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlay;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddToPlayList;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveFromPlayList;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMoveUpOnePlace;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMoveDownOnePlace;
        
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
            System.Uri resourceLocater = new System.Uri("/MediaPlayer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.chkJPG = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.chkPNG = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.chkMP4 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.trvStructure = ((System.Windows.Controls.TreeView)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.trvStructure.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.TreeViewItem_IsSelected);
            
            #line default
            #line hidden
            
            #line 51 "..\..\MainWindow.xaml"
            this.trvStructure.AddHandler(System.Windows.Controls.TreeViewItem.ExpandedEvent, new System.Windows.RoutedEventHandler(this.TreeViewItem_Expanded));
            
            #line default
            #line hidden
            return;
            case 6:
            this.lstThumbNails = ((System.Windows.Controls.ListBox)(target));
            
            #line 82 "..\..\MainWindow.xaml"
            this.lstThumbNails.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstThumbNails_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.daGPlaylist = ((System.Windows.Controls.DataGrid)(target));
            
            #line 129 "..\..\MainWindow.xaml"
            this.daGPlaylist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.daGPlaylist_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\MainWindow.xaml"
            this.btnPlay.Click += new System.Windows.RoutedEventHandler(this.btnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddToPlayList = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\MainWindow.xaml"
            this.btnAddToPlayList.Click += new System.Windows.RoutedEventHandler(this.btnAddToPlayList_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRemoveFromPlayList = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\MainWindow.xaml"
            this.btnRemoveFromPlayList.Click += new System.Windows.RoutedEventHandler(this.btnRemoveFromPlayList_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnMoveUpOnePlace = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\MainWindow.xaml"
            this.btnMoveUpOnePlace.Click += new System.Windows.RoutedEventHandler(this.btnMoveUpOnePlace_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnMoveDownOnePlace = ((System.Windows.Controls.Button)(target));
            
            #line 171 "..\..\MainWindow.xaml"
            this.btnMoveDownOnePlace.Click += new System.Windows.RoutedEventHandler(this.btnMoveDownOnePlace_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
