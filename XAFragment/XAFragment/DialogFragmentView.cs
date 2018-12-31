
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace XAFragment
{
    public class DialogFragmentView : DialogFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.Modal, container, false);
            var submitButton = view.FindViewById<Button>(Resource.Id.submitButton);
            submitButton.Click += (s, a) => Dismiss();
            return view;
        }
    }
}