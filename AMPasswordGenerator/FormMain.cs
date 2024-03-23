using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMPasswordGenerator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuFormMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setNum4_Click(object sender, EventArgs e)
        {
            numChars.Value = 4;
        }

        private void setNum8_Click(object sender, EventArgs e)
        {
            numChars.Value = 8;
        }

        private void setNum12_Click(object sender, EventArgs e)
        {
            numChars.Value = 12;
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            if (!typeCharUp.Checked & !typeCharLow.Checked & !typeDigit.Checked & !typeSpChar.Checked)
            {
                textPassword.Text = "Не выбраны типы символов";
            }
            else
            {
                PasswordGenerator passwordGenerator = new PasswordGenerator();
                textPassword.Text = passwordGenerator.GetPasswordString(typeCharUp.Checked, typeCharLow.Checked, typeDigit.Checked, typeSpChar.Checked, Convert.ToInt32(numChars.Value));
            }
        }

        private void menuFormMainAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void menuFormMainSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.positionX.Value = this.Location.X;
            formSettings.positionY.Value = this.Location.Y;
            formSettings.formWidth.Value = this.Size.Width;
            formSettings.formHeight.Value = this.Size.Height;
            formSettings.ShowDialog();
            this.Location = new Point(Properties.Settings.Default.positionX, Properties.Settings.Default.positionY);
            this.Size = new Size(Properties.Settings.Default.sizeWidth, Properties.Settings.Default.sizeHeight);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.positionX = this.Location.X;
            Properties.Settings.Default.positionY = this.Location.Y;
            Properties.Settings.Default.sizeWidth = this.Size.Width;
            Properties.Settings.Default.sizeHeight = this.Size.Height;
            Properties.Settings.Default.Save();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Properties.Settings.Default.positionX, Properties.Settings.Default.positionY);
            this.Size = new Size(Properties.Settings.Default.sizeWidth, Properties.Settings.Default.sizeHeight);
        }
    }
}
