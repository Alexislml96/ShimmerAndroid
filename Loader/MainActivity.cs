using System;
using Android.Animation;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Facebook.Shimmer;
using Java.Lang;

namespace Loader
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ShimmerFrameLayout mShimmerViewContainer;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            mShimmerViewContainer = FindViewById<ShimmerFrameLayout>(Resource.Id.shimmer_loader);
            mShimmerViewContainer.StartShimmer();
        }
    }
}


