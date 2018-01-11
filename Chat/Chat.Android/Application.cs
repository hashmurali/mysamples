using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Chat.Interfaces;
using Chat.Utility;

namespace Chat.Droid
{
    [Application]
    public class Application : Android.App.Application
    {
        //This constructor is required
        public Application(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
        public override void OnCreate()
        {
            base.OnCreate();
            //IoC Registration here
        }
    }
}