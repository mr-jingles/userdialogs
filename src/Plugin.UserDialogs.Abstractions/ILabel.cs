using System;
using System.ComponentModel;
using System.Drawing;


namespace Plugin.UserDialogs
{
    public interface ILabel : INotifyPropertyChanged
    {
        string Text { get; set; }
        Color? TextColor { get; set; }
        Color? BackgroundColor { get; set; }
    }
}
