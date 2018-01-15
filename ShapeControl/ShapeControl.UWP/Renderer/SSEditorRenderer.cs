using Stormlion.ShapeControl;
using Stormlion.ShapeControl.UWP.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SSEditor), typeof(SSEditorRenderer))]
namespace Stormlion.ShapeControl.UWP.Renderer
{
    public class SSEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Margin = new Windows.UI.Xaml.Thickness(0);
                Control.Padding = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
