using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stormlion.ShapeControl.Extensions
{
    [ContentProperty("ColorString")]
    public class SKColorMarkupExtension : IMarkupExtension<SKColor>
    {
        public string ColorString { get; set; }

        public SKColor ProvideValue(IServiceProvider serviceProvider)
        {
            Color color = (Color)new ColorTypeConverter().ConvertFromInvariantString(ColorString);
            return new SKColor((byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255), (byte)(color.A * 255));
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<SKColor>).ProvideValue(serviceProvider);
        }
    }
}
