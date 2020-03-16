using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace WpfApp1.Common
{
    public abstract class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
