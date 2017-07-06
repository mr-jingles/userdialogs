using System;


namespace Plugin.UserDialogs
{
    public abstract class AbstractDialog : AbstractObservableObject, IDialog
    {
        string title;
        public string Title
        {
            get => this.title;
            set => this.Set(ref this.title, value);
        }


        string message;
        public string Message
        {
            get => this.message;
            set => this.Set(ref this.message, value);
        }


        bool cancellable;
        public bool IsCancellable
        {
            get => this.cancellable;
            set => this.Set(ref this.cancellable, value);
        }


        public abstract bool IsVisible { get; }

        public abstract void Show();
        public abstract void Hide();

        public abstract void SetPositiveButton(Action<IButton> button);
        public abstract void SetNegativeButton(Action<IButton> button);
        public abstract void SetNeutralButton(Action<IButton> button);
    }
}
