﻿using System;
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
    public partial class Frm_Cat_pj : Form
    {
        public Frm_Cat_pj()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(textBox4.Text, textBox3.Text);
            this.textBox4.Clear();
            this.textBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {     DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                int index = this.dataGridView1.CurrentRow.Index;
                this.dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("la supprission a été bien avec succées");
            }
            else
                MessageBox.Show("la supprission est Ignorer");}catch { }
        
        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentCell.RowIndex;
            textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
            catch { }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[i].Cells[0].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
