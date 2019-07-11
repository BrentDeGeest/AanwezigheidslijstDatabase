namespace AanwezigheidslijstForm
{
    partial class AddOpleidingForm
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
            this.AddOpleidingButton = new System.Windows.Forms.Button();
            this.OpledingsInstellingTextBox = new System.Windows.Forms.RichTextBox();
            this.OpleidingTextBox = new System.Windows.Forms.RichTextBox();
            this.ContactPersoonTextBox = new System.Windows.Forms.RichTextBox();
            this.OpleidingsPlaatsTextBox = new System.Windows.Forms.RichTextBox();
            this.ReferentieTextBox = new System.Windows.Forms.RichTextBox();
            this.OeNumeric = new System.Windows.Forms.NumericUpDown();
            this.OpleidingsCodeNumeric = new System.Windows.Forms.NumericUpDown();
            this.StartDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatumTextBox = new System.Windows.Forms.TextBox();
            this.EindDatumTextBox = new System.Windows.Forms.TextBox();
            this.EindDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.OeNummerTextBox = new System.Windows.Forms.TextBox();
            this.OpleidingsCodeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpleidingsCodeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOpleidingButton
            // 
            this.AddOpleidingButton.Location = new System.Drawing.Point(63, 382);
            this.AddOpleidingButton.Name = "AddOpleidingButton";
            this.AddOpleidingButton.Size = new System.Drawing.Size(85, 35);
            this.AddOpleidingButton.TabIndex = 0;
            this.AddOpleidingButton.Text = "Add";
            this.AddOpleidingButton.UseVisualStyleBackColor = true;
            this.AddOpleidingButton.Click += new System.EventHandler(this.AddOpleidingButton_Click);
            // 
            // OpledingsInstellingTextBox
            // 
            this.OpledingsInstellingTextBox.Location = new System.Drawing.Point(12, 12);
            this.OpledingsInstellingTextBox.Name = "OpledingsInstellingTextBox";
            this.OpledingsInstellingTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpledingsInstellingTextBox.TabIndex = 1;
            this.OpledingsInstellingTextBox.Text = "Opleidingsinstelling";
            // 
            // OpleidingTextBox
            // 
            this.OpleidingTextBox.Location = new System.Drawing.Point(12, 49);
            this.OpleidingTextBox.Name = "OpleidingTextBox";
            this.OpleidingTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingTextBox.TabIndex = 2;
            this.OpleidingTextBox.Text = "Opleiding";
            // 
            // ContactPersoonTextBox
            // 
            this.ContactPersoonTextBox.Location = new System.Drawing.Point(12, 86);
            this.ContactPersoonTextBox.Name = "ContactPersoonTextBox";
            this.ContactPersoonTextBox.Size = new System.Drawing.Size(311, 31);
            this.ContactPersoonTextBox.TabIndex = 3;
            this.ContactPersoonTextBox.Text = "Contactpersoon";
            // 
            // OpleidingsPlaatsTextBox
            // 
            this.OpleidingsPlaatsTextBox.Location = new System.Drawing.Point(12, 123);
            this.OpleidingsPlaatsTextBox.Name = "OpleidingsPlaatsTextBox";
            this.OpleidingsPlaatsTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingsPlaatsTextBox.TabIndex = 4;
            this.OpleidingsPlaatsTextBox.Text = "Opleidingsplaats";
            // 
            // ReferentieTextBox
            // 
            this.ReferentieTextBox.Location = new System.Drawing.Point(12, 160);
            this.ReferentieTextBox.Name = "ReferentieTextBox";
            this.ReferentieTextBox.Size = new System.Drawing.Size(311, 31);
            this.ReferentieTextBox.TabIndex = 5;
            this.ReferentieTextBox.Text = "Referentie opleidingsplaats";
            // 
            // OeNumeric
            // 
            this.OeNumeric.Location = new System.Drawing.Point(203, 197);
            this.OeNumeric.Name = "OeNumeric";
            this.OeNumeric.Size = new System.Drawing.Size(120, 26);
            this.OeNumeric.TabIndex = 6;
            // 
            // OpleidingsCodeNumeric
            // 
            this.OpleidingsCodeNumeric.Location = new System.Drawing.Point(203, 229);
            this.OpleidingsCodeNumeric.Name = "OpleidingsCodeNumeric";
            this.OpleidingsCodeNumeric.Size = new System.Drawing.Size(120, 26);
            this.OpleidingsCodeNumeric.TabIndex = 7;
            // 
            // StartDatumPicker
            // 
            this.StartDatumPicker.Location = new System.Drawing.Point(355, 157);
            this.StartDatumPicker.Name = "StartDatumPicker";
            this.StartDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.StartDatumPicker.TabIndex = 8;
            this.StartDatumPicker.ValueChanged += new System.EventHandler(this.StartDatumPicker_ValueChanged);
            // 
            // StartDatumTextBox
            // 
            this.StartDatumTextBox.Location = new System.Drawing.Point(355, 123);
            this.StartDatumTextBox.Name = "StartDatumTextBox";
            this.StartDatumTextBox.ReadOnly = true;
            this.StartDatumTextBox.Size = new System.Drawing.Size(200, 26);
            this.StartDatumTextBox.TabIndex = 9;
            this.StartDatumTextBox.Text = "Start Datum";
            this.StartDatumTextBox.TextChanged += new System.EventHandler(this.StartDatumTextBox_TextChanged);
            // 
            // EindDatumTextBox
            // 
            this.EindDatumTextBox.Location = new System.Drawing.Point(355, 196);
            this.EindDatumTextBox.Name = "EindDatumTextBox";
            this.EindDatumTextBox.ReadOnly = true;
            this.EindDatumTextBox.Size = new System.Drawing.Size(200, 26);
            this.EindDatumTextBox.TabIndex = 11;
            this.EindDatumTextBox.Text = "Eind Datum";
            this.EindDatumTextBox.TextChanged += new System.EventHandler(this.EindDatumTextBox_TextChanged);
            // 
            // EindDatumPicker
            // 
            this.EindDatumPicker.Location = new System.Drawing.Point(355, 230);
            this.EindDatumPicker.Name = "EindDatumPicker";
            this.EindDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.EindDatumPicker.TabIndex = 10;
            this.EindDatumPicker.ValueChanged += new System.EventHandler(this.EindDatumPicker_ValueChanged);
            // 
            // OeNummerTextBox
            // 
            this.OeNummerTextBox.Location = new System.Drawing.Point(13, 198);
            this.OeNummerTextBox.Name = "OeNummerTextBox";
            this.OeNummerTextBox.ReadOnly = true;
            this.OeNummerTextBox.Size = new System.Drawing.Size(184, 26);
            this.OeNummerTextBox.TabIndex = 12;
            this.OeNummerTextBox.Text = "Oe nummer";
            // 
            // OpleidingsCodeTextBox
            // 
            this.OpleidingsCodeTextBox.Location = new System.Drawing.Point(12, 229);
            this.OpleidingsCodeTextBox.Name = "OpleidingsCodeTextBox";
            this.OpleidingsCodeTextBox.ReadOnly = true;
            this.OpleidingsCodeTextBox.Size = new System.Drawing.Size(184, 26);
            this.OpleidingsCodeTextBox.TabIndex = 13;
            this.OpleidingsCodeTextBox.Text = "Opleidingscode";
            // 
            // AddOpleidingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpleidingsCodeTextBox);
            this.Controls.Add(this.OeNummerTextBox);
            this.Controls.Add(this.EindDatumTextBox);
            this.Controls.Add(this.EindDatumPicker);
            this.Controls.Add(this.StartDatumTextBox);
            this.Controls.Add(this.StartDatumPicker);
            this.Controls.Add(this.OpleidingsCodeNumeric);
            this.Controls.Add(this.OeNumeric);
            this.Controls.Add(this.ReferentieTextBox);
            this.Controls.Add(this.OpleidingsPlaatsTextBox);
            this.Controls.Add(this.ContactPersoonTextBox);
            this.Controls.Add(this.OpleidingTextBox);
            this.Controls.Add(this.OpledingsInstellingTextBox);
            this.Controls.Add(this.AddOpleidingButton);
            this.Name = "AddOpleidingForm";
            this.Text = "AddOpleidingForm";
            ((System.ComponentModel.ISupportInitialize)(this.OeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpleidingsCodeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOpleidingButton;
        private System.Windows.Forms.RichTextBox OpledingsInstellingTextBox;
        private System.Windows.Forms.RichTextBox OpleidingTextBox;
        private System.Windows.Forms.RichTextBox ContactPersoonTextBox;
        private System.Windows.Forms.RichTextBox OpleidingsPlaatsTextBox;
        private System.Windows.Forms.RichTextBox ReferentieTextBox;
        private System.Windows.Forms.NumericUpDown OeNumeric;
        private System.Windows.Forms.NumericUpDown OpleidingsCodeNumeric;
        private System.Windows.Forms.DateTimePicker StartDatumPicker;
        private System.Windows.Forms.TextBox StartDatumTextBox;
        private System.Windows.Forms.TextBox EindDatumTextBox;
        private System.Windows.Forms.DateTimePicker EindDatumPicker;
        private System.Windows.Forms.TextBox OeNummerTextBox;
        private System.Windows.Forms.TextBox OpleidingsCodeTextBox;
    }
}