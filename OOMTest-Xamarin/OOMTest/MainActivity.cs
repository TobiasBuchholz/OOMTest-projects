using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.View;

namespace OOMTest
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

			var viewPager = FindViewById<ViewPager>(Resource.Id.activity_main_view_pager);
			var adapter = new ImageViewPagerAdapter(SupportFragmentManager);
			viewPager.Adapter = adapter;
		}
	}
}


