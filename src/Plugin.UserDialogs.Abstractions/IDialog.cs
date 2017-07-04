using System;
using System.ComponentModel;


namespace Plugin.UserDialogs
{
    public interface IDialog : INotifyPropertyChanged, IDisposable
    {
        bool IsShowing { get; set; }
        string Title { get; set; }
        string Message { get; set; }

        bool IsCancellable { get; set; }

        IButton PositiveButton { get; set; }
        IButton NegativeButton { get; set; }
        IButton NeutralButton { get; set; }
    }
}
