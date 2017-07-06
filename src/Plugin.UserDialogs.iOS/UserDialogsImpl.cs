using System;


namespace Plugin.UserDialogs
{
    public class UserDialogsImpl : AbstractUserDialogs
    {
        public override IAlertDialog CreateAlert() => new AlertDialog();
        public override IActionSheetDialog CreateActionSheet() => null;
        public override IToast CreateToast() => null;
        public override IProgressDialog CreateProgress() => null;
    }
}