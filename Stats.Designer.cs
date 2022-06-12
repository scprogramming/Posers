namespace Posers
{
    partial class Stats
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
            this.TimeDescLabel = new System.Windows.Forms.Label();
            this.TimeSpentLabel = new System.Windows.Forms.Label();
            this.SessionDescLabel = new System.Windows.Forms.Label();
            this.SessionCountLabel = new System.Windows.Forms.Label();
            this.FiguresDrawnDescLabel = new System.Windows.Forms.Label();
            this.FiguresDrawnLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeDescLabel
            // 
            this.TimeDescLabel.AutoSize = true;
            this.TimeDescLabel.Location = new System.Drawing.Point(31, 32);
            this.TimeDescLabel.Name = "TimeDescLabel";
            this.TimeDescLabel.Size = new System.Drawing.Size(114, 15);
            this.TimeDescLabel.TabIndex = 0;
            this.TimeDescLabel.Text = "Time spent drawing:";
            // 
            // TimeSpentLabel
            // 
            this.TimeSpentLabel.AutoSize = true;
            this.TimeSpentLabel.Location = new System.Drawing.Point(186, 32);
            this.TimeSpentLabel.Name = "TimeSpentLabel";
            this.TimeSpentLabel.Size = new System.Drawing.Size(0, 15);
            this.TimeSpentLabel.TabIndex = 1;
            // 
            // SessionDescLabel
            // 
            this.SessionDescLabel.AutoSize = true;
            this.SessionDescLabel.Location = new System.Drawing.Point(31, 67);
            this.SessionDescLabel.Name = "SessionDescLabel";
            this.SessionDescLabel.Size = new System.Drawing.Size(114, 15);
            this.SessionDescLabel.TabIndex = 2;
            this.SessionDescLabel.Text = "Number of sessions:";
            // 
            // SessionCountLabel
            // 
            this.SessionCountLabel.AutoSize = true;
            this.SessionCountLabel.Location = new System.Drawing.Point(186, 67);
            this.SessionCountLabel.Name = "SessionCountLabel";
            this.SessionCountLabel.Size = new System.Drawing.Size(0, 15);
            this.SessionCountLabel.TabIndex = 3;
            // 
            // FiguresDrawnDescLabel
            // 
            this.FiguresDrawnDescLabel.AutoSize = true;
            this.FiguresDrawnDescLabel.Location = new System.Drawing.Point(31, 102);
            this.FiguresDrawnDescLabel.Name = "FiguresDrawnDescLabel";
            this.FiguresDrawnDescLabel.Size = new System.Drawing.Size(84, 15);
            this.FiguresDrawnDescLabel.TabIndex = 4;
            this.FiguresDrawnDescLabel.Text = "Figures drawn:";
            // 
            // FiguresDrawnLabel
            // 
            this.FiguresDrawnLabel.AutoSize = true;
            this.FiguresDrawnLabel.Location = new System.Drawing.Point(186, 102);
            this.FiguresDrawnLabel.Name = "FiguresDrawnLabel";
            this.FiguresDrawnLabel.Size = new System.Drawing.Size(0, 15);
            this.FiguresDrawnLabel.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(186, 131);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 36);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 179);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FiguresDrawnLabel);
            this.Controls.Add(this.FiguresDrawnDescLabel);
            this.Controls.Add(this.SessionCountLabel);
            this.Controls.Add(this.SessionDescLabel);
            this.Controls.Add(this.TimeSpentLabel);
            this.Controls.Add(this.TimeDescLabel);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TimeDescLabel;
        private Label TimeSpentLabel;
        private Label SessionDescLabel;
        private Label SessionCountLabel;
        private Label FiguresDrawnDescLabel;
        private Label FiguresDrawnLabel;
        private Button CloseButton;
    }
}