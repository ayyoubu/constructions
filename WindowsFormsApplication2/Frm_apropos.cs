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
using System.Data.Linq;

namespace WindowsFormsApplication2
{
    public partial class Frm_apropos : Form
    {
        public Frm_apropos()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool check_empty()
        {
            bool empty= false;
            foreach(Control c in Controls)
            {
               
                if ((c is TextBox || c is ComboBox) && c.Text == "")
                 empty = true;
                    
            }
            return empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(check_empty())
            {
                MessageBox.Show("warning","des champs sans vide ! ");
            }else {
                add_apropo();
                MessageBox.Show("info","enregistré");
            }

            //   SqlCommand cmd = new SqlCommand("insert into Apropos values( Intitulé ,Adresse ,Qualité ,Ville ,Contact ,Cp ,RC ,ICE ,NIF ,TP ,logo ,Telephone ,Fix ,Email ,website) ('"+txt_intitule.Text+ "' , '" + txt_adress.Text + "' , '" + txt_qualite.Text + "' , '" + txt_ville.Text + "' , '" + txt_contact.Text + "' , '" + txt_cp.Text + "' , '" +Convert.ToInt64( txt_rc.Text) + "' , '" + Convert.ToInt64(txt_ice.Text) + "' , '" + Convert.ToInt64(txt_intitule.Text) + "' , '" + Convert.ToInt64(txt_if.Text) + "' , '" + Convert.ToInt64(txt_tp.Text) + "' , '"+arr+"' , '"+ txt_tel.Text + "','" + txt_fix.Text + "' , '" + txt_email.Text + "' , '" + txt_siteweb.Text + "' )", c.cnx);
            // SqlCommand cmd = new SqlCommand("insert into Apropos values ('null','"+txt_intitule.Text+ "' , '" + txt_adress.Text + "' , '" + txt_qualite.Text + "' , '" + txt_ville.Text + "' , '" + txt_contact.Text + "' , '" + txt_cp.Text + "' , '" +Convert.ToInt64( txt_rc.Text) + "' , '" + Convert.ToInt64(txt_ice.Text) + "' , '" + Convert.ToInt64(txt_intitule.Text) + "' , '" + Convert.ToInt64(txt_if.Text) + "' , '" + Convert.ToInt64(txt_tp.Text) + "' , '"+arr+"' , '"+ txt_tel.Text + "','" + txt_fix.Text + "' , '" + txt_email.Text + "' , '" + txt_siteweb.Text + "' )", c.cnx);

            //cmd.Connection = c.cnx;
            //cmd.ExecuteNonQuery();



        }

        private void add_apropo()
        {
            try
            {
                // only acceptec formats are pdf and image formats

                //in case of image 
                Image img = pictureBox1.Image;
                byte[] arr;

                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                Binary bin = new Binary(arr);

                DataClasses1DataContext dc = new DataClasses1DataContext();
                Apropo a = new Apropo();
                a.Contact = txt_contact.Text;
                a.Adresse = txt_adress.Text;
                a.Cp = txt_cp.Text;
                a.Email = txt_email.Text;
                a.Fix = txt_fix.Text;
                a.ICE = Convert.ToInt32(txt_ice.Text);
                a.Intitulé = txt_intitule.Text;
                a.logo = bin;
                a.NIF = Convert.ToInt32(txt_if.Text);
                a.Qualité = txt_qualite.Text;
                a.RC = Convert.ToInt32(txt_rc.Text);
                a.TP = Convert.ToInt32(txt_tp.Text);
                a.Ville = txt_ville.Text;
                a.website = txt_siteweb.Text;


                dc.Apropos.InsertOnSubmit(a);
                dc.SubmitChanges();
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    // en cas d'une format incorrect !
                    MessageBox.Show("please pick a correct image format " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
