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
    public partial class Frm_famille : Form
    {
        public Frm_famille()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;

                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
            catch { }

        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select idfamille 'Code', intitule 'Intitule', idcatbien 'Catégorie' from Famille");
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
        int i;
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public void add_cat()
        {
            try
            {
                //SqlCommand cmd = new SqlCommand("insert into Famille values ('" + textBox2.Text + "')");
                //cmd.Connection = c.cnx;
                //cmd.ExecuteNonQuery();
                Famille f = new Famille();
               
                f.intitule = textBox2.Text;
                f.idcatbien = (int)comboBox1.SelectedValue;
                dc.Familles.InsertOnSubmit(f);
                dc.SubmitChanges();
                refresh_dgv();
            }
            catch { }

        }

        public void fill_combo()
        {
            try {
                SqlCommand cmd = new SqlCommand("select * from Cat_bien", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "bien";
                comboBox1.ValueMember = "idcatbien";
            }
            catch
            {   }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  this.dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,comboBox1.Text);
            //this.textBox1.Text = "";
            add_cat();
            clear_controls();

        }

        private void clear_controls()
        {
            this.textBox2.Clear();
            this.comboBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                DialogResult res = MessageBox.Show("veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                    delete_fam();
                MessageBox.Show("la supprission a été bien avec succées");
            }
            else
                MessageBox.Show("la supprission est Ignorer"); }catch { }
         
        }
        public void edit_fam()
        {
            try {

                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                Famille fm = dc.Familles.Single(f => f.idfamille == id);
                fm.idcatbien = (int)comboBox1.SelectedValue;
                fm.intitule = textBox2.Text;
                dc.SubmitChanges();
                refresh_dgv();
            } catch { }
        
        }
        public void delete_fam()
        {
            try
            {

                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                Famille fm = dc.Familles.Single(f => f.idfamille == id);
                dc.Familles.DeleteOnSubmit(fm);
                dc.SubmitChanges();
                refresh_dgv();
            }
            catch { }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            edit_fam();
       
        }
     
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;

                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
            catch { }
        }

        private void Frm_famille_Load(object sender, EventArgs e)
        {
            fill_combo();
            refresh_dgv();
        }
    }
}
