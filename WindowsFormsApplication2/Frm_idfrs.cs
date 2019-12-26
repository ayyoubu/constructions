using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public partial class Frm_idfrs : Form
    {
        public Frm_idfrs()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       public string id;
    public     string desc;
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
        {try {
   SqlCommand cmd = new SqlCommand("select Idfournisseur 'ID' , Intitulé from Fournisseur f  where f.Idfournisseur like '%" + textBox1.Text + "%' or f.Intitulé like '%" + textBox1.Text+"%'  ", c.cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
                dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            }catch { }
         if(textBox1.Text=="")
            {
                refresh_dgv();
            }
        }

        private void Frm_idfrs_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Idfournisseur 'ID' , Intitulé from Fournisseur  ", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int i = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                desc = dataGridView1.Rows[i].Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch { }
         

        }
    }
}
