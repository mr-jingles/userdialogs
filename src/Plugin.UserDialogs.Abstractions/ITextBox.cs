using System;
using System.Drawing;


namespace Plugin.UserDialogs
{
    public interface ITextBox : ILabel
    {
        KeyboardType Keyboard { get; set; }
        bool Enabled { get; set; }
        Color? BorderColor { get; set; }
    }
}
