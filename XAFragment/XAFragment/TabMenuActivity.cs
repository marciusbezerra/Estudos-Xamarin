
using Android.App;
using Android.OS;

namespace XAFragment
{
    [Activity(Theme = "@android:style/Theme.Material", Label = "TabMenuActivity")]
    public class TabMenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TabMain);
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            var tab = ActionBar.NewTab();
            tab.SetText("Primeira ABA");
            var firstTabFragment = new FirstTabFragment();
            tab.TabSelected += (s, e) =>
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null) e.FragmentTransaction.Remove(fragment);
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, firstTabFragment);
            };
            tab.TabUnselected += (s, e) =>
            {
                e.FragmentTransaction.Remove(firstTabFragment);
            };

            ActionBar.AddTab(tab);

            var tab2 = ActionBar.NewTab();
            tab2.SetText("Segunda ABA");
            var secondTabFragment = new SecondTabFragment();
            tab2.TabSelected += (s, e) =>
            {
                var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
                if (fragment != null) e.FragmentTransaction.Remove(fragment);
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, secondTabFragment);
            };
            tab2.TabUnselected += (s, e) =>
            {
                e.FragmentTransaction.Remove(secondTabFragment);
            };

            ActionBar.AddTab(tab2);

        }
    }
}