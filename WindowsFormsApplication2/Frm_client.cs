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
    public partial class Frm_clt : Form
    {
        public Frm_clt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_listeclient Fgrid = new Frm_listeclient();
            Fgrid.dataGridView1.Rows.Add(textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox14.Text, textBox13.Text, textBox1.Text, textBox4.Text);
            Fgrid.ShowDialog();
        }
    }
}
