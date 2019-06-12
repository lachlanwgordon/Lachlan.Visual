using System;
using Lachlan.Visual;
using Lachlan.Visual.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Picker), typeof(TitledPickerRenderer), new[] { typeof(LachlanVisual) })]
namespace Lachlan.Visual.Renderers
{
    public class TitledPickerRenderer : MaterialPickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Placeholder = Element.Title;
                Control.HidesPlaceholderOnInput = false;
            }
        }

        protected override void UpdatePlaceholder()
        {
            //This method intentionally blank
            //The base implementation hides the place holder when selected
            //This material renderer automatically shrinks the placeholder
            //I may need to revisit this
        }
    }
}
