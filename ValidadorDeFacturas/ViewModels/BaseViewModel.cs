using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ValidadorDeFacturas.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            var changed = PropertyChanged;

            changed?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
