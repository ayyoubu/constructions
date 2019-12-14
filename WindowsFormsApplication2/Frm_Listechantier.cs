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
    public partial class Frm_Listechantier : Form
    {
        public Frm_Listechantier()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //add to database ..
            // to remove [
            Frm_identification finfo = new Frm_identification();
            finfo.Show();
            //.       ......  ]
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Listechantier_Load(object sender, EventArgs e)
        {
            // show list of all items  with the new item selected
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // edit  selected item in databse ..
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // delete selected item from database 
        }
    }
}
