using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalPainterInterfaces;

namespace FractalDrawer
{
    public class BlackBluePalette : IFractalColorPalette
    {
        List<ColorItr> colorItr = new List<ColorItr>() {
        new ColorItr {color = Color.White, itr = 0},
        new ColorItr {color = Color.Blue, itr = 20},
        new ColorItr {color = Color.Black, itr = 100}
        };






        public Color GetIterationColor(int iteration)
        {
            ColorItr colorBefore = colorItr[0];
            ColorItr colorAfter = colorItr[0];


            foreach (ColorItr ci in colorItr)
            {
                if (ci.itr <= iteration && colorBefore.itr < ci.itr)
                    colorBefore = ci;

                if (ci.itr >= iteration && colorAfter.itr > ci.itr)
                    colorAfter = ci;
            }

            if (colorAfter.color == colorBefore.color)
                return colorAfter.color;


            int range = colorAfter.itr - colorBefore.itr;
            int colorPos = iteration - colorBefore.itr;

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

    struct ColorItr
    {
        public Color color;
        public int itr;
    }
}
