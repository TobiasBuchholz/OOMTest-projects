package com.tobishiba.oomtest;

import android.graphics.Bitmap;
import android.graphics.Color;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.RelativeLayout;

/**
 * Created by tobiasbuchholz on 12/09/16
 */
public class ImageFragment extends Fragment {
    private ImageView mImageView;

    @Nullable
    @Override
    public View onCreateView(final LayoutInflater inflater, @Nullable final ViewGroup container, @Nullable final Bundle savedInstanceState) {
        final RelativeLayout layout = (RelativeLayout) inflater.inflate(R.layout.fragment_image, container, false);

        mImageView = (ImageView) layout.findViewById(R.id.image_view);
        final Bitmap bitmap = Bitmap.createBitmap(2000, 2000, Bitmap.Config.ARGB_8888);
        bitmap.eraseColor(Color.RED);
        mImageView.setImageBitmap(bitmap);

        return layout;
    }
}
