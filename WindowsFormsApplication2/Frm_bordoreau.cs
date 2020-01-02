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
    public partial class Frm_bord : Form
    {
        public Frm_bord()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_bord();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_tab_bordoreau s = new Frm_tab_bordoreau();
            s.ShowDialog();
        }
        public void fill_lot()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from identification", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
              
                combo_lot.DataSource = dt;
                combo_lot.DisplayMember = "Référence_lot";
                combo_lot.ValueMember = "idlot";

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }
        public void fill_tach_p()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tache_pre where id_tachglob like '"+combo_glob.SelectedValue+"'", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_primaire.DataSource = dt;
                combo_primaire.DisplayMember = "desc_";
                combo_primaire.ValueMember = "id";
            }
            catch
            { }
        }
        public void fill_tach_g()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from bordoreau where id_lot like '" + combo_lot.SelectedValue + "'", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_glob.DataSource = dt;
                combo_glob.DisplayMember = "tach_glob";
                combo_glob.ValueMember = "id";
            }
            catch
            { }
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
 
       void add_bord()
        {
            try {
                bordoreau brr = new bordoreau();
                bool check = false; ;
                try
                {
                    brr = dc.bordoreaus.Single(bi => bi.id_lot ==(int) combo_lot.SelectedValue);
                    check = true;
                }
                catch {

                }
                if (!check)
                {
                    tache_pre pr = new tache_pre();
                    pr.desc_ = combo_primaire.Text;
                    pr.id_tachglob = Convert.ToInt32(combo_glob.SelectedValue);
                    dc.tache_pres.InsertOnSubmit(pr);
                    dc.SubmitChanges();

                    tache_secon t = new tache_secon();
                    t.desc_ = txt_sec.Text;
                    t.Montantsecondaire = Convert.ToDecimal(txt_montant_sec.Text);
                    t.tache_pre = (int)combo_primaire.SelectedValue;
                    t.Tauxsecondaire = Convert.ToDouble(txt_taux.Text);
                    dc.tache_secons.InsertOnSubmit(t);
                    dc.SubmitChanges();
                }
                else
                {
                bordoreau br = new bordoreau();
                br.id_lot = Convert.ToInt32( combo_lot.SelectedValue);
                br.operation = txt_operation.Text;
                br.tach_glob = combo_glob.Text;
                dc.bordoreaus.InsertOnSubmit(br);
                dc.SubmitChanges();

                tache_pre pr = new tache_pre();
                pr.desc_ = combo_primaire.Text;
                pr.id_tachglob = Convert.ToInt32( combo_glob.SelectedValue);
                dc.tache_pres.InsertOnSubmit(pr);
                dc.SubmitChanges();

                    tache_secon t = new tache_secon();
                    t.desc_ = txt_sec.Text;
                    t.Montantsecondaire = Convert.ToDecimal(txt_montant_sec.Text);
                    t.tache_pre = (int)combo_primaire.SelectedValue;
                    t.Tauxsecondaire = Convert.ToDouble(txt_taux.Text);
                    dc.tache_secons.InsertOnSubmit(t);
                    dc.SubmitChanges();
                }
              


            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
    
           
        }
        private void Frm_bord_Load(object sender, EventArgs e)
        {
            fill_lot();
            fill_tach_g();
            fill_tach_p();

        }

        private void combo_lot_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_tach_g();
            fill_tach_p();
        }

        private void combo_glob_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_tach_p();
        }

        private void combo_lot_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fill_tach_g();
            fill_tach_p();
        }
    }
}
