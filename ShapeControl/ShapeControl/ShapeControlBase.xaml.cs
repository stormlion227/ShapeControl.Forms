using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stormlion.ShapeControl
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShapeControlBase : ContentView
	{
		public ShapeControlBase ()
		{
			InitializeComponent ();
		}

        public SKPaint Paint { get => (SKPaint)GetValue(PaintProperty); set => SetValue(PaintProperty, value);}

        public static readonly BindableProperty PaintProperty = BindableProperty.Create(
            nameof(Paint), typeof(SKPaint), typeof(ShapeControlBase), new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.Red.ToSKColor(),
                StrokeWidth = 50
            },
            propertyChanged: (b, n, o) => {
                (b as ShapeControlBase).skiaView.InvalidateSurface();
            }
            );

        protected virtual void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
        }
    }
}