using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace iFasting
{
    [Activity(Label = "iFasting", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += (s, e) =>
             {
                 Intent nextActivity = new Intent(this, typeof(calendarActivity));
                 StartActivity(nextActivity);

             };
            var button2 = FindViewById<Button>(Resource.Id.button1);
            button2.Click += (s, e) =>
            {
                Intent nextActivity = new Intent(this, typeof(manageFastActivity));
                StartActivity(nextActivity);

            };

        }
    }
}

