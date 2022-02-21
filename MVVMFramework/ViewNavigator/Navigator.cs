using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using MVVMFramework.ViewModels;
using MVVMFramework.Views;
using System.Windows.Controls;

namespace MVVMFramework.ViewNavigator
{
    public class Navigator : INavigator, INotifyPropertyChanged
    {
        private static readonly Lazy<Navigator> instance = new Lazy<Navigator>(() => new Navigator());
        public static Navigator Instance => instance.Value;

        #region Fields and props

        private NavigationBar navigationBar;
        private List<ViewModel> viewModels = new List<ViewModel>();
        private ViewModel mainViewModel;
        private ViewModel currentViewModel;
        private ViewModel childViewModel;
        private bool childViewShown;
        private Window childView;

        public NavigationBar NavigationBar
        {
            get => navigationBar;
            set
            {
                navigationBar = value;
                OnPropertyChanged(nameof(NavigationBar));
            }
        }

        public List<ViewModel> ViewModels
        {
            get => viewModels;
            set
            {
                viewModels = value;
                OnPropertyChanged(nameof(ViewModels));
            }
        }

        public ViewModel MainViewModel
        {
            get => mainViewModel;
            set
            {
                mainViewModel = value;
                OnPropertyChanged(nameof(MainViewModel));
            }
        }

        public ViewModel CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ViewModel ChildViewModel
        {
            get => childViewModel;
            set
            {
                childViewModel = value;
                OnPropertyChanged(nameof(ChildViewModel));
            }
        }

        public Window ChildView
        {
            get => childView;
            set
            {
                childView = value;
                OnPropertyChanged(nameof(ChildView));
            }
        }

        public bool ChildViewShown
        {
            get => childViewShown;
            set
            {
                childViewShown = value;
                OnPropertyChanged(nameof(ChildViewShown));
            }
        }

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;
        public event Func<bool> BeforeUpdate;
        public event Action AfterUpdate;

        #endregion

        public Navigator() { }

        public void SetChildViewShown(bool shown) => ChildViewShown = shown;
        public void SetButtonVisibility(Type viewType, bool show) =>
            NavigationBar.stackPanel.Children.OfType<Button>().First(b => (b.CommandParameter as ViewModel).GetType() == viewType).Visibility = show
            ? Visibility.Visible
            : Visibility.Collapsed;

        public void SetMainViewModel(ViewModel vm) => MainViewModel = vm;

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(BeforeUpdate, AfterUpdate);
        public ICommand OpenChildWindow => new OpenChildWindowCommand();
        public ICommand CloseChildWindow => new CloseChildWindowCommand();

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event Func<bool> BeforeUpdate;
        public event Action AfterUpdate;

        public UpdateCurrentViewModelCommand(Func<bool> before, Action after)
        {
            BeforeUpdate = before;
            AfterUpdate = after;
        }

        public bool CanExecute(object parameter) => parameter is ViewModel vm && !vm.IsShown;

        public void Execute(object parameter)
        {
            if (!(parameter is ViewModel vm))
                throw new NotSupportedException();

            if (vm == Navigator.Instance.CurrentViewModel)
                return;

            var canUpdate = BeforeUpdate?.Invoke();
            if (!canUpdate.HasValue || canUpdate.Value)
                Navigator.Instance.CurrentViewModel = vm;
            else
                AfterUpdate?.Invoke();
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public class OpenChildWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public OpenChildWindowCommand() { }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) =>
            Application.Current.Dispatcher.Invoke(() =>
            {
                Navigator.Instance.ChildView = new PopupWindowView
                {
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    contentControl = { Content = parameter as ViewModel },
                    WindowStyle = WindowStyle.None
                };
                Navigator.Instance.ChildViewModel = parameter as ViewModel;
                Navigator.Instance.SetChildViewShown(true);
                Navigator.Instance.ChildView.Owner = Application.Current.MainWindow;
                Navigator.Instance.ChildView.ShowDialog();
            });
    }

    public class CloseChildWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public CloseChildWindowCommand() { }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) =>
            Application.Current.Dispatcher.Invoke(() =>
            {
                Navigator.Instance.ChildViewModel = null;
                Navigator.Instance.SetChildViewShown(false);
                Navigator.Instance.ChildView.Close();
            });
    }
}