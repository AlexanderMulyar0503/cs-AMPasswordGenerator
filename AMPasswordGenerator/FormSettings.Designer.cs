namespace AMPasswordGenerator
{
    partial class FormSettings
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
            this.groupPosition = new System.Windows.Forms.GroupBox();
            this.labelPositionX = new System.Windows.Forms.Label();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.positionX = new System.Windows.Forms.NumericUpDown();
            this.positionY = new System.Windows.Forms.NumericUpDown();
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.labelFormWidth = new System.Windows.Forms.Label();
            this.labelFormHeight = new System.Windows.Forms.Label();
            this.formWidth = new System.Windows.Forms.NumericUpDown();
            this.formHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionY)).BeginInit();
            this.groupSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPosition
            // 
            this.groupPosition.Controls.Add(this.positionY);
            this.groupPosition.Controls.Add(this.positionX);
            this.groupPosition.Controls.Add(this.labelPositionY);
            this.groupPosition.Controls.Add(this.labelPositionX);
            this.groupPosition.Location = new System.Drawing.Point(12, 12);
            this.groupPosition.Name = "groupPosition";
            this.groupPosition.Size = new System.Drawing.Size(150, 99);
            this.groupPosition.TabIndex = 0;
            this.groupPosition.TabStop = false;
            this.groupPosition.Text = "Положение";
            // 
            // labelPositionX
            // 
            this.labelPositionX.AutoSize = true;
            this.labelPositionX.Location = new System.Drawing.Point(6, 26);
            this.labelPositionX.Name = "labelPositionX";
            this.labelPositionX.Size = new System.Drawing.Size(14, 13);
            this.labelPositionX.TabIndex = 0;
            this.labelPositionX.Text = "X";
            // 
            // labelPositionY
            // 
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.Location = new System.Drawing.Point(6, 67);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(14, 13);
            this.labelPositionY.TabIndex = 1;
            this.labelPositionY.Text = "Y";
            // 
            // positionX
            // 
            this.positionX.Location = new System.Drawing.Point(84, 26);
            this.positionX.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(60, 20);
            this.positionX.TabIndex = 2;
            // 
            // positionY
            // 
            this.positionY.Location = new System.Drawing.Point(84, 65);
            this.positionY.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(60, 20);
            this.positionY.TabIndex = 3;
            // 
            // groupSize
            // 
            this.groupSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSize.Controls.Add(this.formHeight);
            this.groupSize.Controls.Add(this.formWidth);
            this.groupSize.Controls.Add(this.labelFormHeight);
            this.groupSize.Controls.Add(this.labelFormWidth);
            this.groupSize.Location = new System.Drawing.Point(168, 12);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(150, 99);
            this.groupSize.TabIndex = 1;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Размер";
            // 
            // labelFormWidth
            // 
            this.labelFormWidth.AutoSize = true;
            this.labelFormWidth.Location = new System.Drawing.Point(6, 26);
            this.labelFormWidth.Name = "labelFormWidth";
            this.labelFormWidth.Size = new System.Drawing.Size(46, 13);
            this.labelFormWidth.TabIndex = 0;
            this.labelFormWidth.Text = "Ширина";
            // 
            // labelFormHeight
            // 
            this.labelFormHeight.AutoSize = true;
            this.labelFormHeight.Location = new System.Drawing.Point(6, 67);
            this.labelFormHeight.Name = "labelFormHeight";
            this.labelFormHeight.Size = new System.Drawing.Size(45, 13);
            this.labelFormHeight.TabIndex = 1;
            this.labelFormHeight.Text = "Высота";
            // 
            // formWidth
            // 
            this.formWidth.Location = new System.Drawing.Point(84, 26);
            this.formWidth.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.formWidth.Name = "formWidth";
            this.formWidth.Size = new System.Drawing.Size(60, 20);
            this.formWidth.TabIndex = 2;
            // 
            // formHeight
            // 
            this.formHeight.Location = new System.Drawing.Point(84, 65);
            this.formHeight.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.formHeight.Name = "formHeight";
            this.formHeight.Size = new System.Drawing.Size(60, 20);
            this.formHeight.TabIndex = 3;
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefault.Location = new System.Drawing.Point(12, 117);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(150, 23);
            this.buttonDefault.TabIndex = 2;
            this.buttonDefault.Text = "По умолчанию";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(168, 117);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(73, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(245, 117);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(73, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 151);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.groupSize);
            this.Controls.Add(this.groupPosition);
            this.Name = "FormSettings";
            this.Text = "Параметры";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupPosition.ResumeLayout(false);
            this.groupPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionY)).EndInit();
            this.groupSize.ResumeLayout(false);
            this.groupSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPosition;
        private System.Windows.Forms.Label labelPositionY;
        private System.Windows.Forms.Label labelPositionX;
        private System.Windows.Forms.GroupBox groupSize;
        private System.Windows.Forms.Label labelFormHeight;
        private System.Windows.Forms.Label labelFormWidth;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.NumericUpDown positionX;
        public System.Windows.Forms.NumericUpDown positionY;
        public System.Windows.Forms.NumericUpDown formHeight;
        public System.Windows.Forms.NumericUpDown formWidth;
    }
}