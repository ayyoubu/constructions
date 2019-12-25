using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class article_usercontrol : UserControl
    {
        public article_usercontrol(string id , string desc , string pu )
        {
            InitializeComponent();
            this.id = id;
            this.desc = desc;
            this.pu = pu;
        }
        public string id;
        public string pu;
        public string desc;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent = null;
        }

        private void article_usercontrol_Load(object sender, EventArgs e)
        {
            txt_id.Text = id;
            txt_desc.Text = desc;
            txt_pu.Text = pu;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try {
                txt_montant.Text = (double.Parse(txt_qte.Text) * double.Parse(txt_pu.Text)).ToString();
            }
            catch { }
        }
    }
}
