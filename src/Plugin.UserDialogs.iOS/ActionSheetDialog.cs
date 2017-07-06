using System;
using UIKit;

namespace Plugin.UserDialogs
{
    public class ActionSheetDialog : AbstractAlertDialog, IActionSheetDialog
    {
        public ActionSheetDialog() : base(UIAlertControllerStyle.ActionSheet)
        {
        }


        public void CreateAction(Action<IButton> actionButton)
        {
            var native = UIAlertAction.Create("", UIAlertActionStyle.Default, x => { });

            this.Controller.AddAction(UIAlertAction.Create("", UIAlertActionStyle.Default, x => { }));
        }
    }
}
