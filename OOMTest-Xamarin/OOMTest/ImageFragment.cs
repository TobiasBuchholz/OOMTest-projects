
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace OOMTest
{
	public class ImageFragment : Fragment
	{
		private ImageView mImageView;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var layout = (RelativeLayout) inflater.Inflate(Resource.Layout.fragment_image, container, false);

			mImageView = layout.FindViewById<ImageView>(Resource.Id.image_view);
			//using(var bitmap = Bitmap.CreateBitmap(2000, 2000, Bitmap.Config.Argb8888)) {
			//	bitmap.EraseColor(Color.Red);
			//	mImageView.SetImageBitmap(bitmap);
			//}

			var bitmap = Bitmap.CreateBitmap(2000, 2000, Bitmap.Config.Argb8888);
			bitmap.EraseColor(Color.Red);
			mImageView.SetImageBitmap(bitmap);

			return layout;
		}

		public override void OnStop()
		{
			base.OnStop();
			//((BitmapDrawable) mImageView.Drawable).Bitmap.Recycle();
			//((BitmapDrawable) mImageView.Drawable).Bitmap.Dispose();
			//mImageView.SetImageBitmap(null);
			//mImageView.Dispose();
			GC.Collect();
		}
	}
}

