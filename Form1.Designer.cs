namespace ZebyRTGDeluxe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MonochromaticButton = new System.Windows.Forms.Button();
            this.InvertButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.EmbossButton = new System.Windows.Forms.Button();
            this.SharpenButton = new System.Windows.Forms.Button();
            this.NoiseButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.StretchBox = new System.Windows.Forms.CheckBox();
            this.ZoomBox = new System.Windows.Forms.CheckBox();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.GammaTrackBar = new System.Windows.Forms.TrackBar();
            this.GammaLabel = new System.Windows.Forms.Label();
            this.AutoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 677);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(1083, 12);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(120, 65);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1083, 83);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 65);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1083, 154);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(120, 65);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(1083, 225);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(120, 65);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply Changes";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1083, 367);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 65);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MonochromaticButton
            // 
            this.MonochromaticButton.Location = new System.Drawing.Point(1083, 470);
            this.MonochromaticButton.Name = "MonochromaticButton";
            this.MonochromaticButton.Size = new System.Drawing.Size(120, 65);
            this.MonochromaticButton.TabIndex = 6;
            this.MonochromaticButton.Text = "Monochromatic";
            this.MonochromaticButton.UseVisualStyleBackColor = true;
            this.MonochromaticButton.Click += new System.EventHandler(this.MonochromaticButton_Click);
            // 
            // InvertButton
            // 
            this.InvertButton.Location = new System.Drawing.Point(1083, 541);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(120, 65);
            this.InvertButton.TabIndex = 7;
            this.InvertButton.Text = "Invert";
            this.InvertButton.UseVisualStyleBackColor = true;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(1083, 296);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(120, 65);
            this.RedoButton.TabIndex = 8;
            this.RedoButton.Text = "Undo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // EmbossButton
            // 
            this.EmbossButton.Location = new System.Drawing.Point(1083, 612);
            this.EmbossButton.Name = "EmbossButton";
            this.EmbossButton.Size = new System.Drawing.Size(120, 65);
            this.EmbossButton.TabIndex = 9;
            this.EmbossButton.Text = "Emboss";
            this.EmbossButton.UseVisualStyleBackColor = true;
            this.EmbossButton.Click += new System.EventHandler(this.EmbossButton_Click);
            // 
            // SharpenButton
            // 
            this.SharpenButton.Location = new System.Drawing.Point(1083, 683);
            this.SharpenButton.Name = "SharpenButton";
            this.SharpenButton.Size = new System.Drawing.Size(120, 65);
            this.SharpenButton.TabIndex = 10;
            this.SharpenButton.Text = "Sharpen";
            this.SharpenButton.UseVisualStyleBackColor = true;
            this.SharpenButton.Click += new System.EventHandler(this.SharpenButton_Click);
            // 
            // NoiseButton
            // 
            this.NoiseButton.Location = new System.Drawing.Point(957, 683);
            this.NoiseButton.Name = "NoiseButton";
            this.NoiseButton.Size = new System.Drawing.Size(120, 65);
            this.NoiseButton.TabIndex = 11;
            this.NoiseButton.Text = "Noise Removal";
            this.NoiseButton.UseVisualStyleBackColor = true;
            this.NoiseButton.Click += new System.EventHandler(this.NoiseButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(791, 683);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(76, 65);
            this.RotateButton.TabIndex = 12;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // StretchBox
            // 
            this.StretchBox.AutoSize = true;
            this.StretchBox.Location = new System.Drawing.Point(705, 683);
            this.StretchBox.Name = "StretchBox";
            this.StretchBox.Size = new System.Drawing.Size(60, 17);
            this.StretchBox.TabIndex = 13;
            this.StretchBox.Text = "Stretch";
            this.StretchBox.UseVisualStyleBackColor = true;
            this.StretchBox.CheckedChanged += new System.EventHandler(this.StretchBox_CheckedChanged);
            // 
            // ZoomBox
            // 
            this.ZoomBox.AutoSize = true;
            this.ZoomBox.Location = new System.Drawing.Point(705, 708);
            this.ZoomBox.Name = "ZoomBox";
            this.ZoomBox.Size = new System.Drawing.Size(78, 17);
            this.ZoomBox.TabIndex = 14;
            this.ZoomBox.Text = "Auto Zoom";
            this.ZoomBox.UseVisualStyleBackColor = true;
            this.ZoomBox.CheckedChanged += new System.EventHandler(this.ZoomBox_CheckedChanged);
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(110, 683);
            this.BrightnessTrackBar.Maximum = 255;
            this.BrightnessTrackBar.Minimum = -255;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(150, 45);
            this.BrightnessTrackBar.TabIndex = 15;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.BrightnessTrackBar_Scroll);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(156, 731);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.BrightnessLabel.TabIndex = 16;
            this.BrightnessLabel.Text = "Brightness";
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Location = new System.Drawing.Point(266, 683);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Minimum = -100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(150, 45);
            this.ContrastTrackBar.TabIndex = 17;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(317, 731);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(46, 13);
            this.ContrastLabel.TabIndex = 18;
            this.ContrastLabel.Text = "Contrast";
            // 
            // GammaTrackBar
            // 
            this.GammaTrackBar.Location = new System.Drawing.Point(422, 683);
            this.GammaTrackBar.Maximum = 25;
            this.GammaTrackBar.Minimum = 1;
            this.GammaTrackBar.Name = "GammaTrackBar";
            this.GammaTrackBar.Size = new System.Drawing.Size(150, 45);
            this.GammaTrackBar.TabIndex = 19;
            this.GammaTrackBar.Value = 5;
            this.GammaTrackBar.Scroll += new System.EventHandler(this.GammaTrackBar_Scroll);
            // 
            // GammaLabel
            // 
            this.GammaLabel.AutoSize = true;
            this.GammaLabel.Location = new System.Drawing.Point(482, 731);
            this.GammaLabel.Name = "GammaLabel";
            this.GammaLabel.Size = new System.Drawing.Size(43, 13);
            this.GammaLabel.TabIndex = 20;
            this.GammaLabel.Text = "Gamma";
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(12, 683);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(76, 65);
            this.AutoButton.TabIndex = 21;
            this.AutoButton.Text = "Auto Adjustment";
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 760);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.GammaLabel);
            this.Controls.Add(this.GammaTrackBar);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.BrightnessTrackBar);
            this.Controls.Add(this.ZoomBox);
            this.Controls.Add(this.StretchBox);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.NoiseButton);
            this.Controls.Add(this.SharpenButton);
            this.Controls.Add(this.EmbossButton);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.InvertButton);
            this.Controls.Add(this.MonochromaticButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ZebyRTGDeluxe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MonochromaticButton;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button EmbossButton;
        private System.Windows.Forms.Button SharpenButton;
        private System.Windows.Forms.Button NoiseButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.CheckBox StretchBox;
        private System.Windows.Forms.CheckBox ZoomBox;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.TrackBar GammaTrackBar;
        private System.Windows.Forms.Label GammaLabel;
        private System.Windows.Forms.Button AutoButton;
    }
}

