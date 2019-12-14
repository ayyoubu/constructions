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
    public partial class listefrs : Form
    {
        public listefrs()
        {
            InitializeComponent();
        }

        private void listefrs_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Frm_frs finfo = new Frm_frs();
            finfo.Show();  
        }
    }
}
