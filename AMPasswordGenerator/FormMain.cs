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
    }
}
