using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace Journalife.Droid
{
    [Activity(Label = "Journalife", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            string FileName = "diary_db.sqlite";
            string FileLocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string FullPath = Path.Combine(FileLocation, FileName);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(FullPath));
        }
    }
}