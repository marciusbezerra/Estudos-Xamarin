
using Android.App;
using Android.OS;

namespace XAFragment
{
    [Activity(Label = "FragmentsActivity")]
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class FragmentsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainFragment);
        }
    }
}