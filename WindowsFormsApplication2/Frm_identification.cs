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
    public partial class Frm_identification : Form
    {
        public Frm_identification()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private Frm_listeclient fclient = null;
        private list_maitre fmaitre = null;

        DataClasses1DataContext dc = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        void fclient_OnDataAvailable(object sender, EventArgs e)
        {
            //Event handler for when FormB fires off the event
            combo_client.Text = fclient.id + " / "+ fclient.iti;
        }
        void fmaitre_OnDataAvailable(object sender, EventArgs e)
        {
            //Event handler for when FormB fires off the event
            combo_maitre.Text = fmaitre.id + " / " + fmaitre.iti;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fill_client()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from client", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_client.DataSource = dt;
                combo_client.DisplayMember = "Intitulé";
                combo_client.ValueMember = "Idclient";
            }
            catch
            { }
        }
        public void fill_labo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from labo", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_labo.DataSource = dt;
                combo_labo.DisplayMember = "Intitulé";
                combo_labo.ValueMember = "Idlabo";
            }
            catch
            { }
        }
        public void fill_maitre()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from maitre", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_maitre.DataSource = dt;
                combo_maitre.DisplayMember = "Intitulé";
                combo_maitre.ValueMember = "Idmaitre";
            }
            catch
            { }
        }
        public void fill_sou()
        {
            try
            {
                // we use maitre instead will be edited after the creation of sous traitant table
                SqlCommand cmd = new SqlCommand("select * from maitre", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_soustrait.DataSource = dt;
                combo_soustrait.DisplayMember = "Intitulé";
                combo_soustrait.ValueMember = "Idmaitre";
            }
            catch
            { }
        }
        public void fill_bureau()
        {
            try
            {
                // we use maitre instead will be edited after the creation of sous traitant table
                SqlCommand cmd = new SqlCommand("select * from bureau", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_bureau.DataSource = dt;
                combo_bureau.DisplayMember = "Intitulé";
                combo_bureau.ValueMember = "Idbureau";
            }
            catch
            { }
        }
        public void fill_arch()
        {
            try
            {
                // we use maitre instead will be edited after the creation of sous traitant table
                SqlCommand cmd = new SqlCommand("select * from Architecte", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_arch.DataSource = dt;
                combo_arch.DisplayMember = "Intitulé";
                combo_arch.ValueMember = "IdArchitecte";
            }
            catch
            { }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Frm_Listechantier Fgrid = new Frm_Listechantier();
            //Fgrid.dgv1.Rows.Add(ref_lot.Text, ref_flap.Text, ref_contrat.Text, textBox6.Text, combo_client.Text, dateTimePicker1.Text, dateTimePicker2.Text, operation.Text, localisation.Text, combo_maitre.Text, combo_arch.Text, combo_labo.Text, combo_bureau.Text);
            //Fgrid.ShowDialog();

            add_identification();
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is DateTimePicker || c is ComboBox) c.Text = "";
            }


        }

        private void add_identification()
        {
            try
            {
                identification ii = new identification();
                ii.Datecontrat = textBox6.Text;
                ii.IdArchitecte = (int)combo_arch.SelectedValue;
                ii.IdBureau = (int)combo_bureau.SelectedValue;
                ii.idClient = (int)combo_client.SelectedValue;
                ii.IdLaboratoire = (int)combo_labo.SelectedValue;
                ii.IdMaitrete = (int)combo_maitre.SelectedValue;
                ii.idsoustraitant = (int)combo_soustrait.SelectedValue;
                ii.Localisation = localisation.Text;
                ii.Opération = operation.Text;
                ii.PérdiodeD = dateTimePicker1.Value;
                ii.PérdiodeF = dateTimePicker2.Value;
                ii.Référence_de_contrat = ref_contrat.Text;
                ii.Référence_Plan = ref_flap.Text;
                ii.Taux_dassurance = autre.Text;
                ii.Taux_de_garantie = garantie.Text;
                ii.Taux_de_Prorata = prorate.Text;
                ii.Total_Marché_HT = Convert.ToInt32(ht.Text);
                ii.Total_Marché_TTC = Convert.ToInt32(ttc.Text);
                ii.TVA = Convert.ToInt32(tva.Text);
                dc.identifications.InsertOnSubmit(ii);
                dc.SubmitChanges();
            }catch { }
         
        }

        private void button7_Click(object sender, EventArgs e)
        {


            this.fclient = new Frm_listeclient();

            //FormA subscribes to FormB's event
            fclient.OnDataAvailable += new EventHandler(fclient_OnDataAvailable);
            fclient.Show();
        }

  
  
        private void button8_Click(object sender, EventArgs e)
        {
            this.fmaitre = new list_maitre();

            //FormA subscribes to FormB's event
            fmaitre.OnDataAvailable += new EventHandler(fmaitre_OnDataAvailable);
            fmaitre.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bureau_etude s = new bureau_etude();
            s.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frm_labo s = new Frm_labo();
            s.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frm_architecte s = new Frm_architecte();
            s.ShowDialog();
        }

        private void Frm_identification_Load(object sender, EventArgs e)
        {
            fill_arch();
            fill_bureau();
            fill_client();
            fill_labo();
            fill_maitre();
            fill_sou();
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
