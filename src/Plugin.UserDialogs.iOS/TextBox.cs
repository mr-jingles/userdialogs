using System;
using Splat;
using UIKit;


namespace Plugin.UserDialogs
{
    public class TextBox : AbstractTextBox
    {
        readonly UITextField native;


        public TextBox(UITextField native)
        {
            this.native = native;
        }


        public override void Dispose()
        {
            base.Dispose();
        }


        protected override void OnPropertyChanged(string propertyName = null)
        {
            // TODO: swap to UI thread?
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(this.Text):
                    this.native.Text = this.Text;
                    break;

                case nameof(this.TextColor):
                    this.native.TextColor = this.TextColor.Value.ToNative();
                    break;

                case nameof(this.Enabled):
                    this.native.Enabled = this.Enabled;
                    break;

                case nameof(this.BorderColor):
                    //this.native.BorderStyle = UITextBorderStyle.Line;
                    break;

                case nameof(this.BackgroundColor):
                    break;

                case nameof(this.Keyboard):
                    //this.native.KeyboardType =
                    break;
            }
        }
    }
}
