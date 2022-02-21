using MVVMFramework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMFramework.ViewNavigator
{
    public interface INavigator
    {
        NavigationBar NavigationBar { get; set; }
        List<ViewModel> ViewModels { get; set; }
        ViewModel MainViewModel { get; set; }
        ViewModel CurrentViewModel { get; set; }
        ViewModel ChildViewModel { get; set; }
        Window ChildView { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
        ICommand OpenChildWindow { get; }
        ICommand CloseChildWindow { get; }
        void SetChildViewShown(bool shown);
        void SetButtonVisibility(Type viewType, bool show);
        void SetMainViewModel(ViewModel viewModel);
    }
}
