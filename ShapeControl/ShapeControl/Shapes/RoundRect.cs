using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Stormlion.ShapeControl
{
    public class RoundRect : ShapeControlBase
    {
        public double RadiusX { get => (double)GetValue(RadiusXProperty); set => SetValue(RadiusXProperty, value); }

        public static readonly BindableProperty RadiusXProperty = BindableProperty.Create(
            nameof(RadiusX),
            typeof(double),
            typeof(RoundRect),
            0.0,
            propertyChanged: (b, o, n) =>
            {
                (b as RoundRect).CanvasView.InvalidateSurface();
            }
            );

        public double RadiusY { get => (double)GetValue(RadiusYProperty); set => SetValue(RadiusYProperty, value); }

        public static readonly BindableProperty RadiusYProperty = BindableProperty.Create(
            nameof(RadiusY),
            typeof(double),
            typeof(RoundRect),
            0.0,
            propertyChanged: (b, o, n) =>
            {
                (b as RoundRect).CanvasView.InvalidateSurface();
            }
            );


        protected override void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            base.OnCanvasViewPaintSurface(sender, args);

            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            canvas.DrawRoundRect(
                SKRect.Create(
                    0, 
                    0,
                    (float)CanvasView.Width,
                    (float)CanvasView.Height),
                (float)RadiusX,
                (float)RadiusY,
                Paint.FillPaint
                );

            if (Paint.BorderPaint != null)
            {
                canvas.DrawRoundRect(SKRect.Create(
                    Paint.BorderWidth / 2,
                    Paint.BorderWidth / 2,
                    (float)CanvasView.Width - Paint.BorderWidth,
                    (float)CanvasView.Height - Paint.BorderWidth),
                    (float)RadiusX,
                    (float)RadiusY,
                    Paint.BorderPaint);
            }
        }
    }
}
