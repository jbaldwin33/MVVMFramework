﻿using System.Windows;
using MVVMFramework.Localization;
using MVVMFramework.ViewModels;
using MVVMFramework.Views;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //TranslatableClass.Instance.CurrentCultureInfo = CultureInfo.GetCultureInfo("ja-JP");
            var types = new(ViewModel, bool)[]
            {
                (new TestViewModel(), true),
                (new TestViewModel(), true),
                (new TestViewModel(), true),
                (new TestViewModel(), true),
                (new TestViewModel(), true),
            };
            var window = new BaseWindowView(types)
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Show();
            base.OnStartup(e);
        }
    }
}
