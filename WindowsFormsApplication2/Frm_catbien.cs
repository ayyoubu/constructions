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
    public partial class Frm_catbien : Form
    {
        public Frm_catbien()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        public bool check_void()
        {
            bool b = false;
            if (textBox2.Text == "") b = true;
            return b;
        }

        public void refresh_dgv()
        {
            try {
            SqlCommand cmd = new SqlCommand("select * from Cat_bien");
            cmd.Connection = c.cnx;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridView1.DataSource = dt;
            }
             catch{

            }

        }
        public void add_cat()
        {
          try
          {
                SqlCommand cmd = new SqlCommand("insert into Cat_bien values ('" + textBox2.Text + "')");
                cmd.Connection = c.cnx;
                cmd.ExecuteNonQuery();
                refresh_dgv();
        }
            catch { }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.Rows.Add(textBox2.Text);
          if(check_void())
            {
                MessageBox.Show("intitule est vide !");
            }
          else add_cat();
            this.textBox2.Text = "";
        }
        public void remove_cat()
        {
            //   try
            //  {
            int id = (int)dataGridView1.Rows[i].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("delete from cat_bien where idcatbien = '" + id + "'", c.cnx);
            cmd.ExecuteNonQuery();
            refresh_dgv();
            // }catch { }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    // int index = this.dataGridView1.CurrentRow.Index;
                    // this.dataGridView1.Rows.RemoveAt(index);
                    remove_cat();
                    MessageBox.Show("la supprission a été bien avec succées");
                }
                else
                    MessageBox.Show("la supprission est Ignorer");
            }
            catch { }
        }
        int i;
        public void edit_cat()
        {
            try
            {
                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("update cat_bien set bien = '" + textBox2.Text + "' where idcatbien =  '" + id + "'", c.cnx);
                cmd.ExecuteNonQuery();
                refresh_dgv();
            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            edit_cat();
         //   dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;

        }

        private void Frm_catbien_Load(object sender, EventArgs e)
        {
            if (c.cnx.State == ConnectionState.Closed) c.cnx.Open();
            refresh_dgv();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;

                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CurrentCellChanged_1(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;

                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
