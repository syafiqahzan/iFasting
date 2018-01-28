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



namespace iFasting
{
    [Activity(Label = "calendarActivity")]
    public class calendarActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.calendar);
            var calendarView = FindViewById<CalendarView>(Resource.Id.calendarView);
            var txtDisplay = FindViewById<TextView>(Resource.Id.textDisplay);

            txtDisplay.Text = "Date: ";
            calendarView.DateChange += (s, e) =>
            {
                int day = e.DayOfMonth;
                int month = e.Month;
                int year = e.Year;
                txtDisplay.Text = "Date: " + day + "/" + month + "/" + year;
            };

        }
    }
}