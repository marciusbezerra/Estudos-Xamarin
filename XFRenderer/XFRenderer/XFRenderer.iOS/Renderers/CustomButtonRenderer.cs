﻿using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFRenderer;
using XFRenderer.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]

namespace XFRenderer.iOS.Renderers
{
    public class CustomButtonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Brown;
            }
        }
    }
}