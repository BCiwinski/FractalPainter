using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalPainterInterfaces
{
    public interface IFractalDrawer
    {
        IFractal Fractal { get; set; }
        IFractalColorPalette Palette { get; set; }
        bool PaletteLoop { get; set; }
        int IterationsNum { get; set; }
        double Zoom { get; set; }
        double OffsetX { get; set; }
        double OffsetY { get; set; }

        Size DrawSize { get; set; }
        Image DrawFractal();

        double GetPointX(int pixelX);
        double GetPointY(int pixelY);
    }
}
