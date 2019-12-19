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
using System.Data;
namespace WindowsFormsApplication2
{
    public partial class Frm_catrem : Form
    {
        public Frm_catrem()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        public void remove_cat()
        {
            //   try
            //  {
            int id = (int)dataGridView1.Rows[i].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("delete from Cat_remun where idcatrem = '" + id + "'", c.cnx);
            cmd.ExecuteNonQuery();
            refresh_dgv();
            // }catch { }

        }
        public void edit_cat()
        {
            try
            {
                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("update Cat_remun set intitule = '" + textBox3.Text + "' where idcatrem =  '" + id + "'", c.cnx);
                cmd.ExecuteNonQuery();
                refresh_dgv();
            }
            catch { }

        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Cat_remun");
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
        public void add_cat()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Cat_remun values ('" + textBox3.Text + "')");
                cmd.Connection = c.cnx;
                cmd.ExecuteNonQuery();
                refresh_dgv();
            }
            catch { }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    remove_cat();
                    MessageBox.Show("la supprission a été bien avec succées");
                }
                else
                    MessageBox.Show("la supprission est Ignorer");
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.dataGridView1.Rows.Add(textBox4.Text, textBox3.Text);
            add_cat();
            this.textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i;
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                textBox3.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // dataGridView1.Rows[i].Cells[1].Value = textBox3.Text;
            edit_cat();
        }

        private void Frm_catrem_Load(object sender, EventArgs e)
        {
            if (c.cnx.State == ConnectionState.Closed) c.cnx.Open();
            refresh_dgv();
        }
    }
}
