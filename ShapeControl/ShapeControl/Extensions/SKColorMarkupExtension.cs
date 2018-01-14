using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stormlion.ShapeControl
{
    [ContentProperty("Value")]
    public class SKColorMarkupExtension : IMarkupExtension<SKColor>
    {
        public Color Value { get; set; }

        public SKColor ProvideValue(IServiceProvider serviceProvider)
        {
            return new SKColor((byte)(Value.R * 255), (byte)(Value.G * 255), (byte)(Value.B * 255), (byte)(Value.A * 255));
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<SKColor>).ProvideValue(serviceProvider);
        }
    }
}
