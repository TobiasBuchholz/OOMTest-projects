package com.tobishiba.oomtest;

import android.support.v4.view.ViewPager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final ViewPager viewPager = (ViewPager) findViewById(R.id.activity_main_view_pager);
        final ImageViewPagerAdapter adapter = new ImageViewPagerAdapter(getSupportFragmentManager());
        viewPager.setAdapter(adapter);
    }
}
