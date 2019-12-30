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
    public partial class bon_reception_1 : Form
    {
        public bon_reception_1()
        {
            InitializeComponent();

        }
        Sqlcon c = new Sqlcon();
        private void label3_Click(object sender, EventArgs e)
        {

        }
        bool valid = false;
        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0 && !valid)
            {
                try
                {
                    DialogResult res = MessageBox.Show("Veuillez-vous évidemment valider cette opération ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        valider();
                        this.Close();


                    }
                    else if (res == DialogResult.No)
                    {
                        this.Close();
                    }


                }
                catch { }
            }
            else
            {
                this.Close();

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
                    //combo_frns.SelectedText = s.id;
                    //combo_frns.SelectedValue = s.desc;

                    textBox1.Text = s.id;
                    txt_fournis.Text = s.desc;
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


                if (!isepty())
                {
                    if (!existed_bien(txt_ref.Text))
                    {
                        add_item();
                        calc_totals();
                        vider();
                        valid = false;
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

        private void vider()
        {
            txt_montant.Text = "";
            txt_pu.Text = "";
            txt_qte.Text = "";
            txt_desc.Text = "";
            txt_ref.Text = "";
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
            try
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
                vider();
            }
            catch { }


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
            valider();

        }

        private void valider()
        {
            try
            {
                bon_recep bn = new bon_recep();
                bn.date_com = dateTimePicker1.Value;
                bn.desc_fournis = txt_fournis.Text;
                bn.desc_lot = txt_lot.Text;
                bn.id_fournis = Convert.ToInt32(textBox1.Text);
                bn.id_lot = Convert.ToInt32(label_id_lot.Text);
                bn.montant_ht = Convert.ToDecimal(txt_total_ht.Text);
                bn.montant_ttc = Convert.ToDecimal(txt_total_ttc.Text);
                bn.montant_tva = Convert.ToDecimal(txt_total_tva.Text);

                dc.bon_receps.InsertOnSubmit(bn);
                dc.SubmitChanges();
                valid = true;
                this.Close();

               
            }
            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            search_lot s = new search_lot();
            try
            {
                if (s.ShowDialog() == DialogResult.OK)
                {

                    //comb_lot.SelectedText = s.id;
                    //comb_lot.SelectedValue = s.desc;
                    //comb_lot.SelectedValue = s.r_id;
                    textBox2.Text = s.desc;
                    txt_lot.Text = s.id;
                    label_id_lot.Text = s.r_id;

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

                //SqlCommand cmd = new SqlCommand("select * from Fournisseur", c.cnx);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);

                //combo_frns.DataSource = dt;
                //combo_frns.ValueMember = "Intitulé";
                //combo_frns.DisplayMember = "Idfournisseur";
            }
            catch
            { }
        }

        public void fill_lot()
        {
            try
            {

                //SqlCommand cmd = new SqlCommand("select * from identification", c.cnx);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);

                //comb_lot.DataSource = dt;
                //comb_lot.ValueMember = "Opération";
                //comb_lot.DisplayMember = "Référence_lot";
            }
            catch
            { }
        }


        private void Frm_bcfrs_Load(object sender, EventArgs e)
        {
            try
            {
                this.txt_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnterKeyPress);

                int count = 0;
                SqlCommand cmd = new SqlCommand("select * from bon_recep ", c.cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    count++;
                }
                dr.Close();
                txt1.Text = "REC-" + (count + 1);
            }
            catch { }

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
                            valid = false;
                            vider();
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

                        string idd = txt_ref.Text;
                        article_template f = new article_template(idd, "id");

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
            //txt_fournis.Text = combo_frns.SelectedValue.ToString();
        }

        private void comb_lot_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_lot.Text = comb_lot.SelectedValue.ToString();

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
                DialogResult res = MessageBox.Show("Veuillez-vous voulez-vous vraiment supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    j = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(i);
                    vider();

                }

            }
            catch { }

        }

        private void txt_qte_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)

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
                            valid = false;
                            vider();
                        }
                        else
                        {

                            edit_item();
                            calc_totals();
                            vider();

                        }
                    }


                }
                catch { }

            }
        }


        private void txt_pu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txt_ref_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {

                try
                {

                    if (txt_ref.Text != "")
                    {

                        string idd = txt_ref.Text;
                        article_template f = new article_template(idd, "id");

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

        private void txt_montant_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)

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
                            valid = false;
                            vider();
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
        }

        private void dataGridView1_Click(object sender, EventArgs e)
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
    }
}
