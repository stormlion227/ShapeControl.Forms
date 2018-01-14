using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stormlion.ShapeControl
{
    public class SSPaint : BindableObject
    {
        public Color FillColor { get; set; } = Color.Black;

        public SKShader FillShader { get; set; } = null;

        public Color BorderColor { get; set; } = Color.Black;

        public SKShader BorderShader { get; set; } = null;

        public float BorderWidth { get; set; } = 0;

        public SKPathEffect PathEffect { get; set; } = null;


        public SKPaint BorderPaint
        {
            get
            {
                if (BorderWidth <= 0)
                    return null;

                return new SKPaint
                {
                    Color = Utils.ColorToSK(BorderColor),
                    Shader = BorderShader,
                    StrokeWidth = BorderWidth,
                    Style = SKPaintStyle.Stroke,
                    PathEffect = PathEffect
                };
            }
        }

        public SKPaint FillPaint
        {
            get
            {
                return new SKPaint
                {
                    Color = Utils.ColorToSK(FillColor),
                    Shader = FillShader,
                    Style = SKPaintStyle.Fill
                };
            }
        }
    }
}
