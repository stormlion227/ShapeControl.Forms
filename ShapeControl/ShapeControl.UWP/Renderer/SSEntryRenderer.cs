using Stormlion.ShapeControl;
using Stormlion.ShapeControl.UWP.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SSEntry), typeof(SSEntryRenderer))]
namespace Stormlion.ShapeControl.UWP.Renderer
{
    public class SSEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
