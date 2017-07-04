using System;
using System.Windows.Input;


namespace Plugin.UserDialogs
{
    public abstract class AbstractButton : AbstractLabel, IButton
    {
        public ICommand Command { get; set; }
    }
}
