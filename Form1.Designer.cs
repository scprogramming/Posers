namespace Posers
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PickImageFolderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImagesFoundLabel = new System.Windows.Forms.Label();
            this.FolderPathText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SessionOptionList = new System.Windows.Forms.ListView();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.Unit = new System.Windows.Forms.ColumnHeader();
            this.AddButton = new System.Windows.Forms.Button();
            this.TimeUnitCombo = new System.Windows.Forms.ComboBox();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SaveConfigurationButton = new System.Windows.Forms.Button();
            this.LoadConfigurationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PickImageFolderButton
            // 
            this.PickImageFolderButton.Location = new System.Drawing.Point(491, 31);
            this.PickImageFolderButton.Name = "PickImageFolderButton";
            this.PickImageFolderButton.Size = new System.Drawing.Size(122, 35);
            this.PickImageFolderButton.TabIndex = 0;
            this.PickImageFolderButton.Text = "Pick Image Folder";
            this.PickImageFolderButton.UseVisualStyleBackColor = true;
            this.PickImageFolderButton.Click += new System.EventHandler(this.PickImageFolderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImagesFoundLabel);
            this.groupBox1.Controls.Add(this.FolderPathText);
            this.groupBox1.Controls.Add(this.PickImageFolderButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a folder of images to practice";
            // 
            // ImagesFoundLabel
            // 
            this.ImagesFoundLabel.AutoSize = true;
            this.ImagesFoundLabel.Location = new System.Drawing.Point(6, 64);
            this.ImagesFoundLabel.Name = "ImagesFoundLabel";
            this.ImagesFoundLabel.Size = new System.Drawing.Size(0, 15);
            this.ImagesFoundLabel.TabIndex = 2;
            // 
            // FolderPathText
            // 
            this.FolderPathText.Location = new System.Drawing.Point(6, 38);
            this.FolderPathText.Name = "FolderPathText";
            this.FolderPathText.ReadOnly = true;
            this.FolderPathText.Size = new System.Drawing.Size(454, 23);
            this.FolderPathText.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SessionOptionList);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.TimeUnitCombo);
            this.groupBox2.Controls.Add(this.TimeText);
            this.groupBox2.Controls.Add(this.TimeLabel);
            this.groupBox2.Controls.Add(this.QuantityText);
            this.groupBox2.Controls.Add(this.QuantityLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customize your session";
            // 
            // SessionOptionList
            // 
            this.SessionOptionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quantity,
            this.Time,
            this.Unit});
            this.SessionOptionList.Location = new System.Drawing.Point(6, 21);
            this.SessionOptionList.Name = "SessionOptionList";
            this.SessionOptionList.Size = new System.Drawing.Size(607, 97);
            this.SessionOptionList.TabIndex = 4;
            this.SessionOptionList.UseCompatibleStateImageBehavior = false;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Time
            // 
            this.Time.Text = "Time";
            // 
            // Unit
            // 
            this.Unit.Text = "Unit";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(491, 125);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 29);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TimeUnitCombo
            // 
            this.TimeUnitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeUnitCombo.FormattingEnabled = true;
            this.TimeUnitCombo.Items.AddRange(new object[] {
            "Seconds",
            "Minutes"});
            this.TimeUnitCombo.Location = new System.Drawing.Point(267, 130);
            this.TimeUnitCombo.Name = "TimeUnitCombo";
            this.TimeUnitCombo.Size = new System.Drawing.Size(121, 23);
            this.TimeUnitCombo.TabIndex = 4;
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(200, 131);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(61, 23);
            this.TimeText.TabIndex = 3;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(158, 134);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(36, 15);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time:";
            // 
            // QuantityText
            // 
            this.QuantityText.Location = new System.Drawing.Point(68, 131);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(61, 23);
            this.QuantityText.TabIndex = 2;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(6, 134);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(56, 15);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(279, 379);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(102, 42);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SaveConfigurationButton
            // 
            this.SaveConfigurationButton.Location = new System.Drawing.Point(12, 292);
            this.SaveConfigurationButton.Name = "SaveConfigurationButton";
            this.SaveConfigurationButton.Size = new System.Drawing.Size(129, 37);
            this.SaveConfigurationButton.TabIndex = 4;
            this.SaveConfigurationButton.Text = "Save Configuration";
            this.SaveConfigurationButton.UseVisualStyleBackColor = true;
            this.SaveConfigurationButton.Click += new System.EventHandler(this.SaveConfigurationButton_Click);
            // 
            // LoadConfigurationButton
            // 
            this.LoadConfigurationButton.Location = new System.Drawing.Point(170, 292);
            this.LoadConfigurationButton.Name = "LoadConfigurationButton";
            this.LoadConfigurationButton.Size = new System.Drawing.Size(129, 37);
            this.LoadConfigurationButton.TabIndex = 5;
            this.LoadConfigurationButton.Text = "Load Configuration";
            this.LoadConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 433);
            this.Controls.Add(this.LoadConfigurationButton);
            this.Controls.Add(this.SaveConfigurationButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Posers";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button PickImageFolderButton;
        private GroupBox groupBox1;
        private TextBox FolderPathText;
        private Label ImagesFoundLabel;
        private GroupBox groupBox2;
        private Label QuantityLabel;
        private TextBox QuantityText;
        private Label TimeLabel;
        private TextBox TimeText;
        private ComboBox TimeUnitCombo;
        private Button AddButton;
        private Button StartButton;
        private ListView SessionOptionList;
        private ColumnHeader Quantity;
        private ColumnHeader Time;
        private ColumnHeader Unit;
        private Button SaveConfigurationButton;
        private Button LoadConfigurationButton;
    }
}