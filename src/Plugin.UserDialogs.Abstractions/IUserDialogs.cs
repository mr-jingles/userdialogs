using System;


namespace Plugin.UserDialogs
{
    public interface IUserDialogs
    {
        // TODO: loading, image, and date/time
        IAlertDialog CreateAlert(string title);
        IActionSheetDialog CreateActionSheet(string title);
        IToast CreateToast();
    }
}
