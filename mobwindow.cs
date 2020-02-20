using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGHealth
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudHP.Value += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nudHP.Value += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nudHP.Value += 10;
        }

        private void buttonmin10_Click(object sender, EventArgs e)
        {
            nudHP.Value -= 10;
        }

        private void buttonmin5_Click(object sender, EventArgs e)
        {
            nudHP.Value -= 5;
        }

        private void buttonmin1_Click(object sender, EventArgs e)
        {
            nudHP.Value -= 1;
        }

        private void buttonNT_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (nudREGEN_t.Value > 0)
            {
                if (randomizeREGEN.Checked)
                {
                    int regenRnd = rnd.Next(0, (int)nudREGEN.Value);
                    nudHP.Value += regenRnd;
                }
                else
                {
                    nudHP.Value += nudREGEN.Value;
                }
                nudREGEN_t.Value -= 1;
                if (nudREGEN_t.Value <= 0)
                {
                    nudREGEN.Value = 0;
                }
            }
            if (nudDOT_t.Value > 0)
            { 
                if (randomizeDOT.Checked)
                {
                    int dotRnd = rnd.Next(0, (int)nudDOT.Value);
                    nudHP.Value -= dotRnd;
                }
                else
                {
                    nudHP.Value -= nudDOT.Value;
                }
                nudDOT_t.Value -=  1;
                if (nudDOT_t.Value <= 0)
                {
                    nudDOT.Value = 0;
                }
            }
        }
    }
}
