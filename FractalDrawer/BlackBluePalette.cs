using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalPainterInterfaces;

namespace FractalDrawer
{
    public class BlackBluePalette : ColorPointPalette
    {
        protected override void setupColorPoints()
        {
            colorItr = new List<ColorItr>() {
                new ColorItr {color = Color.Black, itr = 0},
                new ColorItr {color = Color.DarkBlue, itr = 20},
                new ColorItr {color = Color.Blue, itr = 50},
                new ColorItr {color = Color.Black, itr = 100}
                };
        }
    }



}
