using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoWpfCommandPattern.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void Set<T>(ref T? field, T? value, [CallerMemberName] string? propertyName = null)
        {
            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }

        protected void RaisePropertyChanged([CallerMemberName]string? propertyName = null)
        {
            PropertyChangedEventHandler? propertyChanged = PropertyChanged;
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}