using System;


namespace Plugin.UserDialogs
{
    public class UserDialogsImpl : IUserDialogs
    {
        public IAlertDialog CreateAlert(string title)
        {
            throw new NotImplementedException();
        }


        public IActionSheetDialog CreateActionSheet(string title)
        {
            throw new NotImplementedException();
        }


        public IToast CreateToast()
        {
            throw new NotImplementedException();
        }
    }
}