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
    public partial class Robot : UserControl
    {
        public int Change             //Remember, properties can be any data type - integers, string whatever
                                      //No need to get AND set unless specified.
        {
            set { 
                
                
                if(value == 1)
                {
                    panelStop.BackColor = Color.Red;
                    panelWait.BackColor = Color.Gray;
                    panelGo.BackColor = Color.Gray;
                    lblMeaning.Text = "Meaning: Stop!";

                }
                else if(value == 2)
                {
                    panelStop.BackColor = Color.Gray;
                    panelWait.BackColor = Color.Orange;
                    panelGo.BackColor = Color.Gray;
                    lblMeaning.Text = "Meaning: Slow Down!";
                }
                else if(value == 3)
                {
                    panelStop.BackColor = Color.Gray;
                    panelWait.BackColor = Color.Gray;
                    panelGo.BackColor = Color.Green;
                    lblMeaning.Text = "Meaning: Go!";
                }

                

                }
        }
        public Robot()
        {
            InitializeComponent();
        }

        private void Robot_Load(object sender, EventArgs e)
        {

        }
    }
}
