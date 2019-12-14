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
    public partial class Frm_identification : Form
    {
        public Frm_identification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Listechantier Fgrid = new Frm_Listechantier();
            Fgrid.dgv1.Rows.Add(textBox1.Text, textBox2.Text, textBox5.Text, textBox6.Text, comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, textBox3.Text, textBox4.Text, comboBox2.Text, comboBox6.Text, comboBox5.Text, comboBox4.Text);
            Fgrid.ShowDialog();
            foreach(Control c in Controls)
            {
                if (c is TextBox || c is DateTimePicker || c is ComboBox) c.Text = "";
            }
          /*  this.textBox1.Text = "";
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.comboBox1.Text = "";
            this.dateTimePicker1.Text = "";
            this.dateTimePicker2.Text = "";
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.comboBox2.Text = "";
            this.comboBox6.Text = "";
            this.comboBox5.Text = "";
            this.comboBox4.Text = "";
            this.comboBox3.Text = "";
            this.textBox7.Clear();
            this.textBox8.Clear();
            this.textBox9.Clear();
            this.textBox10.Clear();
            this.textBox11.Clear();
            this.textBox12.Clear();*/

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_clt s = new Frm_clt();
            s.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_maitre s = new Frm_maitre();
            s.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_bureau s = new Frm_bureau();
            s.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frm_labo s = new Frm_labo();
            s.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frm_architecte s = new Frm_architecte();
            s.ShowDialog();
        }
    }
}
