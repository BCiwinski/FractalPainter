
namespace FractalPainter
{
    partial class FractalPainterApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxAutoRedraw = new System.Windows.Forms.CheckBox();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelInfo);
            this.panel.Controls.Add(this.checkBoxAutoRedraw);
            this.panel.Controls.Add(this.numericUpDownZoom);
            this.panel.Controls.Add(this.numericUpDownIterations);
            this.panel.Controls.Add(this.buttonDraw);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(157, 553);
            this.panel.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(13, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(128, 62);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Click on the image to center on a point";
            // 
            // checkBoxAutoRedraw
            // 
            this.checkBoxAutoRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoRedraw.AutoSize = true;
            this.checkBoxAutoRedraw.Checked = true;
            this.checkBoxAutoRedraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRedraw.Location = new System.Drawing.Point(4, 470);
            this.checkBoxAutoRedraw.Name = "checkBoxAutoRedraw";
            this.checkBoxAutoRedraw.Size = new System.Drawing.Size(107, 21);
            this.checkBoxAutoRedraw.TabIndex = 3;
            this.checkBoxAutoRedraw.Text = "AutoRedraw";
            this.checkBoxAutoRedraw.UseVisualStyleBackColor = true;
            this.checkBoxAutoRedraw.CheckedChanged += new System.EventHandler(this.checkBoxAutoRedraw_CheckedChanged);
            // 
            // numericUpDownZoom
            // 
            this.numericUpDownZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownZoom.DecimalPlaces = 3;
            this.numericUpDownZoom.Location = new System.Drawing.Point(5, 414);
            this.numericUpDownZoom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownZoom.Name = "numericUpDownZoom";
            this.numericUpDownZoom.Size = new System.Drawing.Size(147, 22);
            this.numericUpDownZoom.TabIndex = 2;
            this.numericUpDownZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZoom.ValueChanged += new System.EventHandler(this.numericUpDownZoom_ValueChanged);
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownIterations.Location = new System.Drawing.Point(4, 442);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(148, 22);
            this.numericUpDownIterations.TabIndex = 1;
            this.numericUpDownIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownIterations.ValueChanged += new System.EventHandler(this.numericUpDownIterations_ValueChanged);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDraw.Location = new System.Drawing.Point(4, 497);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(150, 44);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1182, 553);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // FractalPainterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox);
            this.Name = "FractalPainterApp";
            this.Text = "FractalPainter";
            this.ResizeEnd += new System.EventHandler(this.FractalPainterApp_ResizeEnd);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.Windows.Forms.NumericUpDown numericUpDownZoom;
        private System.Windows.Forms.CheckBox checkBoxAutoRedraw;
        private System.Windows.Forms.Label labelInfo;
    }
}

