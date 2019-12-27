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
           if(dataGridView1.Rows.Count>0)
            {
                try
                {
                    DialogResult res = MessageBox.Show("Veuillez-vous évidemment valider cette opération ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.OK)
                    {
                       //valider
                        //save to database

                        
                    }
                
                }
                catch { }
            }
        }

        // (4)

        private void button14_Click(object sender, EventArgs e)
        {
            Frm_idfrs s = new Frm_idfrs();
            try
            {
                if (s.ShowDialog() == DialogResult.OK)
                {
                    combo_frns.SelectedText = s.id;
                    combo_frns.SelectedValue = s.desc;
                }
            }
            catch { }

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
            }
            catch
            {

            }


        }
        public void refresh_totals()
        {
            try
            {
                double sm = 0;
                for (int i = 0; i < u_list.Count; i++)
                {
                    if (u_list[i].Parent == null)
                    {
                        bien bn = dc.biens.Single(b => b.idbien == int.Parse(u_list[i].id));
                        decrease_biens(Convert.ToDouble(bn.Tva), Convert.ToDouble(bn?.PATTC));
                    }

                }

                txt_total_ht.Text = sm.ToString();
            }
            catch
            {

            }


        }
        int user_c = 0;
        List<article_usercontrol> u_list = new List<article_usercontrol>();
        double some_tva = 0;
        double some_ttc = 0;

        public void calc_biens(double tva, double ttc)
        {
            try
            {

                some_tva += tva;
                some_ttc += ttc;
                txt_total_ttc.Text = some_ttc.ToString();
                txt_total_tva.Text = some_tva.ToString();

            }
            catch { }
        }
        public void decrease_biens(double tva, double ttc)
        {
            try
            {

                some_tva -= tva;
                some_ttc -= ttc;
                txt_total_ttc.Text = some_ttc.ToString();
                txt_total_tva.Text = some_tva.ToString();

            }
            catch { }
        }
        public bool existed_bien(string id)
        {
            bool check = false;
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                    {
                        if (id == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        {
                            check = true;
                        }
                    }
                }


            }
            catch { }
            return check;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //article_usercontrol u = new article_usercontrol(txt_ref.Text,txt_desc.Text,txt_qte.Text);
                //u.Tag = user_c;
                //user_c++;
                //u_list.Add(u);
                //calc_ht();

                //u.StatusUpdated += new EventHandler(MyEventHandlerFunction_StatusUpdated);
                //u.deleted += new EventHandler(MyEventHandlerFunction_deleted);

                //bien bn = dc.biens.Single(b => b.idbien == int.Parse(txt_ref.Text));

                //calc_biens(Convert.ToDouble(bn.Tva), Convert.ToDouble(bn.PATTC));
                if (!isepty())
                {
                    if (!existed_bien(txt_ref.Text))
                    {
                        add_item();
                        calc_totals();
                        txt_montant.Text = "";
                        txt_pu.Text = "";
                        txt_qte.Text = "";
                        txt_desc.Text = "";
                        txt_ref.Text = "";
                    }
                    else
                    {

                        edit_item();
                        calc_totals();

                    }
                }


            }
            catch { }

        }
        public bool isepty()
        {
            bool check = true;
            if (txt_ref.Text != "" && txt_desc.Text != "" && txt_qte.Text != "" && txt_pu.Text != "" && txt_montant.Text != "")
                check = false;
            return check;
        }
        private void edit_item()
        {

            int i = -1;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if (dataGridView1.Rows[j].Cells[0].Value.ToString() == txt_ref.Text)
                    i = j;

            }

            dataGridView1.Rows[i].Cells[0].Value = txt_ref.Text;
            dataGridView1.Rows[i].Cells[1].Value = txt_desc.Text;
            dataGridView1.Rows[i].Cells[2].Value = txt_qte.Text;
            dataGridView1.Rows[i].Cells[3].Value = txt_pu.Text;
            dataGridView1.Rows[i].Cells[4].Value = txt_montant.Text;


        }

        public void calc_totals()
        {
            try
            {
                double ht = 0;
                double tva = 0;
                double ttc = 0;
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    ht += Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value.ToString());
                }
                txt_total_ht.Text = ht.ToString();
                tva = ht * 0.2;
                ttc = ht + tva;
                txt_total_ttc.Text = ttc.ToString();
                txt_total_tva.Text = tva.ToString();
            }
            catch { }

        }
        private void MyEventHandlerFunction_deleted(object sender, EventArgs e)
        {
            MessageBox.Show("deleyted user");
            refresh_totals();
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
            try
            {


            }
            catch { }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc_totals();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc_ht();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            search_lot s = new search_lot();
            try
            {
                if (s.ShowDialog() == DialogResult.OK)
                {

                    comb_lot.SelectedText = s.id;
                    comb_lot.SelectedValue = s.desc;
                }
            }
            catch { }
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
                comb_lot.ValueMember = "Opération";
                comb_lot.DisplayMember = "Référence_lot";
            }
            catch
            { }
        }


        private void Frm_bcfrs_Load(object sender, EventArgs e)
        {
            this.txt_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);


            fill_fournis();

            fill_lot();


        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)

            {
                try
                {


                    if (!isepty())
                    {
                        if (!existed_bien(txt_ref.Text))
                        {
                            add_item();
                            calc_totals();
                            txt_montant.Text = "";
                            txt_pu.Text = "";
                            txt_qte.Text = "";
                            txt_desc.Text = "";
                            txt_ref.Text = "";
                        }
                        else
                        {

                            edit_item();
                            calc_totals();

                        }
                    }


                }
                catch { }

            }

            if (e.KeyChar == (char)Keys.F1)
            {
                MessageBox.Show("tab");
                try
                {

                    if (txt_desc.Text != "")
                    {

                        string idd = txt_desc.Text;
                        article_template f = new article_template(idd, "inti");

                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (!existed_bien(f.id_bien.ToString()))
                            {
                                txt_desc.Text = f.desc.ToString();
                                txt_ref.Text = f.id_bien.ToString();
                                txt_qte.Text = 1.ToString();
                                txt_pu.Text = f.pu.ToString();
                                txt_montant.Text = f.pu.ToString();
                            }


                        }

                    }

                }
                catch { }
            }
            { }
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
        public void add_item()
        {
            try
            {

                dataGridView1.Rows.Add(txt_ref.Text, txt_desc.Text, txt_qte.Text, txt_pu.Text, txt_montant.Text);
            }
            catch { }

        }

        DataClasses1DataContext dc = new DataClasses1DataContext();
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                if (txt_ref.Text != "")
                {
                    string idd = txt_ref.Text;
                    article_template f = new article_template(idd, "id");

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        txt_desc.Text = f.desc.ToString();
                        txt_ref.Text = f.id_bien.ToString();
                        txt_qte.Text = 1.ToString();
                        txt_pu.Text = f.pu.ToString();
                        txt_montant.Text = f.pu.ToString();

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

                if (txt_desc.Text != "")
                {
                    string idd = txt_desc.Text;
                    article_template f = new article_template(idd, "inti");

                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        if (!existed_bien(f.id_bien.ToString()))
                        {
                            txt_desc.Text = f.desc.ToString();
                            txt_ref.Text = f.id_bien.ToString();
                            txt_qte.Text = 1.ToString();
                            txt_pu.Text = f.pu.ToString();
                            txt_montant.Text = f.pu.ToString();
                        }


                    }

                }

            }
            catch { }
        }

        private void flowLayoutPanel2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_qte.Text != "")
                {
                    txt_montant.Text = (int.Parse(txt_qte.Text) * int.Parse(txt_pu.Text)).ToString();
                }
                else

                    txt_qte.Text = "1";
            }
            catch { }

        }

        private void txt_pu_TextChanged(object sender, EventArgs e)
        {


        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                txt_ref.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_desc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_qte.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_pu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt_montant.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                i = dataGridView1.CurrentCell.RowIndex;
                txt_ref.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txt_desc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txt_qte.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txt_pu.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txt_montant.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void txt_desc_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {

                try
                {

                    if (txt_desc.Text != "")
                    {

                        string idd = txt_desc.Text;
                        article_template f = new article_template(idd, "inti");

                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (!existed_bien(f.id_bien.ToString()))
                            {
                                txt_desc.Text = f.desc.ToString();
                                txt_ref.Text = f.id_bien.ToString();
                                txt_qte.Text = 1.ToString();
                                txt_pu.Text = f.pu.ToString();
                                txt_montant.Text = f.pu.ToString();
                            }


                        }

                    }

                }
                catch { }
            }
        }
        int j;
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                j = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(i);
            }
            catch { }

        }

        private void txt_qte_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {

                try
                {

                    if (txt_desc.Text != "")
                    {

                        string idd = txt_desc.Text;
                        article_template f = new article_template(idd, "inti");

                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            if (!existed_bien(f.id_bien.ToString()))
                            {
                                txt_desc.Text = f.desc.ToString();
                                txt_ref.Text = f.id_bien.ToString();
                                txt_qte.Text = 1.ToString();
                                txt_pu.Text = f.pu.ToString();
                                txt_montant.Text = f.pu.ToString();
                            }


                        }

                    }

                }
                catch { }
            }
        }

        private void txt_pu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
