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


        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(this.Title):
                    this.Controller.Title = this.Title;
                    break;

                case nameof(this.Message):
                    this.Controller.Message = this.Message;
                    break;

                case nameof(this.IsCancellable):
                    break;
            }
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
/*
            UIAlertController alert = null;
            var app = UIApplication.SharedApplication;
            app.InvokeOnMainThread(() =>
            {
                alert = alertFunc();
                var top = this.viewControllerFunc();
                if (alert.PreferredStyle == UIAlertControllerStyle.ActionSheet && UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
                {
                    var x = top.View.Bounds.Width / 2;
                    var y = top.View.Bounds.Bottom;
                    var rect = new CGRect(x, y, 0, 0);

                    alert.PopoverPresentationController.SourceView = top.View;
                    alert.PopoverPresentationController.SourceRect = rect;
                    alert.PopoverPresentationController.PermittedArrowDirections = UIPopoverArrowDirection.Unknown;
                }
                top.PresentViewController(alert, true, null);
            });
            return new DisposableAction(() =>
            {
                try
                {
                    app.InvokeOnMainThread(() => alert.DismissViewController(true, null));
                }
                catch { }
            });
        }
     */