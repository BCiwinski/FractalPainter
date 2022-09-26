using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FractalPainterInterfaces;
using Autofac;

namespace FractalPainter
{
    public partial class FractalPainterApp : Form
    {
        IFractalDrawer drawer;


        public FractalPainterApp(Autofac.IContainer container)
        {
            InitializeComponent();

            drawer = container.Resolve<IFractalDrawer>();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            pictureBox.Image = drawer.DrawFractal();

        }
    }
}
