using System;
using System.ComponentModel;
using System.Drawing;


namespace Plugin.UserDialogs
{
    public interface IToast : INotifyPropertyChanged, IDisposable
    {
        string Text { get; set; }
        Color? TextColor { get; set; }
        Color? BackgroundColor { get; set; }
        bool IsShowing { get; set; }

        Button Button { get; set; }
    }
}
