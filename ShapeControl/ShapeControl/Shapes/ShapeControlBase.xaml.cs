using SkiaSharp;
using SkiaSharp.Views.Forms;

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

        public SSPaint Paint { get => (SSPaint)GetValue(PaintProperty); set => SetValue(PaintProperty, value);}

        public SKCanvasView CanvasView => canvasView;

        public static readonly BindableProperty PaintProperty = BindableProperty.Create(
            nameof(Paint), typeof(SSPaint), typeof(ShapeControlBase), new SSPaint(),
            propertyChanged: (b, n, o) => {
                (b as ShapeControlBase).canvasView.InvalidateSurface();
            }
            );

        protected virtual void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Scale(canvasView.CanvasSize.Width / (float)canvasView.Width, canvasView.CanvasSize.Height / (float)canvasView.Height);
        }
    }
}