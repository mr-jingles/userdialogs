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
            this.native.AddTarget((sender, e) => this.Text = this.native.Text, UIControlEvent.EditingChanged);
        }

        /*
                if (config.MaxLength != null)
                {
                    txt.ShouldChangeCharacters = (field, replacePosition, replacement) =>
                    {
                        var updatedText = new StringBuilder(field.Text);
                        updatedText.Remove((int)replacePosition.Location, (int)replacePosition.Length);
                        updatedText.Insert((int)replacePosition.Location, replacement);
                        return updatedText.ToString().Length <= config.MaxLength.Value;
                    };
                }

                if (config.OnTextChanged != null)
                {
                    txt.AddTarget((sender, e) => ValidatePrompt(txt, btnOk, config), UIControlEvent.EditingChanged);
                    ValidatePrompt(txt, btnOk, config);
                }
             */

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
                    this.SetInputType(this.native, this.Keyboard);
                    break;
            }
        }


        protected virtual void SetInputType(UITextField txt, KeyboardType keyboardType)
        {
            switch (keyboardType)
            {
                case KeyboardType.DecimalNumber:
                    txt.KeyboardType = UIKeyboardType.DecimalPad;
                    break;

                case KeyboardType.Email:
                    txt.KeyboardType = UIKeyboardType.EmailAddress;
                    break;

                case KeyboardType.Name:
                    break;

                case KeyboardType.Number:
                    txt.KeyboardType = UIKeyboardType.NumberPad;
                    break;

                case KeyboardType.NumericPassword:
                    txt.SecureTextEntry = true;
                    txt.KeyboardType = UIKeyboardType.NumberPad;
                    break;

                case KeyboardType.Password:
                    txt.SecureTextEntry = true;
                    break;

                case KeyboardType.Phone:
                    txt.KeyboardType = UIKeyboardType.PhonePad;
                    break;

                case KeyboardType.Url:
                    txt.KeyboardType = UIKeyboardType.Url;
                    break;
            }
        }
    }
}
