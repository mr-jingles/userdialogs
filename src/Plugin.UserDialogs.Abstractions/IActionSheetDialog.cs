using System;


namespace Plugin.UserDialogs
{
    public interface IActionSheetDialog : IDialog
    {
        IActionButton AddButton();
    }
}
