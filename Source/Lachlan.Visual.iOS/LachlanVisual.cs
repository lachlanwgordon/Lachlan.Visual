using System;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace Lachlan.Visual
{
    public class LachlanVisual : IVisual
    {
        public static void Init()
        {
            var materialAssembly = Assembly.GetAssembly(typeof(Xamarin.Forms.Material.iOS.MaterialButtonRenderer));//Get the assembly where the MaterialRenderers live

            var name = "Xamarin.Forms.Material.iOS";//investigate a type safe way
            var baseRendererTypes = materialAssembly.ExportedTypes.Where(x => x.IsClass && x.Namespace == name && x.Name.Contains("Renderer"));//Get all the Material Renderers

            foreach (var baseRendererType in baseRendererTypes)//Iterate over every material renderer
            {
                var baseRendererElementProperty = baseRendererType.GetRuntimeProperties().FirstOrDefault(x => x.Name == "Element");//Find the type of the XamarinForms View that the render looks after
                Xamarin.Forms.Internals.Registrar.Registered.Register(baseRendererElementProperty.PropertyType, baseRendererType, new[] { typeof(LachlanVisual) });//Register the renderer. This call is equivalent to the Export statements we usually put in our renderers.
            }

        }
    }
}
