namespace AanwezigheidslijstForm
{
    partial class AddDeelnemerForm
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
            this.AddDeelnemerButton = new System.Windows.Forms.Button();
            this.VoornaamTextBox = new System.Windows.Forms.RichTextBox();
            this.AchternaamTextBox = new System.Windows.Forms.RichTextBox();
            this.WoonplaatsTextBox = new System.Windows.Forms.RichTextBox();
            this.GeboorteDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.GeboorteDatumTextBox = new System.Windows.Forms.TextBox();
            this.BadgeNummerPicker = new System.Windows.Forms.NumericUpDown();
            this.BadgeNummerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpleidingComboBox = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeNummerPicker)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDeelnemerButton
            // 
            this.AddDeelnemerButton.Location = new System.Drawing.Point(12, 375);
            this.AddDeelnemerButton.Name = "AddDeelnemerButton";
            this.AddDeelnemerButton.Size = new System.Drawing.Size(87, 36);
            this.AddDeelnemerButton.TabIndex = 0;
            this.AddDeelnemerButton.Text = "Add";
            this.AddDeelnemerButton.UseVisualStyleBackColor = true;
            this.AddDeelnemerButton.Click += new System.EventHandler(this.AddDeelnemerButton_Click);
            // 
            // VoornaamTextBox
            // 
            this.VoornaamTextBox.Location = new System.Drawing.Point(12, 134);
            this.VoornaamTextBox.Name = "VoornaamTextBox";
            this.VoornaamTextBox.Size = new System.Drawing.Size(270, 37);
            this.VoornaamTextBox.TabIndex = 1;
            this.VoornaamTextBox.Text = "Voornaam";
            // 
            // AchternaamTextBox
            // 
            this.AchternaamTextBox.Location = new System.Drawing.Point(12, 177);
            this.AchternaamTextBox.Name = "AchternaamTextBox";
            this.AchternaamTextBox.Size = new System.Drawing.Size(270, 37);
            this.AchternaamTextBox.TabIndex = 2;
            this.AchternaamTextBox.Text = "Achternaam";
            // 
            // WoonplaatsTextBox
            // 
            this.WoonplaatsTextBox.Location = new System.Drawing.Point(12, 252);
            this.WoonplaatsTextBox.Name = "WoonplaatsTextBox";
            this.WoonplaatsTextBox.Size = new System.Drawing.Size(270, 37);
            this.WoonplaatsTextBox.TabIndex = 3;
            this.WoonplaatsTextBox.Text = "Woonplaats";
            // 
            // GeboorteDatumPicker
            // 
            this.GeboorteDatumPicker.Location = new System.Drawing.Point(154, 220);
            this.GeboorteDatumPicker.Name = "GeboorteDatumPicker";
            this.GeboorteDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.GeboorteDatumPicker.TabIndex = 4;
            // 
            // GeboorteDatumTextBox
            // 
            this.GeboorteDatumTextBox.Location = new System.Drawing.Point(12, 220);
            this.GeboorteDatumTextBox.Name = "GeboorteDatumTextBox";
            this.GeboorteDatumTextBox.ReadOnly = true;
            this.GeboorteDatumTextBox.Size = new System.Drawing.Size(136, 26);
            this.GeboorteDatumTextBox.TabIndex = 6;
            this.GeboorteDatumTextBox.Text = "GeboorteDatum";
            // 
            // BadgeNummerPicker
            // 
            this.BadgeNummerPicker.Location = new System.Drawing.Point(154, 295);
            this.BadgeNummerPicker.Name = "BadgeNummerPicker";
            this.BadgeNummerPicker.Size = new System.Drawing.Size(120, 26);
            this.BadgeNummerPicker.TabIndex = 7;
            // 
            // BadgeNummerTextBox
            // 
            this.BadgeNummerTextBox.Location = new System.Drawing.Point(12, 295);
            this.BadgeNummerTextBox.Name = "BadgeNummerTextBox";
            this.BadgeNummerTextBox.ReadOnly = true;
            this.BadgeNummerTextBox.Size = new System.Drawing.Size(136, 26);
            this.BadgeNummerTextBox.TabIndex = 8;
            this.BadgeNummerTextBox.Text = "Badge Nummer";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpleidingComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 37);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpleidingComboBox
            // 
            this.OpleidingComboBox.Items.AddRange(new object[] {
            "Opleiding1",
            "Opleiding2"});
            this.OpleidingComboBox.Name = "OpleidingComboBox";
            this.OpleidingComboBox.Size = new System.Drawing.Size(121, 33);
            this.OpleidingComboBox.Text = "Opleiding";
            this.OpleidingComboBox.Click += new System.EventHandler(this.OpleidingComboBox_Click);
            // 
            // AddDeelnemerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.BadgeNummerTextBox);
            this.Controls.Add(this.BadgeNummerPicker);
            this.Controls.Add(this.GeboorteDatumTextBox);
            this.Controls.Add(this.GeboorteDatumPicker);
            this.Controls.Add(this.WoonplaatsTextBox);
            this.Controls.Add(this.AchternaamTextBox);
            this.Controls.Add(this.VoornaamTextBox);
            this.Controls.Add(this.AddDeelnemerButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddDeelnemerForm";
            this.Text = "AddDeelnemerForm";
            ((System.ComponentModel.ISupportInitialize)(this.BadgeNummerPicker)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDeelnemerButton;
        private System.Windows.Forms.RichTextBox VoornaamTextBox;
        private System.Windows.Forms.RichTextBox AchternaamTextBox;
        private System.Windows.Forms.RichTextBox WoonplaatsTextBox;
        private System.Windows.Forms.DateTimePicker GeboorteDatumPicker;
        private System.Windows.Forms.TextBox GeboorteDatumTextBox;
        private System.Windows.Forms.NumericUpDown BadgeNummerPicker;
        private System.Windows.Forms.TextBox BadgeNummerTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox OpleidingComboBox;
    }
}