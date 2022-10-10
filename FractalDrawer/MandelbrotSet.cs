using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalPainterInterfaces;

namespace FractalDrawer
{
    public class MandelbrotSet : IFractal
    {
        int iterationsNum = 100;
        public int IterationsNum { get { return iterationsNum; } set { iterationsNum = value; } }

        public double DefaultZoom => throw new NotImplementedException();

        public double DefaultOffsetX => throw new NotImplementedException();

        public double DefaultOffsetY => throw new NotImplementedException();

        public int GetPointIterations(double x0, double y0)
        {
            // algorithm from wikipedia
            // https://en.wikipedia.org/wiki/Mandelbrot_set#Computer_drawings


            double x = 0.0;
            double y = 0.0;

            int i = 0;
            while (x * x + y * y <= 2 * 2 && i < iterationsNum)
            {
                double xtemp = x * x - y * y + x0;
                y = 2 * x * y + y0;
                x = xtemp;
                i++;
            }



            return i;
        }
    }
}
