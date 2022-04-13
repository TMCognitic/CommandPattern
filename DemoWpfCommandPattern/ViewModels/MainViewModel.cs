using DemoWpfCommandPattern.Commands;
using DemoWpfCommandPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoWpfCommandPattern.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private double _x, _y;

        private ICommand? _moveCommand;

        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                Set(ref _x, value);
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                Set(ref _y, value);
            }
        }

        public ICommand MoveCommand
        {
            get { return _moveCommand ??= new Command<Direction>(Move, null); }
        }

        private void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    Y--;
                    break;
                case Direction.South:
                    Y++;
                    break;
                case Direction.West:
                    X--;
                    break;
                case Direction.East:
                    X++;
                    break;
            }
        }
    }
}
