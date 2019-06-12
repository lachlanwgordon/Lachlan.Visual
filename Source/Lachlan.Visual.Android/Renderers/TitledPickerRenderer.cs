using System;
using Android.Content;
using Lachlan.Visual;
using Lachlan.Visual.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;

[assembly: ExportRenderer(typeof(Picker), typeof(TitledPickerRenderer), new[] { typeof(LachlanVisual) })]
namespace Lachlan.Visual.Renderers
{
    public class TitledPickerRenderer : MaterialPickerRenderer
    {
        public TitledPickerRenderer(Context context) : base(context)
        {

        }

        protected override void UpdatePlaceHolderText()
        {
            base.UpdatePlaceHolderText();
            InputLayout.HintEnabled = true;
            InputLayout.Hint = Element.Title;
        }

        MaterialPickerTextInputLayout InputLayout;
        protected override MaterialPickerTextInputLayout CreateNativeControl()
        {
            InputLayout = base.CreateNativeControl();
            return InputLayout;
        }

    }
}
