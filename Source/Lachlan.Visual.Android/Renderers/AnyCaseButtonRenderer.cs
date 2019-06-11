using System;
using Android.Content;
using Lachlan.Visual;
using Lachlan.Visual.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(AnyCaseButtonRenderer), new Type[] { typeof(LachlanVisual)})]
namespace Lachlan.Visual.Renderers
{
    public class AnyCaseButtonRenderer : MaterialButtonRenderer
    {
        public AnyCaseButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetAllCaps(false);
            }
        }
    }
}
