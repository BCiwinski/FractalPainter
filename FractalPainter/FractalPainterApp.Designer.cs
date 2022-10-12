
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
            this.labelStretch = new System.Windows.Forms.Label();
            this.labelZoom = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.numericUpDownStretch = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.numericUpDownResY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResX = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRes = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxAutoRedraw = new System.Windows.Forms.CheckBox();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStretch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelStretch);
            this.panel.Controls.Add(this.labelZoom);
            this.panel.Controls.Add(this.labelIterations);
            this.panel.Controls.Add(this.numericUpDownStretch);
            this.panel.Controls.Add(this.checkBoxLoop);
            this.panel.Controls.Add(this.numericUpDownResY);
            this.panel.Controls.Add(this.numericUpDownResX);
            this.panel.Controls.Add(this.checkBoxRes);
            this.panel.Controls.Add(this.buttonSave);
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
            // labelStretch
            // 
            this.labelStretch.AutoSize = true;
            this.labelStretch.Location = new System.Drawing.Point(9, 198);
            this.labelStretch.Name = "labelStretch";
            this.labelStretch.Size = new System.Drawing.Size(92, 17);
            this.labelStretch.TabIndex = 13;
            this.labelStretch.Text = "Color stretch:";
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(3, 324);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(48, 17);
            this.labelZoom.TabIndex = 12;
            this.labelZoom.Text = "Zoom:";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(3, 369);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(140, 17);
            this.labelIterations.TabIndex = 11;
            this.labelIterations.Text = "Number of iterations:";
            // 
            // numericUpDownStretch
            // 
            this.numericUpDownStretch.DecimalPlaces = 1;
            this.numericUpDownStretch.Location = new System.Drawing.Point(12, 224);
            this.numericUpDownStretch.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownStretch.Name = "numericUpDownStretch";
            this.numericUpDownStretch.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownStretch.TabIndex = 10;
            this.numericUpDownStretch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStretch.ValueChanged += new System.EventHandler(this.numericUpDownStretch_ValueChanged);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Checked = true;
            this.checkBoxLoop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLoop.Location = new System.Drawing.Point(12, 174);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(106, 21);
            this.checkBoxLoop.TabIndex = 9;
            this.checkBoxLoop.Text = "Loop Colors";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // numericUpDownResY
            // 
            this.numericUpDownResY.Enabled = false;
            this.numericUpDownResY.Location = new System.Drawing.Point(86, 132);
            this.numericUpDownResY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownResY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownResY.Name = "numericUpDownResY";
            this.numericUpDownResY.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownResY.TabIndex = 8;
            this.numericUpDownResY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownResY.ValueChanged += new System.EventHandler(this.numericUpDownResY_ValueChanged);
            // 
            // numericUpDownResX
            // 
            this.numericUpDownResX.Enabled = false;
            this.numericUpDownResX.Location = new System.Drawing.Point(12, 132);
            this.numericUpDownResX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownResX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownResX.Name = "numericUpDownResX";
            this.numericUpDownResX.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownResX.TabIndex = 7;
            this.numericUpDownResX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownResX.ValueChanged += new System.EventHandler(this.numericUpDownResX_ValueChanged);
            // 
            // checkBoxRes
            // 
            this.checkBoxRes.AutoSize = true;
            this.checkBoxRes.Location = new System.Drawing.Point(12, 105);
            this.checkBoxRes.Name = "checkBoxRes";
            this.checkBoxRes.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRes.TabIndex = 6;
            this.checkBoxRes.Text = "Set Resolution";
            this.checkBoxRes.UseVisualStyleBackColor = true;
            this.checkBoxRes.CheckedChanged += new System.EventHandler(this.checkBoxRes_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(4, 496);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(148, 45);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.checkBoxAutoRedraw.Location = new System.Drawing.Point(4, 419);
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
            this.numericUpDownZoom.Location = new System.Drawing.Point(5, 344);
            this.numericUpDownZoom.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
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
            this.numericUpDownIterations.Location = new System.Drawing.Point(4, 391);
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
            this.buttonDraw.Location = new System.Drawing.Point(4, 446);
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
            this.pictureBox.Location = new System.Drawing.Point(157, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1025, 553);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // FractalPainterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel);
            this.Name = "FractalPainterApp";
            this.Text = "FractalPainter";
            this.ResizeEnd += new System.EventHandler(this.FractalPainterApp_ResizeEnd);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStretch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResX)).EndInit();
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownResY;
        private System.Windows.Forms.NumericUpDown numericUpDownResX;
        private System.Windows.Forms.CheckBox checkBoxRes;
        private System.Windows.Forms.NumericUpDown numericUpDownStretch;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Label labelStretch;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelIterations;
    }
}

