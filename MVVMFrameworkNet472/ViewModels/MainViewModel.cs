using MVVMFrameworkNet472.ViewModels;
using MVVMFrameworkNet472.ViewNavigator;

namespace MVVMFrameworkNet472.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public INavigator Navigator { get; set; }

        public MainViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}
