using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace Stormlion.ShapeControl
{
    public class Circle : ShapeControlBase
    {
        protected override void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            base.OnCanvasViewPaintSurface(sender, args);

            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            int radius = Math.Min(info.Width / 2, info.Height / 2);
            canvas.DrawCircle(info.Width / 2, info.Height / 2, radius, Paint);
        }
    }
}
