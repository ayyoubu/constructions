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
    public partial class Frm_bien : Form
    {
        public Frm_bien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
       
     
        } int code=1;
        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(code, textBox2.Text, comboBox3.Text, comboBox1.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            code++;
            vider();

        }

        private void vider()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox) c.Text = "";
            }
        }

        int i;
        private void button5_Click(object sender, EventArgs e)
        {
         
            try
            {
                DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    i = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("la supprission a été bien avec succées");
                }
                else
                    MessageBox.Show("la supprission est Ignorer");
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                comboBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();


            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[i].Cells[0].Value = comboBox1.Text;
                dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[2].Value = comboBox3.Text;
               
                dataGridView1.Rows[i].Cells[4].Value = textBox4.Text;
                dataGridView1.Rows[i].Cells[5].Value = textBox5.Text;
                dataGridView1.Rows[i].Cells[6].Value = textBox6.Text;
                vider();
            }
            catch
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double ph = Convert.ToDouble(textBox4.Text);
            if (ph >= 0 &&  Convert.ToInt64( comboBox2.Text )== 0)
            {
                textBox5.Text = "0.000";
                textBox6.Text =  ph.ToString();
            }
            else if (ph >= 0 && Convert.ToInt64(comboBox2.Text) == 20)
            {
                textBox5.Text = (ph*0.2).ToString();
                textBox6.Text =(ph + Convert.ToDouble( textBox5.Text)).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
