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
    public partial class Frm_devis : Form
    {
        public Frm_devis()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_idclt s = new Frm_idclt();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int id=0;
        private void button3_Click(object sender, EventArgs e)
        {
            
            try {
                id++;
                dataGridView1.Rows.Add(id,comboBox1.Text,textBox1.Text,comboBox2.Text,textBox2.Text);
            } catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Frm_idlot s = new Frm_idlot();
            s.ShowDialog();
        }
    }
}
