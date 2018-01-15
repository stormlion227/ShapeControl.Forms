using System.ComponentModel;
using Stormlion.ShapeControl;
using Stormlion.ShapeControl.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SSDatePicker), typeof(SSDatePickerRenderer))]
namespace Stormlion.ShapeControl.iOS.Renderer
{
    public class SSDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}