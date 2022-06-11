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
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(875, 577);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 15);
            this.TimeLabel.TabIndex = 1;
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 617);
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
    }
}