using System.Windows;
using System.Windows.Controls;
using MVVMFrameworkNet472.ViewModels;
using MVVMFrameworkNet472.ViewNavigator;

namespace MVVMFrameworkNet472.Views
{
    public abstract class ViewBaseControl : UserControl
    {
        private readonly ViewModel viewModel;

        protected ViewBaseControl()
        {
            viewModel = Navigator.Instance.CurrentViewModel;
            DataContext = viewModel;
            Height = 480;
            Width = 800;
            Loaded += ViewBaseControl_Loaded;
            Unloaded += ViewBaseControl_Unloaded;
        }

        public virtual void ViewBaseControl_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.IsShown = true;
            viewModel.ShowMessageBoxEventHandler += ViewModel_ShowMessageBoxEventHandler;
            viewModel.OnLoaded();
        }

        public virtual void ViewBaseControl_Unloaded(object sender, RoutedEventArgs e)
        {
            viewModel.IsShown = false;
            viewModel.ShowMessageBoxEventHandler -= ViewModel_ShowMessageBoxEventHandler;
            Loaded -= ViewBaseControl_Loaded;
            Unloaded -= ViewBaseControl_Unloaded;
            viewModel.OnUnloaded();
        }

        

        private void ViewModel_ShowMessageBoxEventHandler(object sender, MessageBoxEventArgs e) 
            => e.Result = Application.Current.Dispatcher.Invoke(() => MessageBox.Show(Navigator.Instance.ChildViewShown ? Navigator.Instance.ChildView : Application.Current.MainWindow, e.Message, e.MessageType.ToString(), e.Button, e.Image));
    }
}