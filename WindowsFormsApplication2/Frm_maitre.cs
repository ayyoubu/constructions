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
    public partial class Frm_maitre : Form
    {
        public Frm_maitre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool isempty()
        {
            bool empty = false;
            foreach (Control c in Controls)
            {
                
                if (c is TextBox && c.Text == "")
                {
                   
                    empty = true;
                }
                
            }
            if(empty) MessageBox.Show("vous devez remplir tous les champs !");
            return empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!isempty()) {
                    dataGridView1.Rows.Add(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt6.Text, txt5.Text, txt7.Text);
               foreach (Control c in Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }}
                
            }
            catch { }
        }
        int i;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[i].Cells[0].Value = txt1.Text;
                dataGridView1.Rows[i].Cells[1].Value = txt2.Text;
                dataGridView1.Rows[i].Cells[2].Value = txt3.Text;
                dataGridView1.Rows[i].Cells[3].Value = txt4.Text;
                dataGridView1.Rows[i].Cells[4].Value = txt5.Text;
                dataGridView1.Rows[i].Cells[5].Value = txt6.Text;
                dataGridView1.Rows[i].Cells[6].Value = txt7.Text;
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    int index = this.dataGridView1.CurrentRow.Index;
                    this.dataGridView1.Rows.RemoveAt(index);
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
                txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txt6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txt7.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txt6.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txt7.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_maitre_Load(object sender, EventArgs e)
        {

        }
    }
}
