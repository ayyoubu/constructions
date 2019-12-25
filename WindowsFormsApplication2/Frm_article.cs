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
    public partial class Frm_article : Form
    {
        public Frm_article()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
     
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Cat_bien");
                cmd.Connection = c.cnx;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                dataGridView1.DataSource = dt;
            }
            catch
            {

            }

        }
        private void Frm_article_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
