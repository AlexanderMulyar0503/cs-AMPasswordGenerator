namespace AMPasswordGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuFormMain = new System.Windows.Forms.MenuStrip();
            this.menuFormMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormMainSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormMainSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFormMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupNum = new System.Windows.Forms.GroupBox();
            this.setNum12 = new System.Windows.Forms.Button();
            this.setNum8 = new System.Windows.Forms.Button();
            this.setNum4 = new System.Windows.Forms.Button();
            this.numChars = new System.Windows.Forms.NumericUpDown();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.typeSpChar = new System.Windows.Forms.CheckBox();
            this.typeDigit = new System.Windows.Forms.CheckBox();
            this.typeCharLow = new System.Windows.Forms.CheckBox();
            this.typeCharUp = new System.Windows.Forms.CheckBox();
            this.groupPassword = new System.Windows.Forms.GroupBox();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.menuFormMain.SuspendLayout();
            this.groupNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChars)).BeginInit();
            this.groupType.SuspendLayout();
            this.groupPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFormMain
            // 
            this.menuFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormMainFile,
            this.menuFormMainHelp});
            this.menuFormMain.Location = new System.Drawing.Point(0, 0);
            this.menuFormMain.Name = "menuFormMain";
            this.menuFormMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuFormMain.Size = new System.Drawing.Size(334, 24);
            this.menuFormMain.TabIndex = 0;
            this.menuFormMain.Text = "menuFormMain";
            // 
            // menuFormMainFile
            // 
            this.menuFormMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormMainSettings,
            this.menuFormMainSeparator1,
            this.menuFormMainExit});
            this.menuFormMainFile.Name = "menuFormMainFile";
            this.menuFormMainFile.Size = new System.Drawing.Size(48, 20);
            this.menuFormMainFile.Text = "Файл";
            // 
            // menuFormMainSettings
            // 
            this.menuFormMainSettings.Name = "menuFormMainSettings";
            this.menuFormMainSettings.Size = new System.Drawing.Size(224, 22);
            this.menuFormMainSettings.Text = "Параметры по умолчанию";
            this.menuFormMainSettings.Click += new System.EventHandler(this.menuFormMainSettings_Click);
            // 
            // menuFormMainSeparator1
            // 
            this.menuFormMainSeparator1.Name = "menuFormMainSeparator1";
            this.menuFormMainSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuFormMainExit
            // 
            this.menuFormMainExit.Name = "menuFormMainExit";
            this.menuFormMainExit.Size = new System.Drawing.Size(224, 22);
            this.menuFormMainExit.Text = "Выход";
            this.menuFormMainExit.Click += new System.EventHandler(this.menuFormMainExit_Click);
            // 
            // menuFormMainHelp
            // 
            this.menuFormMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormMainAbout});
            this.menuFormMainHelp.Name = "menuFormMainHelp";
            this.menuFormMainHelp.Size = new System.Drawing.Size(65, 20);
            this.menuFormMainHelp.Text = "Справка";
            // 
            // menuFormMainAbout
            // 
            this.menuFormMainAbout.Name = "menuFormMainAbout";
            this.menuFormMainAbout.Size = new System.Drawing.Size(149, 22);
            this.menuFormMainAbout.Text = "О программе";
            this.menuFormMainAbout.Click += new System.EventHandler(this.menuFormMainAbout_Click);
            // 
            // groupNum
            // 
            this.groupNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNum.Controls.Add(this.setNum12);
            this.groupNum.Controls.Add(this.setNum8);
            this.groupNum.Controls.Add(this.setNum4);
            this.groupNum.Controls.Add(this.numChars);
            this.groupNum.Location = new System.Drawing.Point(13, 47);
            this.groupNum.Margin = new System.Windows.Forms.Padding(4);
            this.groupNum.Name = "groupNum";
            this.groupNum.Padding = new System.Windows.Forms.Padding(4);
            this.groupNum.Size = new System.Drawing.Size(308, 115);
            this.groupNum.TabIndex = 1;
            this.groupNum.TabStop = false;
            this.groupNum.Text = "Количество символов";
            // 
            // setNum12
            // 
            this.setNum12.Location = new System.Drawing.Point(225, 75);
            this.setNum12.Name = "setNum12";
            this.setNum12.Size = new System.Drawing.Size(75, 23);
            this.setNum12.TabIndex = 3;
            this.setNum12.Text = "12";
            this.setNum12.UseVisualStyleBackColor = true;
            this.setNum12.Click += new System.EventHandler(this.setNum12_Click);
            // 
            // setNum8
            // 
            this.setNum8.Location = new System.Drawing.Point(114, 75);
            this.setNum8.Name = "setNum8";
            this.setNum8.Size = new System.Drawing.Size(75, 23);
            this.setNum8.TabIndex = 2;
            this.setNum8.Text = "8";
            this.setNum8.UseVisualStyleBackColor = true;
            this.setNum8.Click += new System.EventHandler(this.setNum8_Click);
            // 
            // setNum4
            // 
            this.setNum4.Location = new System.Drawing.Point(8, 75);
            this.setNum4.Name = "setNum4";
            this.setNum4.Size = new System.Drawing.Size(75, 23);
            this.setNum4.TabIndex = 1;
            this.setNum4.Text = "4";
            this.setNum4.UseVisualStyleBackColor = true;
            this.setNum4.Click += new System.EventHandler(this.setNum4_Click);
            // 
            // numChars
            // 
            this.numChars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numChars.Location = new System.Drawing.Point(8, 37);
            this.numChars.Margin = new System.Windows.Forms.Padding(4);
            this.numChars.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numChars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChars.Name = "numChars";
            this.numChars.Size = new System.Drawing.Size(292, 22);
            this.numChars.TabIndex = 0;
            this.numChars.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupType
            // 
            this.groupType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupType.Controls.Add(this.typeSpChar);
            this.groupType.Controls.Add(this.typeDigit);
            this.groupType.Controls.Add(this.typeCharLow);
            this.groupType.Controls.Add(this.typeCharUp);
            this.groupType.Location = new System.Drawing.Point(13, 185);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(308, 178);
            this.groupType.TabIndex = 2;
            this.groupType.TabStop = false;
            this.groupType.Text = "Типы символов";
            // 
            // typeSpChar
            // 
            this.typeSpChar.AutoSize = true;
            this.typeSpChar.Checked = true;
            this.typeSpChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeSpChar.Location = new System.Drawing.Point(27, 143);
            this.typeSpChar.Name = "typeSpChar";
            this.typeSpChar.Size = new System.Drawing.Size(175, 20);
            this.typeSpChar.TabIndex = 3;
            this.typeSpChar.Text = "Специальные символы";
            this.typeSpChar.UseVisualStyleBackColor = true;
            // 
            // typeDigit
            // 
            this.typeDigit.AutoSize = true;
            this.typeDigit.Checked = true;
            this.typeDigit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeDigit.Location = new System.Drawing.Point(27, 108);
            this.typeDigit.Name = "typeDigit";
            this.typeDigit.Size = new System.Drawing.Size(71, 20);
            this.typeDigit.TabIndex = 2;
            this.typeDigit.Text = "Цифры";
            this.typeDigit.UseVisualStyleBackColor = true;
            // 
            // typeCharLow
            // 
            this.typeCharLow.AutoSize = true;
            this.typeCharLow.Checked = true;
            this.typeCharLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeCharLow.Location = new System.Drawing.Point(27, 72);
            this.typeCharLow.Name = "typeCharLow";
            this.typeCharLow.Size = new System.Drawing.Size(182, 20);
            this.typeCharLow.TabIndex = 1;
            this.typeCharLow.Text = "Буквы (нижний регистр)";
            this.typeCharLow.UseVisualStyleBackColor = true;
            // 
            // typeCharUp
            // 
            this.typeCharUp.AutoSize = true;
            this.typeCharUp.Checked = true;
            this.typeCharUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeCharUp.Location = new System.Drawing.Point(27, 37);
            this.typeCharUp.Name = "typeCharUp";
            this.typeCharUp.Size = new System.Drawing.Size(187, 20);
            this.typeCharUp.TabIndex = 0;
            this.typeCharUp.Text = "Буквы (верхний регистр)";
            this.typeCharUp.UseVisualStyleBackColor = true;
            // 
            // groupPassword
            // 
            this.groupPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPassword.Controls.Add(this.buttonPassword);
            this.groupPassword.Controls.Add(this.textPassword);
            this.groupPassword.Location = new System.Drawing.Point(13, 385);
            this.groupPassword.Name = "groupPassword";
            this.groupPassword.Size = new System.Drawing.Size(308, 114);
            this.groupPassword.TabIndex = 3;
            this.groupPassword.TabStop = false;
            this.groupPassword.Text = "Пароль";
            // 
            // buttonPassword
            // 
            this.buttonPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPassword.Location = new System.Drawing.Point(8, 65);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(294, 32);
            this.buttonPassword.TabIndex = 1;
            this.buttonPassword.Text = "Сгенерировать";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // textPassword
            // 
            this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassword.Location = new System.Drawing.Point(8, 37);
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(294, 22);
            this.textPassword.TabIndex = 0;
            this.textPassword.Text = "Здесь будет Ваш пароль...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 511);
            this.Controls.Add(this.groupPassword);
            this.Controls.Add(this.groupType);
            this.Controls.Add(this.groupNum);
            this.Controls.Add(this.menuFormMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuFormMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AMPasswordGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuFormMain.ResumeLayout(false);
            this.menuFormMain.PerformLayout();
            this.groupNum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numChars)).EndInit();
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            this.groupPassword.ResumeLayout(false);
            this.groupPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFormMain;
        private System.Windows.Forms.ToolStripMenuItem menuFormMainFile;
        private System.Windows.Forms.ToolStripMenuItem menuFormMainSettings;
        private System.Windows.Forms.ToolStripSeparator menuFormMainSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFormMainExit;
        private System.Windows.Forms.ToolStripMenuItem menuFormMainHelp;
        private System.Windows.Forms.ToolStripMenuItem menuFormMainAbout;
        private System.Windows.Forms.GroupBox groupNum;
        private System.Windows.Forms.Button setNum12;
        private System.Windows.Forms.Button setNum8;
        private System.Windows.Forms.Button setNum4;
        private System.Windows.Forms.NumericUpDown numChars;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.CheckBox typeSpChar;
        private System.Windows.Forms.CheckBox typeDigit;
        private System.Windows.Forms.CheckBox typeCharLow;
        private System.Windows.Forms.CheckBox typeCharUp;
        private System.Windows.Forms.GroupBox groupPassword;
        private System.Windows.Forms.Button buttonPassword;
        private System.Windows.Forms.TextBox textPassword;
    }
}

