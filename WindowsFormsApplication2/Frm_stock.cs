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
    public partial class Frm_stock : Form
    {
        public Frm_stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Sqlcon c = new Sqlcon();
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from stock");
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
        private void Frm_stock_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }
    }
}
