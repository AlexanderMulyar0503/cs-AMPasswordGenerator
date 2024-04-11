namespace AMPasswordGenerator
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.programName = new System.Windows.Forms.Label();
            this.programDescription = new System.Windows.Forms.Label();
            this.programCopyright = new System.Windows.Forms.Label();
            this.programIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programName.Location = new System.Drawing.Point(12, 9);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(224, 24);
            this.programName.TabIndex = 0;
            this.programName.Text = "AMPasswordGenerator";
            // 
            // programDescription
            // 
            this.programDescription.AutoSize = true;
            this.programDescription.Location = new System.Drawing.Point(12, 33);
            this.programDescription.Name = "programDescription";
            this.programDescription.Size = new System.Drawing.Size(194, 16);
            this.programDescription.TabIndex = 1;
            this.programDescription.Text = "Простой генератор паролей";
            // 
            // programCopyright
            // 
            this.programCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.programCopyright.AutoSize = true;
            this.programCopyright.Location = new System.Drawing.Point(13, 256);
            this.programCopyright.Name = "programCopyright";
            this.programCopyright.Size = new System.Drawing.Size(153, 16);
            this.programCopyright.TabIndex = 2;
            this.programCopyright.Text = "© 2024 Alexander Mulyar";
            // 
            // programIcon
            // 
            this.programIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.programIcon.Image = ((System.Drawing.Image)(resources.GetObject("programIcon.Image")));
            this.programIcon.Location = new System.Drawing.Point(324, 12);
            this.programIcon.Name = "programIcon";
            this.programIcon.Size = new System.Drawing.Size(128, 128);
            this.programIcon.TabIndex = 3;
            this.programIcon.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.programIcon);
            this.Controls.Add(this.programCopyright);
            this.Controls.Add(this.programDescription);
            this.Controls.Add(this.programName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.Label programDescription;
        private System.Windows.Forms.Label programCopyright;
        private System.Windows.Forms.PictureBox programIcon;
    }
}