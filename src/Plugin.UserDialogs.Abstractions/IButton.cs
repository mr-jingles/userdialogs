using System;
using System.Windows.Input;


namespace Plugin.UserDialogs
{
    public interface IButton : ILabel
    {
        ICommand Command { get; set; }
    }
}
