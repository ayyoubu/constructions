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
    public partial class Frm_famille : Form
    {
        public Frm_famille()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,comboBox1.Text);
            this.textBox1.Text = "";
            this.textBox2.Clear();
            this.comboBox1.Text = "";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                DialogResult res = MessageBox.Show("veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                int index = this.dataGridView1.CurrentRow.Index;
                this.dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("la supprission a été bien avec succées");
            }
            else
                MessageBox.Show("la supprission est Ignorer"); }catch { }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[2].Value = comboBox1.Text;
            }
            catch { }
       
        }
        int i;
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString(); 
            }
            catch { }
        }
    }
}
