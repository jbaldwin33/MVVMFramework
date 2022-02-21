using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFramework.ViewModels
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }

    public class AsyncCommand : IAsyncCommand
    {
        private readonly Func<Task> executeAsync;
        private Func<bool> canExecute;

        public AsyncCommand(Func<Task> execute, Func<bool> canExecute)
        {
            executeAsync = execute;
            this.canExecute = canExecute;
        }

        public Task ExecuteAsync(object parameter)
        {
            return executeAsync();
        }

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke() ?? true;
        }

        public async void Execute(object parameter) => await ExecuteAsync(parameter);


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        protected void RaiseCanExecuteChanged() => CommandManager.InvalidateRequerySuggested();
    }
}
