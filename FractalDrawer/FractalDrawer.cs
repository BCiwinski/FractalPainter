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


        protected Size drawSize = new Size(512, 512);
        public Size DrawSize { get { return drawSize; } set { drawSize = value; } }


        public int IterationsNum {get { return fractal.IterationsNum; } set { fractal.IterationsNum = value; } }


        protected double zoom = 200.0;
        public double Zoom { get { return zoom; } set { zoom = value; } }


        protected double offsetX = 384.0;
        public double OffsetX { get { return offsetX; } set { offsetX = value; } }


        protected double offsetY = 256.0;
        public double OffsetY { get { return offsetY; } set { offsetY = value; } }

        public FractalDrawer(IFractal fractal)
        {
            this.fractal = fractal;
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


            double colorScale = 255.0 / (double)IterationsNum;

            unsafe
            {
                byte* PtrFirstPixel = (byte*)bmpData.Scan0;

                for(int y = 0; y < drawSize.Height; y++)
                    for(int x = 0; x < drawSize.Width; x++)
                    {
                        PtrFirstPixel[y * widthInBytes + x * bytesPerPixel] = (byte)(colorScale * (double)(fractal.GetPointValue(
                            (((double)x - offsetX) / zoom),
                            (((double)y - offsetY) / zoom)
                            )
                            ));
                    }
            }



            result.UnlockBits(bmpData);
            return result;
        }
    }
}
