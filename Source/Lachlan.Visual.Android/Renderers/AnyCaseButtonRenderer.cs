using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

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
