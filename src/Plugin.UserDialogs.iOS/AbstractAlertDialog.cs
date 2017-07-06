using System;
using UIKit;


namespace Plugin.UserDialogs
{
    public abstract class AbstractAlertDialog : AbstractDialog
    {
        protected AbstractAlertDialog(UIAlertControllerStyle style)
        {
            // TODO: needs to be created on UI thread
            this.Controller = UIAlertController.Create("", "", style);
        }


        protected UIAlertController Controller { get; }


        bool visible;
        public override bool IsVisible => this.visible;


        public override void Show()
        {
            this.visible = true;
            this.Controller.ShowViewController(null, null);
        }


        public override void Hide()
        {
            this.visible = false;
            this.Controller.DismissViewController(true, null);
        }


        public override void SetPositiveButton(Action<IButton> button)
        {
            var action = UIAlertAction.Create("", UIAlertActionStyle.Default, x => {});

            this.Controller.AddAction(action);
        }


        public override void SetNegativeButton(Action<IButton> button)
        {
            var action = UIAlertAction.Create("", UIAlertActionStyle.Destructive, x => {});
            throw new NotImplementedException();
        }

        public override void SetNeutralButton(Action<IButton> button)
        {
            var action = UIAlertAction.Create("", UIAlertActionStyle.Cancel, x => {});
            throw new NotImplementedException();
        }
    }
}
