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
    public partial class Frm_listefrs : Form
    {
        public Frm_listefrs()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Frm_frs finfo = new Frm_frs();
            finfo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Fournisseur");
                cmd.Connection = c.cnx;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = dt;
            }
            catch
            {

            }

        }
        private void Frm_listefrs_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
