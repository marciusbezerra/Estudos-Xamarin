using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace XAFragment
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

			Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

			FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            var fragmentButton = FindViewById<Button>(Resource.Id.fragmentButton);
            fragmentButton.Click += (s, a) =>
            {
                var i = new Intent(this, typeof(FragmentsActivity));
                StartActivity(i);
            };

            var dialogViewButton = FindViewById<Button>(Resource.Id.dialogViewButton);
            dialogViewButton.Click += (s, a) =>
            {
                var transaction = FragmentManager.BeginTransaction();
                var dialogFragment = new DialogFragmentView();
                dialogFragment.Show(transaction, "dialog_fragment");
            };

            var dialogAlertButton = FindViewById<Button>(Resource.Id.dialogAlertButton);
            dialogAlertButton.Click += (s, a) =>
            {
                var transaction = FragmentManager.BeginTransaction();
                var dialogFragment = new DialogFragmentAlert();
                dialogFragment.Show(transaction, "dialog_fragment");
            };

            var dialogAlert2Button = FindViewById<Button>(Resource.Id.dialogAlert2Button);
            dialogAlert2Button.Click += (s, a) =>
            {
                var alert = new Android.App.AlertDialog.Builder(this);
                alert.SetView(LayoutInflater.Inflate(Resource.Layout.Modal, null));
                alert.Create().Show();
            };

            var popupButton = FindViewById<Button>(Resource.Id.popupButton);
            popupButton.Click += (s, a) =>
            {
                var menu = new PopupMenu(this, s as Button);
                menu.Inflate(Resource.Menu.menu_main);
                menu.MenuItemClick += (s1, a1) =>
                {
                    Console.WriteLine($"'{a1.Item.TitleFormatted}' selecionado!");
                };
                menu.Show();

            };

            var tabNavigationButton = FindViewById<Button>(Resource.Id.tabNavigationButton);
            tabNavigationButton.Click += (s, a) => StartActivity(typeof(TabMenuActivity));

        }

		public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

