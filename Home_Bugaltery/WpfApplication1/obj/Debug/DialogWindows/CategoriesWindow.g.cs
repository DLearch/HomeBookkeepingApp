﻿#pragma checksum "..\..\..\DialogWindows\CategoriesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15C01AA2265C3F78270706E26A119DFEACB5A8F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApplication1.DialogWindows;


namespace WpfApplication1.DialogWindows {
    
    
    /// <summary>
    /// CategoriesWindow
    /// </summary>
    public partial class CategoriesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxCategories;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonAddCategoryIncome;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonAddCategoryOutcome;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAddCategory;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox GroupBoxEditCategoryRB;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonEditCategoryIncome;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButtonEditCategoryOutcome;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEditCategory;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEditCategory;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\DialogWindows\CategoriesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemoveCategory;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/dialogwindows/categorieswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogWindows\CategoriesWindow.xaml"
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
            this.ListBoxCategories = ((System.Windows.Controls.ListBox)(target));
            
            #line 31 "..\..\..\DialogWindows\CategoriesWindow.xaml"
            this.ListBoxCategories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxCategories_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RadioButtonAddCategoryIncome = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.RadioButtonAddCategoryOutcome = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.TextBoxAddCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 64 "..\..\..\DialogWindows\CategoriesWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAddCategory_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GroupBoxEditCategoryRB = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 7:
            this.RadioButtonEditCategoryIncome = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.RadioButtonEditCategoryOutcome = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.TextBoxEditCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ButtonEditCategory = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\DialogWindows\CategoriesWindow.xaml"
            this.ButtonEditCategory.Click += new System.Windows.RoutedEventHandler(this.ButtonEditCategory_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonRemoveCategory = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\DialogWindows\CategoriesWindow.xaml"
            this.ButtonRemoveCategory.Click += new System.Windows.RoutedEventHandler(this.ButtonRemoveCategory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

