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

            float radius = Math.Min((float)CanvasView.Width / 2, (float)CanvasView.Height / 2);

            canvas.DrawCircle((int)CanvasView.Width / 2, (int)CanvasView.Height / 2, radius, Paint.FillPaint);

            if (Paint.BorderPaint != null)
            {
                canvas.DrawCircle(
                    (float)CanvasView.Width / 2,
                    (float)CanvasView.Height / 2,
                    radius - Paint.BorderWidth / 2,
                    Paint.BorderPaint);
            }
        }
    }
}
