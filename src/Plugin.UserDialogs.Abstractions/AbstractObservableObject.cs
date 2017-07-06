using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Plugin.UserDialogs
{
    public abstract class AbstractObservableObject : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        protected virtual bool Set<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }


        ~AbstractObservableObject() => this.Dispose(false);


        public virtual void Dispose() => this.Dispose(true);
        protected virtual void Dispose(bool disposing) {}
    }
}
