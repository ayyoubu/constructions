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
            Frm_facprorata s = new Frm_facprorata();
            s.ShowDialog();
        }

        private void bonDeLivraisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bon_reception_1 s = new bon_reception_1();
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
            form_maitre_ouvrage s = new form_maitre_ouvrage();
            s.ShowDialog();
        }

        private void laboratoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_labo s = new form_labo();
            s.ShowDialog();
        }

        private void bureauDétudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bureau_etude s = new bureau_etude();
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
            //the new template
            frm_mode_renumeration s = new frm_mode_renumeration();
            s.ShowDialog();
        }

        private void posteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_poste s = new Frm_poste();
            s.ShowDialog();
        }

        private void tâcheGlobaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_tache_glob s = new frm_tache_glob();
            s.ShowDialog();
        }

        private void unitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_unite s = new form_unite();
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
            bon_retour1 s = new bon_retour1();
            s.ShowDialog();
        }

        private void factureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bon_facture1 s = new bon_facture1();
            s.ShowDialog();
        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {



        }

        private void codeDeTaxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_code_de_tax s = new frm_code_de_tax();
            s.ShowDialog();
        }

        private void catégoriePJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorie_pj s = new frm_categorie_pj();
            s.ShowDialog();
        }

        private void avoirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bon_avoir1  s = new bon_avoir1();
            s.ShowDialog();
        }

        private void devisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_devis s = new Frm_devis();
            s.ShowDialog();
        }

        private void gestionDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_stock s = new Frm_stock();
            s.ShowDialog();
        }

        private void factureSurDécompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_facdecompte S = new Frm_facdecompte();
            S.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_identification s = new Frm_identification();
            s.ShowDialog();
        }

        private void factureSurGarantieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_facgarantie s = new Frm_facgarantie();
            s.ShowDialog();
        }

        private void intérrogationBordoreauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_liste_tab_bordoreau s = new Frm_liste_tab_bordoreau();
            s.ShowDialog();
        }

        private void gestionRéglementClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_regclt s = new Frm_regclt();
            s.ShowDialog();
        }

        private void gestionRéglementFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_regfrs s = new Frm_regfrs();
            s.ShowDialog();
        }

        private void bonDeCommandeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listeBC s = new Frm_listeBC();
            s.ShowDialog();
        }

        private void bonDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listeBL s = new Frm_listeBL();
            s.ShowDialog();
        }

        private void factureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listeFacFRS s = new Frm_listeFacFRS();
            s.ShowDialog();
        }

        private void bonDeRetourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listeBR s = new Frm_listeBR();
            s.ShowDialog();
        }

        private void avoirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listeAvoir s = new Frm_listeAvoir();
            s.ShowDialog();
        }

        private void devisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listeDevis s = new Frm_listeDevis();
            s.ShowDialog();
        }

        private void factureDeProrataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listeFacProrata s = new Frm_listeFacProrata();
            s.ShowDialog();
        }

        private void factureDeDécompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listeFacDecompte s = new Frm_listeFacDecompte();
            s.ShowDialog();
        }

        private void factureDeGarantieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listeFacGarantie s = new Frm_listeFacGarantie();
            s.ShowDialog();
        }

        private void pièceJointeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_newPJ s = new Frm_newPJ();
            s.ShowDialog();
        }

        private void généralisationDeLotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EtatGeneral s = new EtatGeneral();
            s.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void intérrogationDachatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tachePrimaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tache_primaire1 t = new tache_primaire1();
            t.Show();
        }
    }
    }
    

