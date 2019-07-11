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
            this.ViewButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddDeelnemerButton = new System.Windows.Forms.Button();
            this.AddOpleidingButton = new System.Windows.Forms.Button();
            this.AddDocentButton = new System.Windows.Forms.Button();
            this.OpleidingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(77, 89);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(102, 33);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(511, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 324);
            this.listBox1.TabIndex = 1;
            // 
            // AddDeelnemerButton
            // 
            this.AddDeelnemerButton.Location = new System.Drawing.Point(77, 380);
            this.AddDeelnemerButton.Name = "AddDeelnemerButton";
            this.AddDeelnemerButton.Size = new System.Drawing.Size(137, 33);
            this.AddDeelnemerButton.TabIndex = 2;
            this.AddDeelnemerButton.Text = "Add Deelnemer";
            this.AddDeelnemerButton.UseVisualStyleBackColor = true;
            this.AddDeelnemerButton.Click += new System.EventHandler(this.AddDeelnemerButton_Click);
            // 
            // AddOpleidingButton
            // 
            this.AddOpleidingButton.Location = new System.Drawing.Point(77, 302);
            this.AddOpleidingButton.Name = "AddOpleidingButton";
            this.AddOpleidingButton.Size = new System.Drawing.Size(137, 33);
            this.AddOpleidingButton.TabIndex = 3;
            this.AddOpleidingButton.Text = "Add Opleiding";
            this.AddOpleidingButton.UseVisualStyleBackColor = true;
            this.AddOpleidingButton.Click += new System.EventHandler(this.AddOpleidingButton_Click);
            // 
            // AddDocentButton
            // 
            this.AddDocentButton.Location = new System.Drawing.Point(77, 341);
            this.AddDocentButton.Name = "AddDocentButton";
            this.AddDocentButton.Size = new System.Drawing.Size(137, 33);
            this.AddDocentButton.TabIndex = 4;
            this.AddDocentButton.Text = "Add Docent";
            this.AddDocentButton.UseVisualStyleBackColor = true;
            this.AddDocentButton.Click += new System.EventHandler(this.AddDocentButton_Click);
            // 
            // OpleidingComboBox
            // 
            this.OpleidingComboBox.FormattingEnabled = true;
            this.OpleidingComboBox.Items.AddRange(new object[] {
            "Opleiding1",
            "Opleiding2",
            "Deelnemers"});
            this.OpleidingComboBox.Location = new System.Drawing.Point(511, 29);
            this.OpleidingComboBox.Name = "OpleidingComboBox";
            this.OpleidingComboBox.Size = new System.Drawing.Size(121, 28);
            this.OpleidingComboBox.TabIndex = 5;
            this.OpleidingComboBox.Text = "Opleiding";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpleidingComboBox);
            this.Controls.Add(this.AddDocentButton);
            this.Controls.Add(this.AddOpleidingButton);
            this.Controls.Add(this.AddDeelnemerButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ViewButton);
            this.Name = "MainForm";
            this.Text = "Aanwezigheidslijst";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddDeelnemerButton;
        private System.Windows.Forms.Button AddOpleidingButton;
        private System.Windows.Forms.Button AddDocentButton;
        private System.Windows.Forms.ComboBox OpleidingComboBox;
    }
}

