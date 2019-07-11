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
            // AddOpleidingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddOpleidingButton);
            this.Name = "AddOpleidingForm";
            this.Text = "AddOpleidingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddOpleidingButton;
    }
}