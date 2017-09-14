using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GR.Net.Maroulis.Library;
using Android.Graphics;

namespace WebViewXamarinForms.Droid
{
    //[Activity(Label = "TESTXamarin", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    [Activity(Label = "TESTXamarin", Icon = "@drawable/icon", Theme = "@style/Theme.NoTitle", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
            
            //En caso de que se quiera fullscreen -- this.Window.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.TurnScreenOn);
           
            base.OnCreate(bundle);

            var config = new EasySplashScreen(this)
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(SplashActivity)))
                .WithSplashTimeOut(2000) //5 segundos
                //.WithBackgroundColor(Resource.Color.colorPrimaryDark)
                .WithLogo(Resource.Drawable.logow)
                ;
            //create view
            View view = config.Create();
            SetContentView(view);

            //-----------------------------

            //global::Xamarin.Forms.Forms.Init(this, bundle);

            //LoadApplication(new App());
        }
       

    }
}

