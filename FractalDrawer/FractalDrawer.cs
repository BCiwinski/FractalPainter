using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using FractalPainterInterfaces;

namespace FractalDrawer
{
    public class FractalDrawer : IFractalDrawer
    {
        protected IFractal fractal;
        public IFractal Fractal { get { return fractal; } set { fractal = value; } }

        protected IFractalColorPalette palette;
        public IFractalColorPalette Palette { get { return palette; } set { palette = value; } }

        protected Size drawSize = new Size(512, 512);
        public Size DrawSize { get { return drawSize; } set { drawSize = value; } }


        public int IterationsNum {get { return fractal.IterationsNum; } set { fractal.IterationsNum = value; } }


        protected double zoom = 1.0;
        public double Zoom { get { return zoom; } set { zoom = value; } }


        protected double offsetX = 0.0;
        public double OffsetX { get { return offsetX; } set { offsetX = value; } }


        protected double offsetY = 0.0;
        public double OffsetY { get { return offsetY; } set { offsetY = value; } }

        public FractalDrawer(IFractal fractal, IFractalColorPalette palette)
        {
            this.fractal = fractal;
            this.palette = palette;

            zoom = fractal.DefaultZoom;
            offsetX = fractal.DefaultOffsetX;
            offsetY = fractal.DefaultOffsetY;
        }

        public Image DrawFractal()
        {
            Bitmap result = new Bitmap(drawSize.Width, drawSize.Height);

            BitmapData bmpData = result.LockBits(
                new Rectangle(0, 0, drawSize.Width, drawSize.Height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb
                );


            IntPtr ptr = bmpData.Scan0;

            int widthInBytes = bmpData.Stride;
            int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(bmpData.PixelFormat) / 8;

            int bytes = bmpData.Stride * drawSize.Height;
            byte[] rgbValues = new byte[bytes];


            unsafe
            {
                byte* PtrFirstPixel = (byte*)bmpData.Scan0;

                for(int y = 0; y < drawSize.Height; y++)
                    for(int x = 0; x < drawSize.Width; x++)
                    {
                        Color color = palette.GetIterationColor(fractal.GetPointIterations(
                            GetPointX(x),
                            GetPointY(y)
                            ));

                        PtrFirstPixel[y * widthInBytes + x * bytesPerPixel] = (byte)(color.B);
                        PtrFirstPixel[y * widthInBytes + x * bytesPerPixel + 1] = (byte)(color.G);
                        PtrFirstPixel[y * widthInBytes + x * bytesPerPixel + 2] = (byte)(color.R);
                    }
            }



            result.UnlockBits(bmpData);
            return result;
        }

        public double GetPointX(int x)
        {
            return (((double)x - drawSize.Width / 2) / zoom) - offsetX;
        }

        public double GetPointY(int y)
        {
            return (((double)y - drawSize.Height / 2) / zoom) - offsetY;
        }
    }
}
