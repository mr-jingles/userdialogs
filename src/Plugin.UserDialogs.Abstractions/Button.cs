using System;
using System.Windows.Input;


namespace Plugin.UserDialogs
{
    public class Button : Label
    {
        public ICommand Command { get; set; }
    }
}
