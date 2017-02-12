using System;
using System.Windows.Input;

namespace BasicApplication.Utility
{
    public class CustomCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        /// <summary>
        /// Not yet clear about what exactly is this.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested += value;
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
