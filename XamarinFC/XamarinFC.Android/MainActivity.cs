using Android.App;
using Android.Content.PM;
using Android.OS;
using Gcm.Client;
using XamarinFC.Droid.Services;

namespace XamarinFC.Droid
{
    [Activity(Label = "XamarinFC", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        // Create a new instance field for this activity.
        static MainActivity _instance = null;

        // Return the current activity instance.
        public static MainActivity CurrentActivity
        {
            get { return _instance; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            // Set the current instance of MainActivity
            _instance = this;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            try
            {
                // Check to ensure everything's set up right
                GcmClient.CheckDevice(this);
                GcmClient.CheckManifest(this);

                // Register for push notifications
                System.Diagnostics.Debug.WriteLine("Registering...");
                GcmClient.Register(this, PushHandlerBroadcastReceiver.SENDER_IDS);
            }
            catch (System.Exception e)
            {
                CreateAndShowDialog(e.Message, "Error");
            }
        }

        private void CreateAndShowDialog(string message, string title)
        {
            AlertDialog.Builder buider = new AlertDialog.Builder(this);
            buider.SetMessage(message);
            buider.SetTitle(title);
            buider.Create().Show();
        }
    }
}

