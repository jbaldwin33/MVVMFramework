using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using MVVMFrameworkNet472.Controls;
using MVVMFrameworkNet472.Utilities;
using MVVMFrameworkNet472.ViewModels;
using MVVMFrameworkNet472.ViewNavigator;

namespace MVVMFrameworkNet472.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BaseWindowView : ViewBaseWindow
    {
        public BaseWindowView((Type, string, bool)[] viewModelTypes) : base(new MainViewModel(Navigator.Instance))
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (viewModelTypes == null || viewModelTypes.Length == 0)
                throw new ArgumentNullException(nameof(viewModelTypes));

            InitializeComponent();
            Navigator.Instance.NavigationBar = navigationBar;
            foreach (var (type, name, show) in viewModelTypes)
            {
                var instance = (ViewModel)Activator.CreateInstance(type);
                if (Navigator.Instance.CurrentViewModel == null)
                    Navigator.Instance.CurrentViewModel = instance;

                Navigator.Instance.ViewModels.Add(instance);
                var button = new DefaultButton
                {
                    CommandParameter = instance,
                    Content = name,
                    Command = Navigator.Instance.UpdateCurrentViewModelCommand,
                };
                var binding = new Binding("IsShown")
                {
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    Converter = new InverseBooleanConverter(),
                    Source = Navigator.Instance.ViewModels.FirstOrDefault(vm => vm.GetType() == type)
                };

                button.SetBinding(IsEnabledProperty, binding);
                button.Visibility = show ? Visibility.Visible : Visibility.Collapsed;
                navigationBar.stackPanel.Children.Add(button);
            }
        }

        protected override void BeforeShow(object sender, RoutedEventArgs e) { }

        protected override void AfterShow(object sender, EventArgs e) { }

        protected override void OnClosing(object sender, CancelEventArgs e) { }

        protected override void OnClosed(object sender, EventArgs e) { }
    }
}
