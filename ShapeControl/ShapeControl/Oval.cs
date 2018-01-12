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

            if (Paint.Style != SKPaintStyle.Fill)
            {
                xRadius -= (int)(Paint.StrokeWidth / 2);
                yRadius -= (int)(Paint.StrokeWidth / 2);
            }

            canvas.DrawOval((int)CanvasView.Width / 2, (int)CanvasView.Height / 2, xRadius, yRadius, Paint);
        }
    }
}
