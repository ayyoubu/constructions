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
    public partial class Frm_idfrs : Form
    {
        public Frm_idfrs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_frs s = new Frm_frs();
            s.ShowDialog();
        }
        int i;

        private void button4_Click(object sender, EventArgs e)
        {
           //edit in database
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(i);
                //remove from database..
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //search..
        }
    }
}
