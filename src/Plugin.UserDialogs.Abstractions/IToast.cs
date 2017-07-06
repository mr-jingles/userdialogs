using System;
using System.ComponentModel;
using System.Drawing;


namespace Plugin.UserDialogs
{
    public interface IToast : INotifyPropertyChanged, IDisposable
    {
        void Show();
        void Hide();
        bool IsVisible { get; }

        ILabel Message { get; set; }
        TimeSpan? VisibleDuration { get; set; }

        void SetButton(Action<IButton> button);
    }
}
