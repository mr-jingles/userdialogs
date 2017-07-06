using System;
using System.ComponentModel;


namespace Plugin.UserDialogs
{
    public interface IProgressDialog : INotifyPropertyChanged, IDisposable
    {
        void SetCancelButton(Action<IButton> button);
    }
}
