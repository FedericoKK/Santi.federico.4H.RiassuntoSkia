using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Santi.federico._4h.RiassuntoSkia
{
    public partial class MainPage : ContentPage
    {
        public int margineSinistro{ get; set; } = 100;
        public int margineSopra { get; set; } = 100;
        public int larghezzaRettangolo { get; set; } = 200;
        public int altezzaRettangolo { get; set; } = 300;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnDisegna_Clicked(object sender, EventArgs e)
        {

        }

        private void SKCanvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var info = e.Info;
            //var surface = e.Surface;
            var canvas = e.Surface.Canvas;
            canvas.Clear();
            int larghezza = info.Rect.Width;
            int altezza = info.Rect.Height;

            //int x = 
        }
        SKPath Areadidisegno()
        {
            SKPath rettangolo = new SKPath();
            rettangolo.MoveTo();
            return;
        }
    }
}
