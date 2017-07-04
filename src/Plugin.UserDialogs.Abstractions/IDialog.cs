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

        Button PositiveButton { get; set; }
        Button NegativeButton { get; set; }
        Button NeutralButton { get; set; }
    }
}
