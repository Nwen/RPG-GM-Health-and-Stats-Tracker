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
    public partial class Form1 : Form
    {
        Form2 mobWin;
        int mobNb = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mobName = "Enemy " + mobNb;
            mobWin = new Form2();
            mobWin.Text = mobName;
            mobWin.Show(this);
            mobNb += 1;
        }
    }
}
