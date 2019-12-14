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
    public partial class Frm_bcfrs : Form
    {
        public Frm_bcfrs()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_idfrs s = new Frm_idfrs();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                //need some calculations..
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //need some calculations..
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            } catch { }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Frm_idlot s = new Frm_idlot();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_article s = new Frm_article();
            s.ShowDialog();
        }
    }
}
