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

        decimal zoomIncrementMult = 0.1m;

        public FractalPainterApp(Autofac.IContainer container)
        {
            InitializeComponent();

            drawer = container.Resolve<IFractalDrawer>();
            drawer.DrawSize = pictureBox.Size;

            numericUpDownZoom.Value = (decimal)drawer.Fractal.DefaultZoom;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            drawer.DrawSize = pictureBox.Size;
            drawer.Zoom = (double)numericUpDownZoom.Value;

            pictureBox.Image = drawer.DrawFractal();

        }

        private void numericUpDownIterations_ValueChanged(object sender, EventArgs e)
        {
            drawer.IterationsNum = (int)numericUpDownIterations.Value;
        }

        private void numericUpDownZoom_ValueChanged(object sender, EventArgs e)
        {
            drawer.Zoom = (double)numericUpDownZoom.Value;

            numericUpDownZoom.Increment = numericUpDownZoom.Value * zoomIncrementMult;
        }
    }
}
