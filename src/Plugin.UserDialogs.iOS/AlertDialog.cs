using System;
using UIKit;


namespace Plugin.UserDialogs
{
    public class AlertDialog : AbstractAlertDialog, IAlertDialog
    {
        public AlertDialog() : base(UIAlertControllerStyle.Alert)
        {
        }


        public void AddTextBox(Action<ITextBox> textbox) => this.Controller.AddTextField(txt =>
        {
            var tb = new TextBox(txt);
            textbox(tb);
        });
    }
}
