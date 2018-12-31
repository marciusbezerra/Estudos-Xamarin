using Android.Content;
using Xamarin.Forms;
using XFRenderer.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using XFRenderer;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]

namespace XFRenderer.Droid.Renderers
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Chocolate);
            }
        }

        public CustomButtonRenderer(Context context) : base(context)
        {
        }
    }
}