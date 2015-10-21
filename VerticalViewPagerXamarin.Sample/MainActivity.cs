using System.Collections.Generic;
using Android.App;
using Android.OS;
using Fragment = Android.Support.V4.App.Fragment;
using Android.Support.V7.App;
using ME.Kaelaela.Verticalviewpager;

namespace VerticalViewPagerXamarin.Sample
{
    [Activity (
        Label = "VerticalViewPagerXamarin.Sample", 
        MainLauncher = true, 
        Theme = "@style/AppTheme",
        Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            InitViewPager ();
        }

        private void InitViewPager() 
        {
            VerticalViewPager viewPager = FindViewById<VerticalViewPager>(Resource.Id.vertical_viewpager);

            //viewPager.SetPageTransformer(false, new ZoomOutTransformer());
            //viewPager.SetPageTransformer(true, new StackTransformer());
            string title = "ContentFragment";

            var adapter = new ContentFragmentAdapter (SupportFragmentManager, new List<Fragment> (){ 
                ContentFragment.NewInstance(title, 1),
                ContentFragment.NewInstance(title, 2),
                ContentFragment.NewInstance(title, 3),
                ContentFragment.NewInstance(title, 4),
                ContentFragment.NewInstance(title, 5)
            });

            viewPager.Adapter = adapter;

            //If you setting other scroll mode, the scrolled fade is shown from either side of display.
            viewPager.OverScrollMode = Android.Views.OverScrollMode.Never;
        }
    }
}


