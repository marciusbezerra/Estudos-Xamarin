﻿
using Android.App;
using Android.OS;
using Android.Views;

namespace XAFragment
{
    public class FirstFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Fragment1, container);
        }
    }
}