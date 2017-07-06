using System;
#if __IOS__
using UIKit;
#endif
#if __ANDROID__
using Android.App;
using Acr.Support.Android;
#endif

namespace Plugin.UserDialogs
{

    public static class CrossUserDialogs
    {

#if __ANDROID__

        /// <summary>
        /// Initialize android user dialogs
        /// </summary>
        public static void Init(Func<Activity> topActivityFactory)
        {
            //Instance = new UserDialogsImpl(topActivityFactory);
        }


        /// <summary>
        /// Initialize android user dialogs
        /// </summary>
        public static void Init(Application app)
        {
            ActivityLifecycleCallbacks.Register(app);
            Init(() => ActivityLifecycleCallbacks.CurrentTopActivity);
        }


        /// <summary>
        /// Initialize android user dialogs
        /// </summary>
        public static void Init(Activity activity)
        {
            ActivityLifecycleCallbacks.Register(activity);
            Init(() => ActivityLifecycleCallbacks.CurrentTopActivity);
        }
#elif __IOS__

        /// <summary>
        /// OPTIONAL: Initialize iOS user dialogs with your top viewcontroll function
        /// </summary>
        public static void Init(Func<UIViewController> viewControllerFunc)
        {
            //Instance = new UserDialogsImpl(viewControllerFunc);
        }

#endif

        static IUserDialogs current;
        public static IUserDialogs Current
        {
            get
            {
#if BAIT
                if (current == null)
                    throw new ArgumentException("[Plugin.UserDialogs] This is the bait library, not the platform library.  You must install the nuget package in your main executable/application project");
#elif __ANDROID__
                if (current == null)
                    throw new ArgumentException("[Plugin.UserDialogs] In android, you must call UserDialogs.Init(Activity) from your first activity OR UserDialogs.Init(App) from your custom application OR provide a factory function to get the current top activity via UserDialogs.Init(() => supply top activity)");
#else
                //current = current ?? new UserDialogsImpl();
#endif
                return current;
            }
            set => current = value;
        }
    }
}
