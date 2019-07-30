namespace AanwezigheidslijstForm
{
    partial class OpleidingForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpleidingsCodeTextBox = new System.Windows.Forms.TextBox();
            this.OeNummerTextBox = new System.Windows.Forms.TextBox();
            this.EindDatumTextBox = new System.Windows.Forms.TextBox();
            this.StartDatumTextBox = new System.Windows.Forms.TextBox();
            this.ReferentieTextBox = new System.Windows.Forms.RichTextBox();
            this.OpleidingsPlaatsTextBox = new System.Windows.Forms.RichTextBox();
            this.ContactPersoonTextBox = new System.Windows.Forms.RichTextBox();
            this.OpleidingTextBox = new System.Windows.Forms.RichTextBox();
            this.OpleidingsInstellingTextBox = new System.Windows.Forms.RichTextBox();
            this.EindDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.OpleidingsCodeNumeric = new System.Windows.Forms.NumericUpDown();
            this.OeNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddOpleidingButton = new System.Windows.Forms.Button();
            this.Toevoegen = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpleidingsCodeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OeNumeric)).BeginInit();
            this.Toevoegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpleidingsCodeTextBox);
            this.tabPage1.Controls.Add(this.OeNummerTextBox);
            this.tabPage1.Controls.Add(this.EindDatumTextBox);
            this.tabPage1.Controls.Add(this.StartDatumTextBox);
            this.tabPage1.Controls.Add(this.ReferentieTextBox);
            this.tabPage1.Controls.Add(this.OpleidingsPlaatsTextBox);
            this.tabPage1.Controls.Add(this.ContactPersoonTextBox);
            this.tabPage1.Controls.Add(this.OpleidingTextBox);
            this.tabPage1.Controls.Add(this.OpleidingsInstellingTextBox);
            this.tabPage1.Controls.Add(this.EindDatumPicker);
            this.tabPage1.Controls.Add(this.StartDatumPicker);
            this.tabPage1.Controls.Add(this.OpleidingsCodeNumeric);
            this.tabPage1.Controls.Add(this.OeNumeric);
            this.tabPage1.Controls.Add(this.AddOpleidingButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opleiding toevoegen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpleidingsCodeTextBox
            // 
            this.OpleidingsCodeTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsCodeTextBox.Location = new System.Drawing.Point(8, 252);
            this.OpleidingsCodeTextBox.Name = "OpleidingsCodeTextBox";
            this.OpleidingsCodeTextBox.ReadOnly = true;
            this.OpleidingsCodeTextBox.Size = new System.Drawing.Size(184, 26);
            this.OpleidingsCodeTextBox.TabIndex = 41;
            this.OpleidingsCodeTextBox.Text = "Opleidingscode";
            // 
            // OeNummerTextBox
            // 
            this.OeNummerTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OeNummerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OeNummerTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OeNummerTextBox.Location = new System.Drawing.Point(9, 221);
            this.OeNummerTextBox.Name = "OeNummerTextBox";
            this.OeNummerTextBox.ReadOnly = true;
            this.OeNummerTextBox.Size = new System.Drawing.Size(184, 26);
            this.OeNummerTextBox.TabIndex = 40;
            this.OeNummerTextBox.Text = "Oe nummer";
            // 
            // EindDatumTextBox
            // 
            this.EindDatumTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EindDatumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EindDatumTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EindDatumTextBox.Location = new System.Drawing.Point(351, 219);
            this.EindDatumTextBox.Name = "EindDatumTextBox";
            this.EindDatumTextBox.ReadOnly = true;
            this.EindDatumTextBox.Size = new System.Drawing.Size(200, 26);
            this.EindDatumTextBox.TabIndex = 39;
            this.EindDatumTextBox.Text = "Eind Datum";
            // 
            // StartDatumTextBox
            // 
            this.StartDatumTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StartDatumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatumTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartDatumTextBox.Location = new System.Drawing.Point(351, 146);
            this.StartDatumTextBox.Name = "StartDatumTextBox";
            this.StartDatumTextBox.ReadOnly = true;
            this.StartDatumTextBox.Size = new System.Drawing.Size(200, 26);
            this.StartDatumTextBox.TabIndex = 37;
            this.StartDatumTextBox.Text = "Start Datum";
            // 
            // ReferentieTextBox
            // 
            this.ReferentieTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReferentieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferentieTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReferentieTextBox.Location = new System.Drawing.Point(8, 183);
            this.ReferentieTextBox.Name = "ReferentieTextBox";
            this.ReferentieTextBox.Size = new System.Drawing.Size(311, 31);
            this.ReferentieTextBox.TabIndex = 33;
            this.ReferentieTextBox.Text = "Referentie opleidingsplaats";
            // 
            // OpleidingsPlaatsTextBox
            // 
            this.OpleidingsPlaatsTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsPlaatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsPlaatsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsPlaatsTextBox.Location = new System.Drawing.Point(8, 146);
            this.OpleidingsPlaatsTextBox.Name = "OpleidingsPlaatsTextBox";
            this.OpleidingsPlaatsTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingsPlaatsTextBox.TabIndex = 32;
            this.OpleidingsPlaatsTextBox.Text = "Opleidingsplaats";
            // 
            // ContactPersoonTextBox
            // 
            this.ContactPersoonTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ContactPersoonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactPersoonTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ContactPersoonTextBox.Location = new System.Drawing.Point(8, 109);
            this.ContactPersoonTextBox.Name = "ContactPersoonTextBox";
            this.ContactPersoonTextBox.Size = new System.Drawing.Size(311, 31);
            this.ContactPersoonTextBox.TabIndex = 31;
            this.ContactPersoonTextBox.Text = "Contactpersoon";
            // 
            // OpleidingTextBox
            // 
            this.OpleidingTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingTextBox.Location = new System.Drawing.Point(8, 72);
            this.OpleidingTextBox.Name = "OpleidingTextBox";
            this.OpleidingTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingTextBox.TabIndex = 30;
            this.OpleidingTextBox.Text = "Opleiding";
            // 
            // OpleidingsInstellingTextBox
            // 
            this.OpleidingsInstellingTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsInstellingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsInstellingTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsInstellingTextBox.Location = new System.Drawing.Point(8, 35);
            this.OpleidingsInstellingTextBox.Name = "OpleidingsInstellingTextBox";
            this.OpleidingsInstellingTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingsInstellingTextBox.TabIndex = 29;
            this.OpleidingsInstellingTextBox.Text = "Opleidingsinstelling";
            // 
            // EindDatumPicker
            // 
            this.EindDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EindDatumPicker.Location = new System.Drawing.Point(351, 253);
            this.EindDatumPicker.Name = "EindDatumPicker";
            this.EindDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.EindDatumPicker.TabIndex = 38;
            // 
            // StartDatumPicker
            // 
            this.StartDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatumPicker.Location = new System.Drawing.Point(351, 180);
            this.StartDatumPicker.Name = "StartDatumPicker";
            this.StartDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.StartDatumPicker.TabIndex = 36;
            // 
            // OpleidingsCodeNumeric
            // 
            this.OpleidingsCodeNumeric.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsCodeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsCodeNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsCodeNumeric.Location = new System.Drawing.Point(199, 252);
            this.OpleidingsCodeNumeric.Name = "OpleidingsCodeNumeric";
            this.OpleidingsCodeNumeric.Size = new System.Drawing.Size(120, 26);
            this.OpleidingsCodeNumeric.TabIndex = 35;
            // 
            // OeNumeric
            // 
            this.OeNumeric.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OeNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OeNumeric.Location = new System.Drawing.Point(199, 220);
            this.OeNumeric.Name = "OeNumeric";
            this.OeNumeric.Size = new System.Drawing.Size(120, 26);
            this.OeNumeric.TabIndex = 34;
            // 
            // AddOpleidingButton
            // 
            this.AddOpleidingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddOpleidingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOpleidingButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddOpleidingButton.Location = new System.Drawing.Point(8, 324);
            this.AddOpleidingButton.Name = "AddOpleidingButton";
            this.AddOpleidingButton.Size = new System.Drawing.Size(85, 35);
            this.AddOpleidingButton.TabIndex = 28;
            this.AddOpleidingButton.Text = "Add";
            this.AddOpleidingButton.UseVisualStyleBackColor = false;
            this.AddOpleidingButton.Click += new System.EventHandler(this.AddOpleidingButton_Click_2);
            // 
            // Toevoegen
            // 
            this.Toevoegen.Controls.Add(this.tabPage1);
            this.Toevoegen.Controls.Add(this.tabPage2);
            this.Toevoegen.Location = new System.Drawing.Point(0, 0);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.SelectedIndex = 0;
            this.Toevoegen.Size = new System.Drawing.Size(799, 452);
            this.Toevoegen.TabIndex = 14;
            this.Toevoegen.SelectedIndexChanged += new System.EventHandler(this.Toevoegen_SelectedIndexChanged);
            // 
            // OpleidingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Toevoegen);
            this.Name = "OpleidingForm";
            this.Text = "Opleidingen";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpleidingsCodeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OeNumeric)).EndInit();
            this.Toevoegen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Toevoegen;
        private System.Windows.Forms.TextBox OpleidingsCodeTextBox;
        private System.Windows.Forms.TextBox OeNummerTextBox;
        private System.Windows.Forms.TextBox EindDatumTextBox;
        private System.Windows.Forms.TextBox StartDatumTextBox;
        private System.Windows.Forms.RichTextBox ReferentieTextBox;
        private System.Windows.Forms.RichTextBox OpleidingsPlaatsTextBox;
        private System.Windows.Forms.RichTextBox ContactPersoonTextBox;
        private System.Windows.Forms.RichTextBox OpleidingTextBox;
        private System.Windows.Forms.RichTextBox OpleidingsInstellingTextBox;
        private System.Windows.Forms.DateTimePicker EindDatumPicker;
        private System.Windows.Forms.DateTimePicker StartDatumPicker;
        private System.Windows.Forms.NumericUpDown OpleidingsCodeNumeric;
        private System.Windows.Forms.NumericUpDown OeNumeric;
        private System.Windows.Forms.Button AddOpleidingButton;
    }
}