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
    public partial class Frm_architecte : Form
    {
        public Frm_architecte()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        public void edit_post()
        {
            try
            {
                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                SqlCommand cmd = new SqlCommand(" update Architecte set Intitulé ='"+txt_intitile.Text+ "' , Adresse ='" + txt_adress.Text + "' , Telepohne ='" + txt_tel.Text + "' , Fix ='" + txt_fix.Text + "' , Email ='" + txt_email.Text + "' , website ='" + txt_siteweb.Text + "' where IdArchitecte = '"+id+"'", c.cnx);
                cmd.ExecuteNonQuery();
                refresh_dgv();
            }
            catch { }

        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Architecte");
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
        public void add_arch()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" insert into Architecte values ('"+txt_intitile.Text + "','"+txt_adress.Text + "','"+txt_tel.Text + "','"+txt_fix.Text + "','"+txt_email.Text + "','"+txt_siteweb.Text+"')");
                cmd.Connection = c.cnx;
                cmd.ExecuteNonQuery();
                refresh_dgv();
            }
            catch { }

        }
        public void remove_post()
        {
            try
            {
                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("delete from Architecte where IdArchitecte = '" + id + "'", c.cnx);
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
            try
            {

                if (!isempty())
                {
                    //dataGridView1.Rows.Add(txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt6.Text, txt5.Text, txt7.Text);
                    add_arch();
                    clear_inputs();
                }

            }
            catch { }
        }

        private void clear_inputs()
        {
            txt_adress.Clear();
            txt_email.Clear();
            txt_fix.Clear();
            txt_intitile.Clear();
            txt_siteweb.Clear();
            txt_tel.Clear();



        }

        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                //txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_intitile.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_adress.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_tel.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt_fix.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txt_email.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txt_siteweb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                //txt1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_intitile.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_adress.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_tel.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt_fix.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txt_email.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txt_siteweb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
               
                //dataGridView1.Rows[i].Cells[0].Value = txt1.Text;
                edit_post();
                clear_inputs();
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
                    remove_post();
                    refresh_dgv();
                   clear_inputs();
                    
                    MessageBox.Show("la supprission a été bien avec succées");
                }
                else
                    MessageBox.Show("la supprission est Ignorer");
            }
            catch { }
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
            if (empty) MessageBox.Show("vous devez remplir tous les champs !");
            return empty;
        }
        private void Frm_architecte_Load(object sender, EventArgs e)
        {
            refresh_dgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear_inputs();
        }
    }
}
