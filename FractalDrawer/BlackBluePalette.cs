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
        new ColorItr {color = Color.Black, itr = 0},
        new ColorItr {color = Color.DarkBlue, itr = 20},
        new ColorItr {color = Color.Blue, itr = 50},
        new ColorItr {color = Color.Black, itr = 100}
        };

        public int IterationsMax { get{ return 100;} }

        private float stretch = 1.0f;
        public float Stretch { get { return stretch; } set { stretch = value; } }

        public Color GetIterationColor(int iteration)
        {
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
