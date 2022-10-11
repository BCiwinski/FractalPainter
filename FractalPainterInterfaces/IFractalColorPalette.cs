using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalPainterInterfaces
{
    public interface IFractalColorPalette
    {
        Color GetIterationColor(int iteration);

        int IterationsMax { get; }
    }
}
