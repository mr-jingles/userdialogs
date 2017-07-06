using System;
using System.ComponentModel;


namespace Plugin.UserDialogs
{
    public interface IProgressDialog : INotifyPropertyChanged, IDisposable
    {
        string Title { get; set; }
        bool IsDeterministic { get; set; }
        int PercentComplete { get; set; }
        void SetCancelButton(Action<IButton> button);
    }
}
