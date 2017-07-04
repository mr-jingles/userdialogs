using System;


namespace Plugin.UserDialogs
{
    public abstract class AbstractDialog : AbstractObservableObject, IDialog
    {
        ~AbstractDialog() => this.Dispose(false);


        public virtual void Dispose() => this.Dispose(true);
        protected virtual void Dispose(bool disposing) {}


        public bool IsShowing { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsCancellable { get; set; }

        // TODO: need a create function, getter may not be available
        public IButton PositiveButton { get; set; }
        public IButton NegativeButton { get; set; }
        public IButton NeutralButton { get; set; }
    }
}
