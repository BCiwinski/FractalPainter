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

        bool autoRedraw = false;
        decimal zoomIncrementMult = 0.1m;

        public FractalPainterApp(Autofac.IContainer container)
        {
            InitializeComponent();

            drawer = container.Resolve<IFractalDrawer>();
            drawer.DrawSize = pictureBox.Size;

            numericUpDownZoom.Value = (decimal)drawer.Fractal.DefaultZoom;
            autoRedraw = checkBoxAutoRedraw.Checked;

            drawFractal();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            drawFractal();
        }

        private void drawFractal()
        {
            drawer.DrawSize = pictureBox.Size;
            drawer.Zoom = (double)numericUpDownZoom.Value;

            pictureBox.Image = drawer.DrawFractal();
        }

        private void onParamsChanged()
        {
            if (autoRedraw)
                drawFractal();

        }

        private void numericUpDownIterations_ValueChanged(object sender, EventArgs e)
        {
            drawer.IterationsNum = (int)numericUpDownIterations.Value;
            onParamsChanged();
        }

        private void numericUpDownZoom_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownZoom.Increment = numericUpDownZoom.Value * zoomIncrementMult;
            onParamsChanged();
        }

        private void checkBoxAutoRedraw_CheckedChanged(object sender, EventArgs e)
        {
            autoRedraw = checkBoxAutoRedraw.Checked;
            onParamsChanged();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            centerOnPoint(e.X, e.Y);
        }

        private void centerOnPoint(int x, int y)
        {
            drawer.OffsetX = -drawer.GetPointX(x);
            drawer.OffsetY = -drawer.GetPointY(y);

            onParamsChanged();
        }

        private void FractalPainterApp_ResizeEnd(object sender, EventArgs e)
        {
            onParamsChanged();
        }
    }
}
