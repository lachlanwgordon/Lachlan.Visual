using System;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

namespace Lachlan.Visual.Renderers
{

    public class AnyCaseButtonRenderer : MaterialButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.UppercaseTitle = false;
            }
        }
    }
}
