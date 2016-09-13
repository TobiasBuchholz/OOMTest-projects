package com.tobishiba.oomtest;

import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentManager;
import android.support.v4.app.FragmentStatePagerAdapter;

/**
 * Created by tobiasbuchholz on 12/09/16
 */
public class ImageViewPagerAdapter extends FragmentStatePagerAdapter {
    public ImageViewPagerAdapter(final FragmentManager fm) {
        super(fm);
    }

    @Override
    public Fragment getItem(final int position) {
        return new ImageFragment();
    }

    @Override
    public int getCount() {
        return 20;
    }
}
