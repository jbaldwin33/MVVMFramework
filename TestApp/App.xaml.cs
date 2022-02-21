using System.Windows;
using MVVMFramework.Localization;
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
            var types = new[]
            {
                (typeof(TestViewModel), "Change Speed", true),
                (typeof(TestViewModel), "Change Speed", true),
                (typeof(TestViewModel), "Change Speed", true),
                (typeof(TestViewModel), "Change Speed", true),
                (typeof(TestViewModel), new SplitterTranslatable(), true),
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
