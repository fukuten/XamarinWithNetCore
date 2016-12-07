using Android.App;
using Android.Widget;
using Android.OS;

namespace XamarinWithNetCore.Android
{
    [Activity(Label = "XamarinWithNetCore.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var textView = FindViewById<TextView>(Resource.Id.textView1);

            var button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += (sender, e) =>
            {
                //textView.Text = 
            };

            var button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += (sender, e) =>
            {
                //textView.Text = 
            };

            var button3 = FindViewById<Button>(Resource.Id.button3);
            button3.Click += (sender, e) =>
            {
                //textView.Text = 
            };
        }
    }
}

