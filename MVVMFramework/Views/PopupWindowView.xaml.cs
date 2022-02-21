using System;
using System.Windows;

namespace MVVMFramework.Views
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class PopupWindowView : Window
    {
        public PopupWindowView()
        {
            InitializeComponent();
        }

        //SizeToContent is set to height and width and I'm using a custom chrome style for the window.
        //Because of this there's a black border on right and left. using this method to remove it
        private void Window_OnContentRendered(object sender, EventArgs e) => InvalidateVisual();
    }
}
