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
    public partial class Frm_clt : Form
    {
        public Frm_clt()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public void add()
        {
            try {

            Client c = new Client();
            c.Adresse = txt_adress.Text;
            c.Contact = txt_contact.Text;
            c.Cp = txt_cp.Text;
            c.Email = txt_email.Text;
            c.Fix = txt_fix.Text;
            c.ICE = Convert.ToInt32( txt_ice.Text);
            c.Intitulé = txt_intitule.Text;
            c.NIF = Convert.ToInt32(txt_if.Text);
            c.Qualité = txt_qlt.Text;
            c.RC = Convert.ToInt32(txt_rc.Text);
            c.Telephone = txt_tel.Text;
            c.TP = Convert.ToInt32(txt_tp.Text);
            c.Ville = txt_ville.Text;
            c.website = txt_siteweb.Text;
            dc.Clients.InsertOnSubmit(c);
                dc.SubmitChanges();

            } catch { }
          
       

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            add();
            Frm_listeclient Fgrid = new Frm_listeclient();
            Fgrid.Show();
            //Fgrid.dataGridView1.Rows.Add(textBox5.Text, txt_intitule.Text, txt_adress.Text, txt_ville.Text, txt_ice.Text, txt_rc.Text, txt_if.Text, txt_tp.Text, txt_tel.Text, txt_email.Text);
            //Fgrid.ShowDialog();
        }
    }
}
