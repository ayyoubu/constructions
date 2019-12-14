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
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void factureSurProrataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bonDeLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_blfrs s = new Frm_blfrs();
            s.ShowDialog();
        }

        private void récapitulatifToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void identificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_identification n = new Frm_identification();

            n.Show();

            
        }

        private void bordoreauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_bord s = new Frm_bord();
            s.ShowDialog();
        }

        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_equipe s = new Frm_equipe();
            s.ShowDialog();
        }

        private void familleDarticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_famille s = new Frm_famille();
            s.ShowDialog();
        }

        private void bienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_bien s = new Frm_bien();
            s.ShowDialog();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_clt s = new Frm_clt();
            s.ShowDialog();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_frs s = new Frm_frs();
            s.ShowDialog();
        }

        private void architecteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_architecte s = new Frm_architecte();
            s.ShowDialog();
        }

        private void maitreDouvrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_maitre s = new Frm_maitre();
            s.ShowDialog();
        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_labo s = new Frm_labo();
            s.ShowDialog();
        }

        private void bureauDétudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_bureau s = new Frm_bureau();
            s.ShowDialog();
        }

        private void aProposDeLaSociétéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_apropos s = new Frm_apropos();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void catégorieDeBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_catbien s = new Frm_catbien();
            s.ShowDialog();
        }

        private void catégorieRémunirationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_catrem s = new Frm_catrem();
            s.ShowDialog();
        }

        private void modeDeRémunirationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_moderem s = new Frm_moderem();
            s.ShowDialog();
        }

        private void posteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_poste s = new Frm_poste();
            s.ShowDialog();
        }

        private void tâcheGlobaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_tacheglb s = new Frm_tacheglb();
            s.ShowDialog();
        }

        private void unitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_unite s = new Frm_unite();
            s.ShowDialog();
        }

        private void interrogationDeLotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Listechantier s = new Frm_Listechantier();
            s.ShowDialog();
        }

        private void interrogationClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listeclient s = new Frm_listeclient();
            s.ShowDialog();
        }

        private void interrogationFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listefrs s = new Frm_listefrs();
            s.ShowDialog();
        }

        private void interrogationDachatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bonDeCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_bcfrs s = new Frm_bcfrs();
            s.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bonDeRetourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_brtfrs s = new Frm_brtfrs ();
            s.ShowDialog();
        }

        private void factureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_facfrs s = new Frm_facfrs();
            s.ShowDialog();
        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {



        }

        private void codeDeTaxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_code_tax s = new Frm_code_tax();
            s.ShowDialog();
        }

        private void catégoriePJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cat_pj s = new Frm_Cat_pj();
            s.ShowDialog();
        }

        private void avoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_avoir s = new Frm_avoir();
            s.ShowDialog();
        }

        private void devisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_devis s = new Frm_devis();
            s.ShowDialog();
        }
    }
    }

