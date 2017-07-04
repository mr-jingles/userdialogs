using System;
using System.Drawing;


namespace Plugin.UserDialogs
{
    public class TextBox : Label
    {
        public KeyboardType Keyboard { get; set; } = KeyboardType.Default;


        bool enabled;
        public bool Enabled
        {
            get => this.enabled;
            set => this.Set(ref this.enabled, value);
        }


        Color? borderColor;
        public Color? BorderColor
        {
            get => this.borderColor;
            set => this.Set(ref this.borderColor, value);
        }


        //public Action OnFocus { get; set; }
        //public Action OnLostFocus { get; set; }
        //public void Focus() {}

        // OnFocus
        // Focus
    }
}
