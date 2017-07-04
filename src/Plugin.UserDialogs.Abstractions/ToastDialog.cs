using System;
using Splat;


namespace Plugin.UserDialogs
{
    public class ToastDialog
    {
        public Label Message { get; set; }
        public IBitmap Icon { get; set; }
        public IButton Button { get; set; }
    }
}
