using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Gen_identification : Form
    {
        public Gen_identification()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
       UserControl1 u = new UserControl1();
            panel3.Controls.Clear();
            u.Parent = panel3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gen_BREC s = new Gen_BREC();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gen_Br s= new Gen_Br();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gen_Fac s = new Gen_Fac();
            s.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gen_Avoir s = new Gen_Avoir();
            s.ShowDialog();
        }
    }
}
