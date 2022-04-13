using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Command<T> : ICommand<T>
    {
        private readonly Action<T> _execute;

        public Command(Action<T> execute)
        {
            _execute = execute ?? throw new ArgumentNullException();
        }

        public void Execute(T parameter)
        {
            _execute(parameter);
        }
    }
}
