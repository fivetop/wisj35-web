﻿using Android.App;
using Android.Runtime;

namespace HybridClient1
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => Startup.Main();
    }
}