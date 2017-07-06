using System;


namespace Plugin.UserDialogs
{
    public class UserDialogsImpl : AbstractUserDialogs
    {
        public override IAlertDialog CreateAlert()
        {
            throw new NotImplementedException();
        }

        public override IActionSheetDialog CreateActionSheet()
        {
            throw new NotImplementedException();
        }

        public override IToast CreateToast()
        {
            throw new NotImplementedException();
        }

        public override IProgressDialog CreateProgress()
        {
            throw new NotImplementedException();
        }
    }
}