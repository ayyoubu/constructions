using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApplication2
{
    public partial class Frm_newPJ : Form
    {
        public Frm_newPJ()
        {
            InitializeComponent();
        }
        Sqlcon c = new Sqlcon();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            catch
            { }
        }
        public void fill_cat()
        {
            //try
            //{
                SqlCommand cmd = new SqlCommand("select * from Cat_pj", c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_cat.DataSource = dt;
            combo_cat.DisplayMember = "intitule";
            combo_cat.ValueMember = "idcodepj";
            //}
            //catch
            //{ }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{ //in case of image 
              
                DataClasses1DataContext dc = new DataClasses1DataContext();
               PJ p = new PJ();

                p.Dt = dateTimePicker1.Value;
                p.designation = txt_desc.Text;
                p.idcodepj = (int)combo_cat.SelectedValue;
                p.idlot = (int)combo_lot.SelectedValue;
              
                p.Refpj = txt_ref.Text;
                dc.PJs.InsertOnSubmit(p);
                dc.SubmitChanges();
            
                string path = @"C:\Image_pj";
                pictureBox1.Image.Save(path + @"\" + combo_lot.Text + ".jpg", ImageFormat.Jpeg);

            //}
            //catch { }
        }
        public static void SaveImageCapture(System.Drawing.Image image)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "pj";
            s.DefaultExt = ".Jpg";// Default file extension
            s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Below are two examples of setting the initial (default) folder - choose one

            // 1. example of setting the default folder to a special folder
          //  s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // 2 example of setting the default folder to an absolute path
            s.InitialDirectory = ("C:\\Temp");

            // setting the RestoreDirectory property to true causes the
            // dialog to restore the current directory before closing
            s.RestoreDirectory = true;
            // Show save file dialog box
            // Process save file dialog box results
         
                // Save Image
                string filename = s.FileName;
                // the using statement causes the FileStream's dispose method to be
                // called when the object goes out of scope
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            
        }
        private void Frm_newPJ_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF,PDF)|*.JPG;*.PNG;*.GIF;*.PDF";
            fill_cat();
            fill_lot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                   
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    //// en cas d'une format incorrect !
                    //MessageBox.Show("please pick a correct image format " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
