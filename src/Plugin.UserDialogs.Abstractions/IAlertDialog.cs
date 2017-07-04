using System;


namespace Plugin.UserDialogs
{
    public interface IAlertDialog : IDialog
    {
        void AddTextBox(TextBox textBox);
    }
}
