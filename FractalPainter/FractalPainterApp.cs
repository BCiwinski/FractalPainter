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
using System.Threading;

namespace FractalPainter
{
    public partial class FractalPainterApp : Form
    {
        IFractalDrawer drawer;

        bool autoRedraw = false;
        bool autoRes = true;
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
            updateFractalAsync(CancellationToken.None);
        }

        private async void updateFractalAsync(CancellationToken cancellationToken)
        {
            buttonDrawChangeState(false);

            try
            {
                pictureBox.Image = await Task.Run(() => drawer.DrawFractal(), cancellationToken);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


            buttonDrawChangeState(true);
        }

        private void buttonDrawChangeState(bool showDraw)
        {
            if (showDraw)
            {
                buttonDraw.Text = "Draw";
            }
            else
            {
                buttonDraw.Text = "Drawing...";
            }

        }

        private void onParamsChanged()
        {
            if (autoRes)
            {
                drawer.DrawSize = pictureBox.Size;
                numericUpDownResX.Value = pictureBox.Size.Width;
                numericUpDownResY.Value = pictureBox.Size.Height;
            }
            
            drawer.Zoom = (double)numericUpDownZoom.Value;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Bitmap|*.bmp";
            //saveFileDialog.DefaultExt =
            saveFileDialog.FileName = "MyFractal";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void checkBoxRes_CheckedChanged(object sender, EventArgs e)
        {
            autoRes = !checkBoxRes.Checked;

            if (autoRes)
            {
                numericUpDownResX.Enabled = false;
                numericUpDownResY.Enabled = false;
            }
            else
            {
                numericUpDownResX.Enabled = true;
                numericUpDownResY.Enabled = true;
            }
        }

        private void onUserResolutionChanged()
        {
            if (!autoRes)
            {
                drawer.DrawSize = new Size(
                    (int)numericUpDownResX.Value,
                    (int)numericUpDownResY.Value
                    );
            }

            onParamsChanged();
        }

        private void numericUpDownResY_ValueChanged(object sender, EventArgs e)
        {
            onUserResolutionChanged();
        }

        private void numericUpDownResX_ValueChanged(object sender, EventArgs e)
        {
            onUserResolutionChanged();
        }

        private void numericUpDownStretch_ValueChanged(object sender, EventArgs e)
        {
            drawer.PaletteStretch = (float)numericUpDownStretch.Value;
            onParamsChanged();
        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            drawer.PaletteLoop = checkBoxLoop.Checked;
            onParamsChanged();
        }
    }
}
