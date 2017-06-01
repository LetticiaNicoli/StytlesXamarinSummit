
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace App_Hello.Droid
{
    [Activity(Label = "App_Hello", Icon = "@drawable/egg", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App_Hello.App());
        }
    }
}

