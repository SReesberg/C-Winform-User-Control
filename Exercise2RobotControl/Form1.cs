using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2RobotControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rbStop.Checked = true;
            robot2.Change = 1;
        }

        private void rbStop_CheckedChanged(object sender, EventArgs e)
        {
            robot2.Change = 1;
        }

        private void rbWait_CheckedChanged(object sender, EventArgs e)
        {
            robot2.Change = 2;
        }

        private void rbGo_CheckedChanged(object sender, EventArgs e)
        {
            robot2.Change = 3;

        }
    }
}
