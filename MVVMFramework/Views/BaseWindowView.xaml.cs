using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using MVVMFramework.Controls;
using MVVMFramework.Utilities;
using MVVMFramework.ViewModels;
using MVVMFramework.ViewNavigator;

namespace MVVMFramework.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BaseWindowView : ViewBaseWindow
    {
        public BaseWindowView((ViewModel, bool)[] viewModelTypes) : base(new MainViewModel(Navigator.Instance))
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (viewModelTypes == null || viewModelTypes.Length == 0)
                throw new ArgumentNullException(nameof(viewModelTypes));

            InitializeComponent();
            Navigator.Instance.NavigationBar = navigationBar;
            foreach (var (vm, show) in viewModelTypes)
            {
                if (Navigator.Instance.CurrentViewModel == null)
                    Navigator.Instance.CurrentViewModel = vm;

                Navigator.Instance.ViewModels.Add(vm);
                var button = new DefaultButton
                {
                    CommandParameter = vm,
                    Content = vm.Name,
                    Command = Navigator.Instance.UpdateCurrentViewModelCommand,
                };
                var binding = new Binding("IsShown")
                {
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                    Converter = new InverseBooleanConverter(),
                    Source = Navigator.Instance.ViewModels.FirstOrDefault(viewModel => viewModel.GetType() == vm.GetType())
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
