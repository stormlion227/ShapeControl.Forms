using System.ComponentModel;
using Stormlion.ShapeControl;
using Stormlion.ShapeControl.iOS.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SSEditor), typeof(SSEditorRenderer))]
namespace Stormlion.ShapeControl.iOS.Renderer
{
    public class SSEditorRenderer : EditorRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
        }
    }
}