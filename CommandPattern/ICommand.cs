using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //on peut aussi utiliser l'interface
    //System.Windows.Input.ICommand

    public interface ICommand<T>
    {
        void Execute(T parameter);
    }
}
