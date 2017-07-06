using System;
using UIKit;


namespace Plugin.UserDialogs
{
    public class UserDialogsImpl : IUserDialogs
    {
        public IAlertDialog CreateAlert(string title) => new AlertDialog();


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