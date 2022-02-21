using MVVMFramework.ViewNavigator;

namespace MVVMFramework.ViewModels
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