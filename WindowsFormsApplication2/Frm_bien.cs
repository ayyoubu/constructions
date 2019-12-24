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
using System.Globalization;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Frm_bien : Form
    {
        public Frm_bien()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
       
     
        }
     
        Sqlcon c = new Sqlcon();
        public void fill_combo_unite()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Unite", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_unité.DataSource = dt;
                combo_unité.DisplayMember = "intitule";
                combo_unité.ValueMember = "idunite";
            }
            catch
            { }
        }
        public void edit_bien()
        {
            try
            {

                int id = (int)dataGridView1.Rows[i].Cells[0].Value;
                bien b = dc.biens.Single(f => f.idbien == id);

                b.idfamille = (int)combo_famille.SelectedValue;
                b.idunite = (int)combo_unité.SelectedValue;
                b.Tva = Convert.ToDouble(txt_tva.Text);
                b.intitule = txt_intitulé.Text;
                b.PAHT = Convert.ToDouble(txt_pa_ht.Text);
                b.PATTC = Convert.ToDouble(txt_ttc.Text);
                
                dc.SubmitChanges();
                refresh_dgv();
            }
            catch { }

        }
        public void fill_combo_famille()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Famille", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_famille.DataSource = dt;
                combo_famille.DisplayMember = "intitule";
                combo_famille.ValueMember = "idfamille";
            }
            catch
            { }
        }
        public void add_bien()
        {
            try {

            bien b = new bien();
                b.intitule = txt_intitulé.Text;
            b.idfamille =(int) combo_famille.SelectedValue;
            b.idunite = (int)combo_unité.SelectedValue;
            b.PAHT =Convert.ToDouble( txt_pa_ht.Text);
            b.PATTC = Convert.ToDouble(txt_ttc.Text);
            b.Tva = Convert.ToDouble(txt_tva.Text);
            dc.biens.InsertOnSubmit(b);
            dc.SubmitChanges();

            } catch { }
         


        }
        private void button3_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.Rows.Add(code, txt_intitulé.Text, combo_famille.Text, combo_unité.Text, txt_pa_ht.Text, combo_tva2.Text, txt_ttc.Text);
            //code++;
            add_bien();
            vider();
            refresh_dgv();

        }

        private void vider()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox) c.Text = "";
            }
        }

        int i;
        private void button5_Click(object sender, EventArgs e)
        {
         
            try
            {
                DialogResult res = MessageBox.Show("Veuillez,vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    i = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(i);
                    MessageBox.Show("la supprission a été bien avec succées");
                }
                else
                    MessageBox.Show("la supprission est Ignorer");
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                combo_unité.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_intitulé.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                combo_famille.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                
                txt_pa_ht.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txt_tva.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txt_ttc.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

            }
            catch
            {

            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                combo_unité.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt_intitulé.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                combo_famille.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                
                txt_pa_ht.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                txt_tva.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                txt_ttc.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();


            }
            catch
            {

            }
        }
        //Sqlcon c = new Sqlcon();

        public void add_post()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(" INSERT INTO bien values ('"+txt_intitulé.Text+"','"+ Convert.ToInt32(combo_famille.SelectedValue)+ "','" + Convert.ToInt32 (combo_unité.SelectedValue) + "','"+double.Parse(txt_pa_ht.Text)+ "','" + double.Parse(txt_tva.Text) + "','" + double.Parse(txt_ttc.Text) + "')");
                cmd.Connection = c.cnx;
                cmd.ExecuteNonQuery();
                refresh_dgv();
            }
            catch { }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string format problem when converting to double
            //try
            //{
            NumberFormatInfo numberInfo = CultureInfo.CurrentCulture.NumberFormat;
            i = dataGridView1.CurrentCell.RowIndex;
            int id = (int)dataGridView1.Rows[i].Cells[0].Value;
            bien b = dc.biens.Single(bb => bb.idbien == id);
            b.idfamille = (int)combo_famille.SelectedValue;
            b.idunite = (int)combo_unité.SelectedValue;
            b.intitule = txt_intitulé.Text;
            b.PAHT = double.Parse(txt_pa_ht.Text, numberInfo);
            b.PATTC = double.Parse(txt_ttc.Text, numberInfo);
            b.Tva = double.Parse(txt_tva.Text, numberInfo);
            dc.SubmitChanges();

            refresh_dgv();
                vider();
            //}
            //catch
            //{

            //}
        }
        public void refresh_dgv()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from bien");
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                double ph = Convert.ToDouble(txt_pa_ht.Text);
            if (ph >= 0 &&  Convert.ToInt64( combo_tva1.Text )== 0)
            {
                txt_tva.Text = "0.000";
                txt_ttc.Text =  ph.ToString();
            }
            else if (ph >= 0 && Convert.ToInt64(combo_tva1.Text) == 20)
            {
                txt_tva.Text = (ph*0.2).ToString();
                txt_ttc.Text =(ph + Convert.ToDouble( txt_tva.Text)).ToString();
            }} catch { }
       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_bien_Load(object sender, EventArgs e)
        {
            fill_combo_unite();
            fill_combo_famille();
            refresh_dgv();
        }
    }
}
