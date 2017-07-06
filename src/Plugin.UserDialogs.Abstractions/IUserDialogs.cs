using System;


namespace Plugin.UserDialogs
{
    public interface IUserDialogs
    {
        // TODO: date/time
        IAlertDialog CreateAlert();
        IActionSheetDialog CreateActionSheet();
        IToast CreateToast();
        IProgressDialog CreateProgress();
    }
}
