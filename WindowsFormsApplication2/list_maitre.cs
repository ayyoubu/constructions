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
    public partial class list_maitre : Form
    {
        public list_maitre()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();


        //Event that fires when data is available
        public event EventHandler OnDataAvailable;

        //Properties that expose FormB's data
        public string id { get; private set; }
        public string iti { get; private set; }

        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Maitre");
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            // add new item in databse (new item will be selected )
            // code to remove  [
            Frm_clt finfo = new Frm_clt();
            finfo.Show();
            //.......................]
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // keep this code and delete item from database
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

        private void button4_Click(object sender, EventArgs e)
        {
            // user edits iems in datagridview 
            //edite selected item in database
        }

        private void Frm_listeclient_Load(object sender, EventArgs e)
        {

            refresh_dgv();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = this.dataGridView1.CurrentRow.Index;
            //Set the exposed properties, then fire off the event.
            this.id = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
            this.iti = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
            if (OnDataAvailable != null)
                OnDataAvailable(this, EventArgs.Empty);
            this.Close();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
