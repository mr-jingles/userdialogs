using System;


namespace Plugin.UserDialogs
{
    public interface IAlertDialog : IDialog
    {
        void AddTextBox(Action<ITextBox> textbox);
    }
}
