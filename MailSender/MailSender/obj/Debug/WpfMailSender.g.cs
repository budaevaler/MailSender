﻿#pragma checksum "..\..\WpfMailSender.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28D5FEF84BE175C0AEF98467CDDB42CDC4519934"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ListViewItemScheduler;
using MailSender;
using MailSender.View;
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
using TabSwitcher;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace MailSender {
    
    
    /// <summary>
    /// WpfMailSender
    /// </summary>
    public partial class WpfMailSender : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miClose;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabSend;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ISender;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSenderSelect;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSender;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditSender;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSender;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar tbSmtp;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lSmtp;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSmtpSelect;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSmtp;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditSmtp;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteSmtp;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MailSender.View.SaveEmailView saveEmail;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MailSender.View.EmailInfoView emailInfo;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabPlanner;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEMail;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDates;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSend;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSendAtOnce;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem tabEditer;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\WpfMailSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbTextMail;
        
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
            System.Uri resourceLocater = new System.Uri("/MailSender;component/wpfmailsender.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WpfMailSender.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.miClose = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\WpfMailSender.xaml"
            this.miClose.Click += new System.Windows.RoutedEventHandler(this.MiClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this.tabSend = ((System.Windows.Controls.TabItem)(target));
            return;
            case 4:
            this.ISender = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.cbSenderSelect = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnAddSender = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnEditSender = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnDeleteSender = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.tbSmtp = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 10:
            this.lSmtp = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.cbSmtpSelect = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.btnAddSmtp = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.btnEditSmtp = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.btnDeleteSmtp = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.saveEmail = ((MailSender.View.SaveEmailView)(target));
            return;
            case 16:
            this.emailInfo = ((MailSender.View.EmailInfoView)(target));
            return;
            case 17:
            this.tabPlanner = ((System.Windows.Controls.TabItem)(target));
            return;
            case 18:
            this.AddEMail = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\WpfMailSender.xaml"
            this.AddEMail.Click += new System.Windows.RoutedEventHandler(this.AddEMail_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.lvDates = ((System.Windows.Controls.ListView)(target));
            return;
            case 20:
            this.btnSend = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\WpfMailSender.xaml"
            this.btnSend.Click += new System.Windows.RoutedEventHandler(this.BtnSend_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.btnSendAtOnce = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\WpfMailSender.xaml"
            this.btnSendAtOnce.Click += new System.Windows.RoutedEventHandler(this.BtnSendAtOnce_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.tabEditer = ((System.Windows.Controls.TabItem)(target));
            return;
            case 23:
            this.rtbTextMail = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

