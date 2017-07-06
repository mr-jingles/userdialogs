using System;
using UIKit;


namespace Plugin.UserDialogs
{
    public class AlertButton : AbstractButton
    {
        readonly UIAlertAction native;


        public AlertButton(UIAlertAction native)
        {
            this.native = native;
        }


        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(this.Text):
                    //this.native.Title = this.Text;
                    break;

                case nameof(this.Enabled):
                    break;

                case nameof(this.BackgroundColor):
                    //this.native.Style = UIAlertActionStyle.Cancel;
                    break;
            }
        }
    }
}
