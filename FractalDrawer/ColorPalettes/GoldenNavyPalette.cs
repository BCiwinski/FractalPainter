using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FractalDrawer
{
    public class GoldenNavyPalette : ColorPointPalette
    {
        public override int IterationsMax { get { return 100; } }

        protected override void setupColorPoints()
        {
            colorItr = new List<ColorItr>
            {
                new ColorItr {color = Color.Black, itr = 0},
                new ColorItr {color = Color.Navy, itr = 30},
                new ColorItr {color = Color.Orange, itr = 40},
                new ColorItr {color = Color.White, itr = 50},
                new ColorItr {color = Color.Yellow, itr = 60},
                new ColorItr {color = Color.Navy, itr = 70},
                new ColorItr {color = Color.Black, itr = 100}
            };
        }
    }
}
