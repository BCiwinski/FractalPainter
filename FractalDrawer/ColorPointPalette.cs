using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FractalPainterInterfaces;

namespace FractalDrawer
{
    public abstract class ColorPointPalette : IFractalColorPalette
    {
        protected List<ColorItr> colorItr;

        public abstract int IterationsMax { get; }

        protected float stretch = 1.0f;
        public float Stretch { get { return stretch; } set { stretch = value; } }

        public ColorPointPalette()
        {
            setupColorPoints();
        }

        abstract protected void setupColorPoints();

        public virtual Color GetIterationColor(int iteration)
        {
            if (colorItr.Count() == 0)
                throw new PaletteException("Color palette contains on colors!");

            ColorItr colorBefore = colorItr.First();
            ColorItr colorAfter = colorItr.Last();


            foreach (ColorItr ci in colorItr)
            {
                if (ci.itr * stretch <= iteration && colorBefore.itr * stretch < ci.itr * stretch)
                    colorBefore = ci;

                if (ci.itr * stretch >= iteration && colorAfter.itr * stretch > ci.itr * stretch)
                    colorAfter = ci;
            }

            if (colorAfter.itr == colorBefore.itr)
                return colorBefore.color;


            int range = (int)((colorAfter.itr - colorBefore.itr) * stretch);
            int colorPos = (int)(iteration - colorBefore.itr * stretch);

            float colorAMix = (float)colorPos / (float)range;
            float colorBMix = 1 - colorAMix;

            Color result = Color.FromArgb(
                255,
                (int)(colorAfter.color.R * colorAMix + colorBefore.color.R * colorBMix),
                (int)(colorAfter.color.G * colorAMix + colorBefore.color.G * colorBMix),
                (int)(colorAfter.color.B * colorAMix + colorBefore.color.B * colorBMix)
                );

            return result;
        }


    }

    public struct ColorItr
    {
        public Color color;
        public int itr;
    }

    public class PaletteException : Exception {

        public PaletteException(string message) : base(message) { }
    }
}
