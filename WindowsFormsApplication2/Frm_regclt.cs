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
    public partial class Frm_regclt : Form
    {
        public Frm_regclt()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_idclt s = new Frm_idclt();
            s.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Frm_idlot s = new Frm_idlot();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_new_regl s = new Frm_new_regl();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
