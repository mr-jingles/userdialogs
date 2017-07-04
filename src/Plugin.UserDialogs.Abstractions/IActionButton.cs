using System;
using Splat;


namespace Plugin.UserDialogs
{
    public interface IActionButton : IButton
    {
        IBitmap Icon { get; set; }
    }
}
