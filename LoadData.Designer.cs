namespace Posers
{
    partial class LoadData
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
            this.ConfigurationLoadLabel = new System.Windows.Forms.Label();
            this.ConfigListbox = new System.Windows.Forms.ListBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfigurationLoadLabel
            // 
            this.ConfigurationLoadLabel.AutoSize = true;
            this.ConfigurationLoadLabel.Location = new System.Drawing.Point(11, 16);
            this.ConfigurationLoadLabel.Name = "ConfigurationLoadLabel";
            this.ConfigurationLoadLabel.Size = new System.Drawing.Size(165, 15);
            this.ConfigurationLoadLabel.TabIndex = 0;
            this.ConfigurationLoadLabel.Text = "Select a configuration to load:";
            // 
            // ConfigListbox
            // 
            this.ConfigListbox.FormattingEnabled = true;
            this.ConfigListbox.ItemHeight = 15;
            this.ConfigListbox.Location = new System.Drawing.Point(11, 34);
            this.ConfigListbox.Name = "ConfigListbox";
            this.ConfigListbox.Size = new System.Drawing.Size(486, 154);
            this.ConfigListbox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(11, 204);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(111, 44);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(386, 204);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 44);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 260);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ConfigListbox);
            this.Controls.Add(this.ConfigurationLoadLabel);
            this.Name = "LoadData";
            this.Text = "LoadData";
            this.Load += new System.EventHandler(this.LoadData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ConfigurationLoadLabel;
        private ListBox ConfigListbox;
        private Button OkButton;
        private Button CancelButton;
    }
}