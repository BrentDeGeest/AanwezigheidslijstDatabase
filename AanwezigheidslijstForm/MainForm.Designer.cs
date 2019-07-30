namespace AanwezigheidslijstForm
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpleidingenPage = new System.Windows.Forms.TabPage();
            this.OpleidingComboBox = new System.Windows.Forms.ComboBox();
            this.AddDocentButton = new System.Windows.Forms.Button();
            this.AddOpleidingButton = new System.Windows.Forms.Button();
            this.AddDeelnemerButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DocentenPage = new System.Windows.Forms.TabPage();
            this.DeelnemerPage = new System.Windows.Forms.TabPage();
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
            this.AddOplBut = new System.Windows.Forms.Button();
            this.UpdOplBut = new System.Windows.Forms.Button();
            this.DelOplBut = new System.Windows.Forms.Button();
            this.OpleidingList = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.OpleidingenPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpleidingsCodeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.OpleidingenPage);
            this.tabControl1.Controls.Add(this.DocentenPage);
            this.tabControl1.Controls.Add(this.DeelnemerPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 528);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpleidingComboBox);
            this.tabPage1.Controls.Add(this.AddDocentButton);
            this.tabPage1.Controls.Add(this.AddOpleidingButton);
            this.tabPage1.Controls.Add(this.AddDeelnemerButton);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.ViewButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpleidingenPage
            // 
            this.OpleidingenPage.Controls.Add(this.OpleidingList);
            this.OpleidingenPage.Controls.Add(this.DelOplBut);
            this.OpleidingenPage.Controls.Add(this.UpdOplBut);
            this.OpleidingenPage.Controls.Add(this.OpleidingsCodeTextBox);
            this.OpleidingenPage.Controls.Add(this.OeNummerTextBox);
            this.OpleidingenPage.Controls.Add(this.EindDatumTextBox);
            this.OpleidingenPage.Controls.Add(this.StartDatumTextBox);
            this.OpleidingenPage.Controls.Add(this.ReferentieTextBox);
            this.OpleidingenPage.Controls.Add(this.OpleidingsPlaatsTextBox);
            this.OpleidingenPage.Controls.Add(this.ContactPersoonTextBox);
            this.OpleidingenPage.Controls.Add(this.OpleidingTextBox);
            this.OpleidingenPage.Controls.Add(this.OpleidingsInstellingTextBox);
            this.OpleidingenPage.Controls.Add(this.EindDatumPicker);
            this.OpleidingenPage.Controls.Add(this.StartDatumPicker);
            this.OpleidingenPage.Controls.Add(this.OpleidingsCodeNumeric);
            this.OpleidingenPage.Controls.Add(this.OeNumeric);
            this.OpleidingenPage.Controls.Add(this.AddOplBut);
            this.OpleidingenPage.Location = new System.Drawing.Point(4, 29);
            this.OpleidingenPage.Name = "OpleidingenPage";
            this.OpleidingenPage.Padding = new System.Windows.Forms.Padding(3);
            this.OpleidingenPage.Size = new System.Drawing.Size(941, 495);
            this.OpleidingenPage.TabIndex = 1;
            this.OpleidingenPage.Text = "Opleidingen";
            this.OpleidingenPage.UseVisualStyleBackColor = true;
            // 
            // OpleidingComboBox
            // 
            this.OpleidingComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpleidingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingComboBox.FormattingEnabled = true;
            this.OpleidingComboBox.Items.AddRange(new object[] {
            "Opleiding1",
            "Opleiding2",
            "Deelnemers"});
            this.OpleidingComboBox.Location = new System.Drawing.Point(482, 14);
            this.OpleidingComboBox.Name = "OpleidingComboBox";
            this.OpleidingComboBox.Size = new System.Drawing.Size(270, 28);
            this.OpleidingComboBox.TabIndex = 11;
            this.OpleidingComboBox.Text = "Opleiding";
            // 
            // AddDocentButton
            // 
            this.AddDocentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddDocentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDocentButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddDocentButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddDocentButton.Location = new System.Drawing.Point(41, 326);
            this.AddDocentButton.Name = "AddDocentButton";
            this.AddDocentButton.Size = new System.Drawing.Size(160, 35);
            this.AddDocentButton.TabIndex = 10;
            this.AddDocentButton.Text = "Add Docent";
            this.AddDocentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDocentButton.UseVisualStyleBackColor = false;
            // 
            // AddOpleidingButton
            // 
            this.AddOpleidingButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddOpleidingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOpleidingButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddOpleidingButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddOpleidingButton.Location = new System.Drawing.Point(41, 287);
            this.AddOpleidingButton.Name = "AddOpleidingButton";
            this.AddOpleidingButton.Size = new System.Drawing.Size(160, 35);
            this.AddOpleidingButton.TabIndex = 9;
            this.AddOpleidingButton.Text = "Add Opleiding";
            this.AddOpleidingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddOpleidingButton.UseVisualStyleBackColor = false;
            // 
            // AddDeelnemerButton
            // 
            this.AddDeelnemerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddDeelnemerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeelnemerButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddDeelnemerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddDeelnemerButton.Location = new System.Drawing.Point(41, 365);
            this.AddDeelnemerButton.Name = "AddDeelnemerButton";
            this.AddDeelnemerButton.Size = new System.Drawing.Size(160, 35);
            this.AddDeelnemerButton.TabIndex = 8;
            this.AddDeelnemerButton.Text = "Add Deelnemer";
            this.AddDeelnemerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDeelnemerButton.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(482, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 324);
            this.listBox1.TabIndex = 7;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ViewButton.Location = new System.Drawing.Point(41, 74);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(73, 35);
            this.ViewButton.TabIndex = 6;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = false;
            // 
            // DocentenPage
            // 
            this.DocentenPage.Location = new System.Drawing.Point(4, 29);
            this.DocentenPage.Name = "DocentenPage";
            this.DocentenPage.Padding = new System.Windows.Forms.Padding(3);
            this.DocentenPage.Size = new System.Drawing.Size(792, 415);
            this.DocentenPage.TabIndex = 2;
            this.DocentenPage.Text = "Docenten";
            this.DocentenPage.UseVisualStyleBackColor = true;
            // 
            // DeelnemerPage
            // 
            this.DeelnemerPage.Location = new System.Drawing.Point(4, 29);
            this.DeelnemerPage.Name = "DeelnemerPage";
            this.DeelnemerPage.Padding = new System.Windows.Forms.Padding(3);
            this.DeelnemerPage.Size = new System.Drawing.Size(792, 415);
            this.DeelnemerPage.TabIndex = 3;
            this.DeelnemerPage.Text = "Deelnemers";
            this.DeelnemerPage.UseVisualStyleBackColor = true;
            // 
            // OpleidingsCodeTextBox
            // 
            this.OpleidingsCodeTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsCodeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsCodeTextBox.Location = new System.Drawing.Point(20, 235);
            this.OpleidingsCodeTextBox.Name = "OpleidingsCodeTextBox";
            this.OpleidingsCodeTextBox.ReadOnly = true;
            this.OpleidingsCodeTextBox.Size = new System.Drawing.Size(184, 26);
            this.OpleidingsCodeTextBox.TabIndex = 55;
            this.OpleidingsCodeTextBox.Text = "Opleidingscode";
            // 
            // OeNummerTextBox
            // 
            this.OeNummerTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OeNummerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OeNummerTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OeNummerTextBox.Location = new System.Drawing.Point(21, 204);
            this.OeNummerTextBox.Name = "OeNummerTextBox";
            this.OeNummerTextBox.ReadOnly = true;
            this.OeNummerTextBox.Size = new System.Drawing.Size(184, 26);
            this.OeNummerTextBox.TabIndex = 54;
            this.OeNummerTextBox.Text = "Oe nummer";
            // 
            // EindDatumTextBox
            // 
            this.EindDatumTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EindDatumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EindDatumTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EindDatumTextBox.Location = new System.Drawing.Point(363, 202);
            this.EindDatumTextBox.Name = "EindDatumTextBox";
            this.EindDatumTextBox.ReadOnly = true;
            this.EindDatumTextBox.Size = new System.Drawing.Size(200, 26);
            this.EindDatumTextBox.TabIndex = 53;
            this.EindDatumTextBox.Text = "Eind Datum";
            // 
            // StartDatumTextBox
            // 
            this.StartDatumTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StartDatumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatumTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartDatumTextBox.Location = new System.Drawing.Point(363, 129);
            this.StartDatumTextBox.Name = "StartDatumTextBox";
            this.StartDatumTextBox.ReadOnly = true;
            this.StartDatumTextBox.Size = new System.Drawing.Size(200, 26);
            this.StartDatumTextBox.TabIndex = 51;
            this.StartDatumTextBox.Text = "Start Datum";
            // 
            // ReferentieTextBox
            // 
            this.ReferentieTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReferentieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferentieTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ReferentieTextBox.Location = new System.Drawing.Point(20, 166);
            this.ReferentieTextBox.Name = "ReferentieTextBox";
            this.ReferentieTextBox.Size = new System.Drawing.Size(311, 31);
            this.ReferentieTextBox.TabIndex = 47;
            this.ReferentieTextBox.Text = "Referentie opleidingsplaats";
            // 
            // OpleidingsPlaatsTextBox
            // 
            this.OpleidingsPlaatsTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsPlaatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsPlaatsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsPlaatsTextBox.Location = new System.Drawing.Point(20, 129);
            this.OpleidingsPlaatsTextBox.Name = "OpleidingsPlaatsTextBox";
            this.OpleidingsPlaatsTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingsPlaatsTextBox.TabIndex = 46;
            this.OpleidingsPlaatsTextBox.Text = "Opleidingsplaats";
            // 
            // ContactPersoonTextBox
            // 
            this.ContactPersoonTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ContactPersoonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactPersoonTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ContactPersoonTextBox.Location = new System.Drawing.Point(20, 92);
            this.ContactPersoonTextBox.Name = "ContactPersoonTextBox";
            this.ContactPersoonTextBox.Size = new System.Drawing.Size(311, 31);
            this.ContactPersoonTextBox.TabIndex = 45;
            this.ContactPersoonTextBox.Text = "Contactpersoon";
            // 
            // OpleidingTextBox
            // 
            this.OpleidingTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingTextBox.Location = new System.Drawing.Point(20, 55);
            this.OpleidingTextBox.Name = "OpleidingTextBox";
            this.OpleidingTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingTextBox.TabIndex = 44;
            this.OpleidingTextBox.Text = "Opleiding";
            // 
            // OpleidingsInstellingTextBox
            // 
            this.OpleidingsInstellingTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsInstellingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsInstellingTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsInstellingTextBox.Location = new System.Drawing.Point(20, 18);
            this.OpleidingsInstellingTextBox.Name = "OpleidingsInstellingTextBox";
            this.OpleidingsInstellingTextBox.Size = new System.Drawing.Size(311, 31);
            this.OpleidingsInstellingTextBox.TabIndex = 43;
            this.OpleidingsInstellingTextBox.Text = "Opleidingsinstelling";
            // 
            // EindDatumPicker
            // 
            this.EindDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EindDatumPicker.Location = new System.Drawing.Point(363, 236);
            this.EindDatumPicker.Name = "EindDatumPicker";
            this.EindDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.EindDatumPicker.TabIndex = 52;
            // 
            // StartDatumPicker
            // 
            this.StartDatumPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatumPicker.Location = new System.Drawing.Point(363, 163);
            this.StartDatumPicker.Name = "StartDatumPicker";
            this.StartDatumPicker.Size = new System.Drawing.Size(200, 26);
            this.StartDatumPicker.TabIndex = 50;
            // 
            // OpleidingsCodeNumeric
            // 
            this.OpleidingsCodeNumeric.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OpleidingsCodeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingsCodeNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingsCodeNumeric.Location = new System.Drawing.Point(211, 235);
            this.OpleidingsCodeNumeric.Name = "OpleidingsCodeNumeric";
            this.OpleidingsCodeNumeric.Size = new System.Drawing.Size(120, 26);
            this.OpleidingsCodeNumeric.TabIndex = 49;
            // 
            // OeNumeric
            // 
            this.OeNumeric.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OeNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OeNumeric.Location = new System.Drawing.Point(211, 203);
            this.OeNumeric.Name = "OeNumeric";
            this.OeNumeric.Size = new System.Drawing.Size(120, 26);
            this.OeNumeric.TabIndex = 48;
            // 
            // AddOplBut
            // 
            this.AddOplBut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddOplBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOplBut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddOplBut.Location = new System.Drawing.Point(20, 454);
            this.AddOplBut.Name = "AddOplBut";
            this.AddOplBut.Size = new System.Drawing.Size(85, 35);
            this.AddOplBut.TabIndex = 42;
            this.AddOplBut.Text = "Add";
            this.AddOplBut.UseVisualStyleBackColor = false;
            this.AddOplBut.Click += new System.EventHandler(this.AddOplBut_Click);
            // 
            // UpdOplBut
            // 
            this.UpdOplBut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdOplBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdOplBut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UpdOplBut.Location = new System.Drawing.Point(111, 454);
            this.UpdOplBut.Name = "UpdOplBut";
            this.UpdOplBut.Size = new System.Drawing.Size(85, 35);
            this.UpdOplBut.TabIndex = 56;
            this.UpdOplBut.Text = "Update";
            this.UpdOplBut.UseVisualStyleBackColor = false;
            // 
            // DelOplBut
            // 
            this.DelOplBut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DelOplBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelOplBut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DelOplBut.Location = new System.Drawing.Point(202, 454);
            this.DelOplBut.Name = "DelOplBut";
            this.DelOplBut.Size = new System.Drawing.Size(85, 35);
            this.DelOplBut.TabIndex = 57;
            this.DelOplBut.Text = "Delete";
            this.DelOplBut.UseVisualStyleBackColor = false;
            this.DelOplBut.Click += new System.EventHandler(this.DelOplBut_Click);
            // 
            // OpleidingList
            // 
            this.OpleidingList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpleidingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OpleidingList.FormattingEnabled = true;
            this.OpleidingList.ItemHeight = 20;
            this.OpleidingList.Location = new System.Drawing.Point(647, 6);
            this.OpleidingList.Name = "OpleidingList";
            this.OpleidingList.Size = new System.Drawing.Size(288, 484);
            this.OpleidingList.TabIndex = 58;
            this.OpleidingList.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(954, 543);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Aanwezigheidslijst";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.OpleidingenPage.ResumeLayout(false);
            this.OpleidingenPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpleidingsCodeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox OpleidingComboBox;
        private System.Windows.Forms.Button AddDocentButton;
        private System.Windows.Forms.Button AddOpleidingButton;
        private System.Windows.Forms.Button AddDeelnemerButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.TabPage OpleidingenPage;
        private System.Windows.Forms.TabPage DocentenPage;
        private System.Windows.Forms.TabPage DeelnemerPage;
        private System.Windows.Forms.ListBox OpleidingList;
        private System.Windows.Forms.Button DelOplBut;
        private System.Windows.Forms.Button UpdOplBut;
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
        private System.Windows.Forms.Button AddOplBut;
    }
}

