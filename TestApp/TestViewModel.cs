using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using MVVMFrameworkNet472;
using MVVMFrameworkNet472.Localization;
using MVVMFrameworkNet472.ViewModels;
using MVVMFrameworkNet472.ViewNavigator;
using TestApp.ViewModels;
using Application = System.Windows.Forms.Application;
using Timer = System.Windows.Forms.Timer;

namespace TestApp
{
    public class TestViewModel : ViewModel
    {
        public static string Title => "Test";
        private int myVar;

        public int MyProperty
        {
            get => myVar;
            set => SetProperty(ref myVar, value);
        }

        private bool myBool;

        public bool MyBool
        {
            get => myBool;
            set => SetProperty(ref myBool, value);
        }

        private ProgressBarViewModel progressBarViewModel;
        public ProgressBarViewModel ProgressBarViewModel
        {
            get => progressBarViewModel;
            set => SetProperty(ref progressBarViewModel, value);
        }

        public TestViewModel()
        {
            MyBool = false;
        }

        public string ButtonLabel => "Click me";
        private RelayCommand showMessageCommand;

        public RelayCommand ShowMessageCommand => showMessageCommand ?? (showMessageCommand = new RelayCommand(ShowMessageExecute, () => true));


        private void ShowMessageExecute()
        {

            ProgressBarViewModel = new ProgressBarViewModel(15);
            Navigator.Instance.OpenChildWindow.Execute(ProgressBarViewModel);
        }

        public void wait(int milliseconds)
        {
            var timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
