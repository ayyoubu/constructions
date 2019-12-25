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
    public partial class article_template : Form
    {
        
        public article_template(string _value , string _type)
        {
            InitializeComponent();
            this.type = _type;
            this.value = _value;
        }
        string type;
        string value;
        Sqlcon c = new Sqlcon();
        public int id_bien;
        public string desc;
        public float pu;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                i = dataGridView1.CurrentCell.RowIndex;
                this.id_bien = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                this.desc =dataGridView1.Rows[i].Cells[1].Value.ToString();
                this.pu =float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                this.DialogResult = DialogResult.OK;
            }
            catch { }
        
            this.Close();
        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = null ;
                if (type=="id")
                {
                    cmd = new SqlCommand("select * from bien where idbien like '%"+value+"%'", c.cnx);
                }
                else if(type == "inti")
                {
                    cmd = new SqlCommand("select * from bien where intitule like '%" + value + "%'", c.cnx);
                }
           
              
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                i = dataGridView1.CurrentCell.RowIndex;
                this.id_bien = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                this.desc = dataGridView1.Rows[i].Cells[1].Value.ToString();
                this.pu = float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                i = dataGridView1.CurrentCell.RowIndex;
                this.id_bien = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                this.desc = dataGridView1.Rows[i].Cells[1].Value.ToString();
                this.pu = float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch { }
        }
    }
}
