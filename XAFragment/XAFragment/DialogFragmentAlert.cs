using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace XAFragment
{
    public class DialogFragmentAlert : DialogFragment
    {
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            var builder = new AlertDialog.Builder(Activity)
                .SetMessage("Isso é um diálogo de Alerta!")
                .SetTitle("DialogFragment")
                .SetPositiveButton("OK", (s, a) =>
            {

            });
            return builder.Create();
        }
    }
}