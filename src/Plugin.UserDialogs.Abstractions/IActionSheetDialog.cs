using System;


namespace Plugin.UserDialogs
{
    public interface IActionSheetDialog : IDialog
    {
        void AddButton(ActionButton button);
    }
}
