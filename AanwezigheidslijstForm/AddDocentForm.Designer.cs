namespace AanwezigheidslijstForm
{
    partial class AddDocentForm
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
            this.AddDocentButton = new System.Windows.Forms.Button();
            this.NaamTextBox = new System.Windows.Forms.RichTextBox();
            this.BedrijfTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddDocentButton
            // 
            this.AddDocentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddDocentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDocentButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddDocentButton.Location = new System.Drawing.Point(48, 370);
            this.AddDocentButton.Name = "AddDocentButton";
            this.AddDocentButton.Size = new System.Drawing.Size(87, 36);
            this.AddDocentButton.TabIndex = 0;
            this.AddDocentButton.Text = "Add";
            this.AddDocentButton.UseVisualStyleBackColor = false;
            this.AddDocentButton.Click += new System.EventHandler(this.AddDocentButton_Click);
            // 
            // NaamTextBox
            // 
            this.NaamTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NaamTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaamTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NaamTextBox.Location = new System.Drawing.Point(52, 75);
            this.NaamTextBox.Name = "NaamTextBox";
            this.NaamTextBox.Size = new System.Drawing.Size(316, 38);
            this.NaamTextBox.TabIndex = 1;
            this.NaamTextBox.Text = "Naam";
            // 
            // BedrijfTextBox
            // 
            this.BedrijfTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BedrijfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedrijfTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BedrijfTextBox.Location = new System.Drawing.Point(52, 119);
            this.BedrijfTextBox.Name = "BedrijfTextBox";
            this.BedrijfTextBox.Size = new System.Drawing.Size(316, 38);
            this.BedrijfTextBox.TabIndex = 2;
            this.BedrijfTextBox.Text = "Bedrijf";
            // 
            // AddDocentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BedrijfTextBox);
            this.Controls.Add(this.NaamTextBox);
            this.Controls.Add(this.AddDocentButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "AddDocentForm";
            this.Text = "AddDocentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDocentButton;
        private System.Windows.Forms.RichTextBox NaamTextBox;
        private System.Windows.Forms.RichTextBox BedrijfTextBox;
    }
}