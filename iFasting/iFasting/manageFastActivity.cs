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
    [Activity(Label = "manageFastActivity")]
    public class manageFastActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.manageFast);


            var spinnerOne = FindViewById<Spinner>(Resource.Id.spinner1);
            spinnerOne.ItemSelected += (a, f) =>
            {
                string firstItem = spinnerOne.SelectedItem.ToString();
                if (firstItem.Equals(spinnerOne.SelectedItem.ToString()))
                {
                    //To do when first item is selected

                }

                else
                {
                    Toast.MakeText(this, "You have selected:" + f.Parent.GetItemAtPosition(f.Position).ToString(), ToastLength.Short).Show();

                }

            };
        }

        
    }
}