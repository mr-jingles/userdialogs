using System;


namespace Plugin.UserDialogs
{
    public interface IAlertDialog : IDialog
    {
        ITextBox AddTextBox();
    }
}
