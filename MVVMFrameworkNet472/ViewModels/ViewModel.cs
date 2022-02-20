using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MVVMFrameworkNet472.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<MessageBoxEventArgs> ShowMessageBoxEventHandler;
        private bool isShown;

        public bool IsShown
        {
            get => isShown;
            set => SetProperty(ref isShown, value);
        }

        public ViewModel() { }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetProperty<T>(ref T fieldReference, T newValue, string propertyName = null)
        {
            var valueIsEqual = Equals(fieldReference, newValue);
            if (valueIsEqual)
                return false;

            fieldReference = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void ShowMessage(MessageBoxEventArgs e) => ShowMessageBoxEventHandler?.Invoke(this, e);
        protected void ShowMessage(string message) => ShowMessageBoxEventHandler?.Invoke(this, new MessageBoxEventArgs(message));

        public virtual void OnLoaded() { }

        public virtual void OnUnloaded() { }
    }

    public class MessageBoxEventArgs : EventArgs
    {
        public enum MessageTypeEnum
        {
            Information,
            Question,
            Warning,
            Error
        }
        public string Message { get; set; }
        public MessageTypeEnum MessageType { get; set; }
        public MessageBoxButton Button { get; set; }
        public MessageBoxImage Image { get; set; }
        public MessageBoxResult Result { get; set; }
        internal MessageBoxEventArgs(string message) : this(message, MessageTypeEnum.Information, MessageBoxButton.OK, MessageBoxImage.Information) { }

        public MessageBoxEventArgs(string message, MessageTypeEnum type, MessageBoxButton button, MessageBoxImage image)
        {
            Message = message;
            MessageType = type;
            Button = button;
            Image = image;
        }
    }
}
