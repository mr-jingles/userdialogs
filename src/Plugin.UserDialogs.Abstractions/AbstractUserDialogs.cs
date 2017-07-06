using System;


namespace Plugin.UserDialogs
{
    public abstract class AbstractUserDialogs : IUserDialogs
    {
        public abstract IAlertDialog CreateAlert();
        public abstract IActionSheetDialog CreateActionSheet();
        public abstract IToast CreateToast();
        public abstract IProgressDialog CreateProgress();
    }
}
