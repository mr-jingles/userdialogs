using System;
using System.ComponentModel;


namespace Plugin.UserDialogs
{
    public interface IDialog : INotifyPropertyChanged, IDisposable
    {
        bool IsVisible { get; }
        string Title { get; set; }
        string Message { get; set; }
        bool IsCancellable { get; set; }

        void Show();
        void Hide();

        void SetPositiveButton(Action<IButton> button);
        void SetNegativeButton(Action<IButton> button);
        void SetNeutralButton(Action<IButton> button);
    }
}
