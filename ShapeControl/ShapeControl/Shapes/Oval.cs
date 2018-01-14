using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace Stormlion.ShapeControl
{
    public class Oval : ShapeControlBase
    {
        protected override void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            base.OnCanvasViewPaintSurface(sender, args);

            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            int xRadius = (int)(CanvasView.Width / 2);
            int yRadius = (int)(CanvasView.Height / 2);

            canvas.DrawOval((int)CanvasView.Width / 2, (int)CanvasView.Height / 2, xRadius, yRadius, Paint.FillPaint);

            if (Paint.BorderPaint != null)
            {
                canvas.DrawOval((int)CanvasView.Width / 2, (int)CanvasView.Height / 2,
                    xRadius - Paint.BorderWidth / 2, 
                    yRadius - Paint.BorderWidth / 2,
                    Paint.BorderPaint);
            }
        }
    }
}
