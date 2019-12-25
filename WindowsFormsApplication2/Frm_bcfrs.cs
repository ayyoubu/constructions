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
    public partial class Frm_bcfrs : Form
    {
        public Frm_bcfrs()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_idfrs s = new Frm_idfrs();
            s.ShowDialog();
        }
        public void calc_ht()
        {
            double sm = 0;
            for(int i =0; i<= u_list.Count; i++)
            {
                sm += u_list[i].mont;
            }
            MessageBox.Show(sm.ToString());
            txt_total_ht.Text = sm.ToString();
        }
        int user_c = 0;
        List<article_usercontrol> u_list = new List<article_usercontrol>();

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                article_usercontrol u = new article_usercontrol(textBox1.Text,textBox2.Text,textBox4.Text);
                u.Tag = user_c;
                user_c++;
                u_list.Add(u);
                flowLayoutPanel2.Controls.Add(u);
                calc_ht();
                
            }
            catch { }
            calc_ht();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //need some calculations..
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {

             
            } catch { }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Frm_idlot s = new Frm_idlot();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
        public void fill_fournis()
        {
            try
            {
          
                SqlCommand cmd = new SqlCommand("select * from Fournisseur", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
               
                combo_frns.DataSource = dt;
                combo_frns.ValueMember = "Intitulé";
                combo_frns.DisplayMember = "Idfournisseur";
            }
            catch
            { }
        }
      
        public void fill_lot()
        {
            try
            {
               
                SqlCommand cmd = new SqlCommand("select * from identification", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comb_lot.DataSource = dt;
                comb_lot.ValueMember = "Référence_lot";
                comb_lot.DisplayMember = "idlot";
            }
            catch
            { }
        }
        private void Frm_bcfrs_Load(object sender, EventArgs e)
        {
         fill_fournis();
          
          fill_lot();
        }
   
        private void combo_frns_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_fournis.Text = combo_frns.SelectedValue.ToString();
        }

        private void comb_lot_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_lot.Text = comb_lot.SelectedValue.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != "")
                {
                    string idd = textBox1.Text;
                    article_template f = new article_template(idd,"id");

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        textBox2.Text = f.desc.ToString();
                        textBox1.Text = f.id_bien.ToString();
                        textBox4.Text = f.pu.ToString();
                    }

                }

            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                if (textBox2.Text != "")
                {
                    string idd = textBox2.Text;
                    article_template f = new article_template(idd, "inti");

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        textBox2.Text = f.desc.ToString();
                        textBox1.Text = f.id_bien.ToString();
                        textBox4.Text = f.pu.ToString();
                    }

                }

            }
            catch { }
        }
    }
}
