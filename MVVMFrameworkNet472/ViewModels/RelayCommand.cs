using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFrameworkNet472.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action execute;
        private readonly Action<object> executeWithParameter;
        private readonly Action<object, object> executeMultipleParameters;
        private readonly Func<object, Task> executeAsync;
        private readonly Func<bool> canExecute;
        private readonly Predicate<object> canExecuteWithParameter;

        public RelayCommand(Action execute) : this(execute, null) { }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object> executeWithParameter) : this(executeWithParameter, canExecute: null) { }

        public RelayCommand(Action<object> executeWithParameter, Predicate<object> canExecuteWithParameter)
        {
            this.executeWithParameter = executeWithParameter ?? throw new ArgumentNullException(nameof(executeWithParameter));
            this.canExecuteWithParameter = canExecuteWithParameter;
        }

        public RelayCommand(Action<object> executeWithParameter, Func<bool> canExecute)
        {
            this.executeWithParameter = executeWithParameter ?? throw new ArgumentNullException(nameof(executeWithParameter));
            this.canExecute = canExecute;
        }

        public RelayCommand(Action<object, object> executeMultiple) : this(executeMultiple, canExecuteWithParameter: null) { }

        public RelayCommand(Action<object, object> executeMultipleParameters, Predicate<object> canExecuteWithParameter)
        {
            this.executeMultipleParameters = executeMultipleParameters ?? throw new ArgumentNullException(nameof(executeMultipleParameters));
            this.canExecuteWithParameter = canExecuteWithParameter;
        }

        public RelayCommand(Action<object, object> executeMultipleParameters, Func<bool> canExecute)
        {
            this.executeMultipleParameters = executeMultipleParameters ?? throw new ArgumentNullException(nameof(executeMultipleParameters));
            this.canExecute = canExecute;
        }

        public RelayCommand(Func<object, Task> executeAsync, Func<bool> canExecute)
        {
            this.executeAsync = executeAsync;
            this.canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged() => CommandManager.InvalidateRequerySuggested();

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecuteWithParameter != null)
                return canExecuteWithParameter.Invoke(parameter);
            return canExecute?.Invoke() ?? true;
        }

        public async void Execute(object parameter)
        {
            if (executeWithParameter != null)
                executeWithParameter(parameter);
            else if (executeAsync != null)
                await ExecuteAsync(parameter);
            else
                execute();
        }

        public void Execute(object parameter1, object parameter2) => executeMultipleParameters(parameter1, parameter2);

        public Task ExecuteAsync(object parameter) => executeAsync(parameter);
    }
}
