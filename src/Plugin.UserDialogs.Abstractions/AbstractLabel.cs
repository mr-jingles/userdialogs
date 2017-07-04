using System;
using System.Drawing;


namespace Plugin.UserDialogs
{
    public abstract class AbstractLabel : AbstractObservableObject, ILabel
    {
        //// TODO: from Html?
        string text;
        public string Text
        {
            get => this.text;
            set => this.Set(ref this.text, value);
        }


        Color? textColor;
        public Color? TextColor
        {
            get => this.textColor;
            set => this.Set(ref this.textColor, value);
        }


        Color? bgColor;
        public Color? BackgroundColor
        {
            get => this.bgColor;
            set => this.Set(ref this.bgColor, value);
        }
    }
}
