using System;
using Lachlan.Visual;
using Lachlan.Visual.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(AnyCaseButtonRenderer), new Type[] { typeof(LachlanVisual) })]
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
