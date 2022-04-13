using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoWpfCommandPattern.Commands
{
    public class Command<T> : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { if (_canExecute is not null) CommandManager.RequerySuggested += value; }
            remove { if (_canExecute is not null) CommandManager.RequerySuggested -= value; }
        }

        private readonly Action<T?> _execute;
        private readonly Func<T?, bool>? _canExecute;

        public Command(Action<T?> execute, Func<T?, bool>? canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute)); ;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return (_canExecute is null) ? true : _canExecute((T?)parameter);
        }

        public void Execute(object? parameter)
        {
            _execute((T?)parameter);
        }
    }
}
