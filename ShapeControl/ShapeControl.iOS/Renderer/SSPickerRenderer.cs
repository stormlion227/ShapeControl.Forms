
using Stormlion.ShapeControl;
using Stormlion.ShapeControl.iOS.Renderer;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SSPicker), typeof(SSPickerRenderer))]
namespace Stormlion.ShapeControl.iOS.Renderer
{
    public class SSPickerRenderer : PickerRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}