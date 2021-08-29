﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVMFramework.Controls;
using MVVMFramework.ViewModels;
using MVVMFramework.ViewNavigator;
using MVVMFramework.Views;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ViewBaseControl
    {
        public MainWindow() : base(Navigator.Instance.CurrentViewModel)
        {
            InitializeComponent();
        }

        private void Vm_ShowMessageBoxEventHandler(object sender, MessageBoxEventArgs e)
        {
            e.Result = MessageBox.Show(e.Message, e.MessageType.ToString(), e.Button, e.Image);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("message");
        }
        
    }
}
