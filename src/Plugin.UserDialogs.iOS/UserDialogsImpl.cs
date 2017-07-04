using System;
using UIKit;


namespace Plugin.UserDialogs
{
    public class UserDialogsImpl : IUserDialogs
    {
        public IAlertDialog CreateAlert(string title)
        {
            var alert = UIAlertController.Create("", "", UIAlertControllerStyle.Alert);
            throw new NotImplementedException();
        }


        public IActionSheetDialog CreateActionSheet(string title)
        {
            var alert = UIAlertController.Create("", "", UIAlertControllerStyle.ActionSheet);
            throw new NotImplementedException();
        }


        public IToast CreateToast()
        {
            throw new NotImplementedException();
        }
    }
}