using System;
using System.Windows.Input;


namespace Plugin.UserDialogs
{
    public interface IButton : ILabel
    {
        bool Enabled { get; set; }
        ICommand Command { get; set; }
    }
}
