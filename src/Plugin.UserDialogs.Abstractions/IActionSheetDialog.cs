using System;


namespace Plugin.UserDialogs
{
    public interface IActionSheetDialog : IDialog
    {
        void CreateAction(Action<IButton> actionButton);
    }
}
