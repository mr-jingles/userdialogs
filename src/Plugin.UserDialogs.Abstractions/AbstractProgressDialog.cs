using System;


namespace Plugin.UserDialogs
{
    public abstract class AbstractProgressDialog : AbstractObservableObject, IProgressDialog
    {
        public string Title { get; set; }
        public bool IsDeterministic { get; set; }
        public int PercentComplete { get; set; }
        public abstract void SetCancelButton(Action<IButton> button);
    }
}
