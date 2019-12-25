using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frm_frs : Form
    {
        public Frm_frs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public void add()
        {
            try
            {

                Fournisseur c = new Fournisseur();
               
                c.Adresse = txt_adress.Text;
                c.Contact = txt_contact.Text;
                c.Cp = txt_cp.Text;
                c.Email = txt_email.Text;
                c.Fix = txt_fix.Text;
                c.ICE = Convert.ToInt32(txt_ice.Text);
                c.Intitulé = txt_intitule.Text;
                c.NIF = Convert.ToInt32(txt_if.Text);
                c.Qualité = txt_qlt.Text;
                c.RC = Convert.ToInt32(txt_rc.Text);
                c.Telephone = txt_tel.Text;
                c.TP = Convert.ToInt32(txt_tp.Text);
                c.Ville = txt_ville.Text;
                c.website = txt_siteweb.Text;
            
                dc.Fournisseurs.InsertOnSubmit(c);
                dc.SubmitChanges();

            }
            catch { }



        }
        private void button3_Click(object sender, EventArgs e)
        {
            add();
            Frm_listefrs Fgrid = new Frm_listefrs();
            Fgrid.Show();
    

        }
    }
}
