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
    public partial class Frm_frs : Form
    {
        public Frm_frs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Frm_listefrs Fgrid = new Frm_listefrs();
            Fgrid.dataGridView1.Rows.Add(textBox5.Text, textBox6.Text, textBox7.Text, textBox9.Text, textBox11.Text, textBox12.Text, textBox14.Text, textBox13.Text, textBox1.Text, textBox4.Text);
            Fgrid.ShowDialog();
            this.textBox5.Text = "";
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
            this.textBox9.Clear();
            this.textBox11.Clear();
            this.textBox12.Clear();
            this.textBox13.Clear();
            this.textBox14.Clear();
            this.textBox1.Clear();
            this.textBox4.Clear();
            this.textBox8.Clear();
            this.textBox15.Clear();
            this.textBox10.Clear();
            this.textBox3.Clear();
            this.textBox2.Clear();
            
        }
    }
}
