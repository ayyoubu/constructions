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
 
    // (4)

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_idfrs s = new Frm_idfrs();
            s.ShowDialog();
        }
        public void calc_ht()
        {
          try
            {
                double sm = 0;
                for (int i = 0; i < u_list.Count; i++)
                {
                    sm += u_list[i].mont;

                }

                txt_total_ht.Text = sm.ToString();
            } catch
            {

            }
              
        
        }
        int user_c = 0;
        List<article_usercontrol> u_list = new List<article_usercontrol>();
        double some_tva = 0;
        double some_ttc = 0;

        public void calc_biens(double tva, double ttc)
        {
            //try
            //{

                some_tva += tva;
                some_ttc += ttc;
                txt_total_ttc.Text = some_ttc.ToString();
                txt_total_tva.Text = some_tva.ToString();

            //}
            //catch { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try {
                article_usercontrol u = new article_usercontrol(textBox1.Text,textBox2.Text,textBox4.Text);
                u.Tag = user_c;
                user_c++;
                u_list.Add(u);
                calc_ht();
                flowLayoutPanel2.Controls.Add(u);
                u.StatusUpdated += new EventHandler(MyEventHandlerFunction_StatusUpdated);
                bien bn = dc.biens.Single(b => b.idbien == int.Parse(textBox1.Text));
               
                calc_biens(Convert.ToDouble(bn.Tva), Convert.ToDouble(bn.PATTC));


            }
            catch { }
           
        }

        private void MyEventHandlerFunction_StatusUpdated(object sender, EventArgs e)
        {
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
            calc_ht();
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
  
        DataClasses1DataContext dc = new DataClasses1DataContext();
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

        private void flowLayoutPanel2_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
