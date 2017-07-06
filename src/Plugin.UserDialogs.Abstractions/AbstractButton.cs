using System;
using System.Windows.Input;


namespace Plugin.UserDialogs
{
    public abstract class AbstractButton : AbstractLabel, IButton
    {
        bool enabled;
        public bool Enabled
        {
            get => this.enabled;
            set => this.Set(ref this.enabled, value);
        }


        public ICommand Command { get; set; }
    }
}
