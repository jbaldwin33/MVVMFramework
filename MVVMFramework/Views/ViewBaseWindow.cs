using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVVMFramework.ViewModels;

namespace MVVMFramework.Views
{
    public abstract class ViewBaseWindow : Window
    {
        protected ViewBaseWindow(ViewModel viewModel)
        {
            DataContext = viewModel;
            Loaded += BeforeShow;
            ContentRendered += AfterShow;
            Closing += OnClosing;
            Closed += OnClosed;
        }

        protected virtual void BeforeShow(object sender, RoutedEventArgs e) { }
        protected virtual void AfterShow(object sender, EventArgs e) { }
        protected virtual void OnClosing(object sender, CancelEventArgs e) { }
        protected virtual void OnClosed(object sender, EventArgs e) { }
    }
}
