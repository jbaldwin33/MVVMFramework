using MVVMFrameworkNet472.ViewNavigator;

namespace MVVMFrameworkNet472.ViewModels
{
    public class PopupWindowViewModel
    {
        public INavigator Navigator { get; set; }
        public PopupWindowViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}