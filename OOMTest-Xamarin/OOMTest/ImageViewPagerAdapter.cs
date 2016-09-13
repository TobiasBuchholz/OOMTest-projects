using System;
using Android.Support.V4.App;
namespace OOMTest
{
	public class ImageViewPagerAdapter : FragmentStatePagerAdapter
	{
		public ImageViewPagerAdapter(FragmentManager fm) 
			: base(fm)
		{
		}

		public override int Count {
			get {
				return 20;
			}
		}

		public override Fragment GetItem(int position)
		{
			return new ImageFragment();
		}
	}
}

