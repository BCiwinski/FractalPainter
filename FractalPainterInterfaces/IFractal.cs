using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalPainterInterfaces
{
    public interface IFractal
    {
        int IterationsNum { get; set; }

        int GetPointIterations(double x, double y);

        double DefaultZoom { get; }
        double DefaultOffsetX { get; }
        double DefaultOffsetY { get; }
    }
}