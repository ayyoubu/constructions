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
    public partial class Frm_poste : Form
    {
        Sqlcon c = new Sqlcon();
        
        public Frm_poste()
        {
            InitializeComponent();
        }
       
        public void refresh_dgv()
        {
          //  try {
                SqlCommand cmd = new SqlCommand("select * from Poste");
            cmd.Connection = c.cnx;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
          
            
            dataGridView2.DataSource = dt;
        //}
          //  catch{
               
           // }
     
        }
        public void  remove_post()
        {
         //   try
          //  {
              int id = (int)dataGridView2.Rows[i].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("delete from Poste where idposte = '" + id + "'", c.cnx);
            cmd.ExecuteNonQuery();
                refresh_dgv();
           // }catch { }
          
        }
        public void add_post()
        {
            try {  SqlCommand cmd = new SqlCommand("insert into Poste values ('"+textBox3.Text+"')");
            cmd.Connection = c.cnx;
            cmd.ExecuteNonQuery();
                refresh_dgv();
            }catch { }
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*this.dataGridView1.Rows.Add(textBox4.Text,textBox3.Text);
            this.textBox4.Text = "";
            this.textBox4.Clear();
            this.textBox3.Clear();*/
           if(c.cnx.State == ConnectionState.Closed) c.cnx.Open();
            add_post();
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    remove_post();

                    
                    MessageBox.Show("la supprission a été bien avec succées");
                }
                else
                    MessageBox.Show("la supprission est Ignorer");
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
        int i;


        public void edit_post()
        {
            try {     int id = (int)dataGridView2.Rows[i].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("update Poste set poste = '" + textBox3.Text + "' where idposte =  '" + id + "'", c.cnx);
            cmd.ExecuteNonQuery();
            refresh_dgv();}
            catch{ }
        
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //  dataGridView1.Rows[i].Cells[0].Value = textBox4.Text;
            //textBox3.Text= dataGridView2.Rows[i].Cells[1].Value
            edit_post();
        }

        private void Frm_poste_Load(object sender, EventArgs e)
        {
            if (c.cnx.State == ConnectionState.Closed) c.cnx.Open();
            refresh_dgv();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try {
            i = dataGridView2.CurrentCell.RowIndex;
            //  textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
             } catch { }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView2.CurrentCell.RowIndex;
                //  textBox4.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox3.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
