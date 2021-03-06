namespace Posers
{
    partial class FigureForm
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
            this.components = new System.ComponentModel.Container();
            this.figureImage = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.FigureTimer = new System.Windows.Forms.Timer(this.components);
            this.PausePlayButton = new System.Windows.Forms.Button();
            this.SkipImageButton = new System.Windows.Forms.Button();
            this.SkipTimeButton = new System.Windows.Forms.Button();
            this.FiguresLeftLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.figureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // figureImage
            // 
            this.figureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figureImage.Location = new System.Drawing.Point(0, 0);
            this.figureImage.Name = "figureImage";
            this.figureImage.Size = new System.Drawing.Size(993, 617);
            this.figureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.figureImage.TabIndex = 0;
            this.figureImage.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(38, 504);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 45);
            this.TimeLabel.TabIndex = 1;
            // 
            // PausePlayButton
            // 
            this.PausePlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PausePlayButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PausePlayButton.Location = new System.Drawing.Point(27, 555);
            this.PausePlayButton.Name = "PausePlayButton";
            this.PausePlayButton.Size = new System.Drawing.Size(76, 50);
            this.PausePlayButton.TabIndex = 2;
            this.PausePlayButton.Text = "button1";
            this.PausePlayButton.UseVisualStyleBackColor = true;
            this.PausePlayButton.Click += new System.EventHandler(this.PausePlayButton_Click);
            // 
            // SkipImageButton
            // 
            this.SkipImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SkipImageButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipImageButton.Location = new System.Drawing.Point(109, 555);
            this.SkipImageButton.Name = "SkipImageButton";
            this.SkipImageButton.Size = new System.Drawing.Size(145, 50);
            this.SkipImageButton.TabIndex = 3;
            this.SkipImageButton.Text = "Skip Image";
            this.SkipImageButton.UseVisualStyleBackColor = true;
            this.SkipImageButton.Click += new System.EventHandler(this.SkipImageButton_Click);
            // 
            // SkipTimeButton
            // 
            this.SkipTimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SkipTimeButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipTimeButton.Location = new System.Drawing.Point(260, 555);
            this.SkipTimeButton.Name = "SkipTimeButton";
            this.SkipTimeButton.Size = new System.Drawing.Size(145, 50);
            this.SkipTimeButton.TabIndex = 4;
            this.SkipTimeButton.Text = "Skip Time";
            this.SkipTimeButton.UseVisualStyleBackColor = true;
            this.SkipTimeButton.Click += new System.EventHandler(this.SkipTimeButton_Click);
            // 
            // FiguresLeftLabel
            // 
            this.FiguresLeftLabel.AutoSize = true;
            this.FiguresLeftLabel.ForeColor = System.Drawing.Color.White;
            this.FiguresLeftLabel.Location = new System.Drawing.Point(16, 15);
            this.FiguresLeftLabel.Name = "FiguresLeftLabel";
            this.FiguresLeftLabel.Size = new System.Drawing.Size(0, 15);
            this.FiguresLeftLabel.TabIndex = 5;
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(993, 617);
            this.Controls.Add(this.FiguresLeftLabel);
            this.Controls.Add(this.SkipTimeButton);
            this.Controls.Add(this.SkipImageButton);
            this.Controls.Add(this.PausePlayButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.figureImage);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.Load += new System.EventHandler(this.FigureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.figureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox figureImage;
        private Label TimeLabel;
        private System.Windows.Forms.Timer FigureTimer;
        private Button PausePlayButton;
        private Button SkipImageButton;
        private Button SkipTimeButton;
        private Label FiguresLeftLabel;
    }
}