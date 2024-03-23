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
    public partial class FormSettings : Form
    {
        private int cancelPositionX;
        private int cancelPositionY;
        private int cancelSizeWidth;
        private int cancelSizeHeight;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cancelPositionX = Convert.ToInt32(positionX.Value);
            cancelPositionY = Convert.ToInt32(positionY.Value);
            cancelSizeWidth = Convert.ToInt32(formWidth.Value);
            cancelSizeHeight = Convert.ToInt32(formHeight.Value);
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.positionX = 25;
            Properties.Settings.Default.positionY = 25;
            Properties.Settings.Default.sizeWidth = 350;
            Properties.Settings.Default.sizeHeight = 550;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.positionX = cancelPositionX;
            Properties.Settings.Default.positionY = cancelPositionY;
            Properties.Settings.Default.sizeWidth = cancelSizeWidth;
            Properties.Settings.Default.sizeHeight = cancelSizeHeight;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.positionX = Convert.ToInt32(positionX.Value);
            Properties.Settings.Default.positionY = Convert.ToInt32(positionY.Value);
            Properties.Settings.Default.sizeWidth = Convert.ToInt32(formWidth.Value);
            Properties.Settings.Default.sizeHeight = Convert.ToInt32(formHeight.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
