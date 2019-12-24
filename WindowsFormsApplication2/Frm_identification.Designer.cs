namespace WindowsFormsApplication2
{
    partial class Frm_identification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ref_lot = new System.Windows.Forms.TextBox();
            this.ref_flap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.combo_client = new System.Windows.Forms.ComboBox();
            this.combo_maitre = new System.Windows.Forms.ComboBox();
            this.combo_soustrait = new System.Windows.Forms.ComboBox();
            this.combo_bureau = new System.Windows.Forms.ComboBox();
            this.combo_labo = new System.Windows.Forms.ComboBox();
            this.combo_arch = new System.Windows.Forms.ComboBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.localisation = new System.Windows.Forms.TextBox();
            this.ref_contrat = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ht = new System.Windows.Forms.TextBox();
            this.tva = new System.Windows.Forms.TextBox();
            this.ttc = new System.Windows.Forms.TextBox();
            this.prorate = new System.Windows.Forms.TextBox();
            this.garantie = new System.Windows.Forms.TextBox();
            this.autre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combo_tva = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fiche de lot :";
            this.label1.UseMnemonic = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(172, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 22);
            this.label23.TabIndex = 2;
            this.label23.Text = "Identification";
            this.label23.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 28);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(11, 638);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(761, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "Référence de lot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Référence Plan";
            // 
            // ref_lot
            // 
            this.ref_lot.Location = new System.Drawing.Point(203, 116);
            this.ref_lot.Name = "ref_lot";
            this.ref_lot.Size = new System.Drawing.Size(210, 20);
            this.ref_lot.TabIndex = 42;
            // 
            // ref_flap
            // 
            this.ref_flap.Location = new System.Drawing.Point(569, 114);
            this.ref_flap.Name = "ref_flap";
            this.ref_flap.Size = new System.Drawing.Size(236, 20);
            this.ref_flap.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Référence contrat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Date du contrat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Période réalisation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "Opération";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Localisation chantier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "Total marché (HT)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Tva (taux tva)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 19);
            this.label10.TabIndex = 51;
            this.label10.Text = "Total marché (TTC)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(434, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 19);
            this.label11.TabIndex = 52;
            this.label11.Text = "Taux du Prorata";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 19);
            this.label12.TabIndex = 53;
            this.label12.Text = "Taux du Garantie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(434, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 19);
            this.label13.TabIndex = 54;
            this.label13.Text = "Taux du (autre)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 19);
            this.label14.TabIndex = 55;
            this.label14.Text = "Client";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(45, 456);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 19);
            this.label16.TabIndex = 56;
            this.label16.Text = "Maître d\'ouvrage";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(45, 484);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 19);
            this.label17.TabIndex = 57;
            this.label17.Text = "Sous-Traitant";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(43, 569);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 19);
            this.label18.TabIndex = 58;
            this.label18.Text = "Architecte";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 536);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 19);
            this.label19.TabIndex = 59;
            this.label19.Text = "Laboratoire";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 511);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 19);
            this.label20.TabIndex = 60;
            this.label20.Text = "Bureau d\'études";
            // 
            // combo_client
            // 
            this.combo_client.FormattingEnabled = true;
            this.combo_client.Location = new System.Drawing.Point(203, 429);
            this.combo_client.Name = "combo_client";
            this.combo_client.Size = new System.Drawing.Size(513, 21);
            this.combo_client.TabIndex = 61;
            // 
            // combo_maitre
            // 
            this.combo_maitre.FormattingEnabled = true;
            this.combo_maitre.Location = new System.Drawing.Point(203, 456);
            this.combo_maitre.Name = "combo_maitre";
            this.combo_maitre.Size = new System.Drawing.Size(513, 21);
            this.combo_maitre.TabIndex = 62;
            // 
            // combo_soustrait
            // 
            this.combo_soustrait.FormattingEnabled = true;
            this.combo_soustrait.Location = new System.Drawing.Point(203, 483);
            this.combo_soustrait.Name = "combo_soustrait";
            this.combo_soustrait.Size = new System.Drawing.Size(513, 21);
            this.combo_soustrait.TabIndex = 63;
            // 
            // combo_bureau
            // 
            this.combo_bureau.FormattingEnabled = true;
            this.combo_bureau.Location = new System.Drawing.Point(203, 510);
            this.combo_bureau.Name = "combo_bureau";
            this.combo_bureau.Size = new System.Drawing.Size(513, 21);
            this.combo_bureau.TabIndex = 64;
            // 
            // combo_labo
            // 
            this.combo_labo.FormattingEnabled = true;
            this.combo_labo.Location = new System.Drawing.Point(202, 537);
            this.combo_labo.Name = "combo_labo";
            this.combo_labo.Size = new System.Drawing.Size(513, 21);
            this.combo_labo.TabIndex = 65;
            // 
            // combo_arch
            // 
            this.combo_arch.FormattingEnabled = true;
            this.combo_arch.Location = new System.Drawing.Point(203, 569);
            this.combo_arch.Name = "combo_arch";
            this.combo_arch.Size = new System.Drawing.Size(513, 21);
            this.combo_arch.TabIndex = 66;
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(202, 202);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(603, 20);
            this.operation.TabIndex = 67;
            this.operation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // localisation
            // 
            this.localisation.Location = new System.Drawing.Point(202, 230);
            this.localisation.Name = "localisation";
            this.localisation.Size = new System.Drawing.Size(603, 20);
            this.localisation.TabIndex = 68;
            // 
            // ref_contrat
            // 
            this.ref_contrat.Location = new System.Drawing.Point(202, 142);
            this.ref_contrat.Name = "ref_contrat";
            this.ref_contrat.Size = new System.Drawing.Size(210, 20);
            this.ref_contrat.TabIndex = 69;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(199, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 19);
            this.label21.TabIndex = 72;
            this.label21.Text = "De";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(510, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 19);
            this.label22.TabIndex = 73;
            this.label22.Text = "A";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(569, 170);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker2.TabIndex = 74;
            // 
            // ht
            // 
            this.ht.Location = new System.Drawing.Point(202, 300);
            this.ht.Name = "ht";
            this.ht.Size = new System.Drawing.Size(210, 20);
            this.ht.TabIndex = 75;
            // 
            // tva
            // 
            this.tva.Location = new System.Drawing.Point(242, 326);
            this.tva.Name = "tva";
            this.tva.Size = new System.Drawing.Size(170, 20);
            this.tva.TabIndex = 76;
            // 
            // ttc
            // 
            this.ttc.Location = new System.Drawing.Point(202, 352);
            this.ttc.Name = "ttc";
            this.ttc.Size = new System.Drawing.Size(210, 20);
            this.ttc.TabIndex = 77;
            // 
            // prorate
            // 
            this.prorate.Location = new System.Drawing.Point(595, 298);
            this.prorate.Name = "prorate";
            this.prorate.Size = new System.Drawing.Size(210, 20);
            this.prorate.TabIndex = 78;
            // 
            // garantie
            // 
            this.garantie.Location = new System.Drawing.Point(595, 324);
            this.garantie.Name = "garantie";
            this.garantie.Size = new System.Drawing.Size(210, 20);
            this.garantie.TabIndex = 79;
            // 
            // autre
            // 
            this.autre.Location = new System.Drawing.Point(595, 350);
            this.autre.Name = "autre";
            this.autre.Size = new System.Drawing.Size(210, 20);
            this.autre.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 179);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identité";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combo_tva);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 119);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chiffre";
            // 
            // combo_tva
            // 
            this.combo_tva.FormattingEnabled = true;
            this.combo_tva.Items.AddRange(new object[] {
            "0",
            "20"});
            this.combo_tva.Location = new System.Drawing.Point(178, 50);
            this.combo_tva.Name = "combo_tva";
            this.combo_tva.Size = new System.Drawing.Size(34, 24);
            this.combo_tva.TabIndex = 56;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(24, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(797, 208);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiers";
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(698, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "Ajouter";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(698, 135);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Ajouter";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(698, 107);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Ajouter";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(698, 79);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Ajouter";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(698, 51);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Ajouter";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(198)))), ((int)(((byte)(217)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(698, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Ajouter";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(722, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Ajouter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(722, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Ajouter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(722, 485);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Ajouter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button9_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(722, 513);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Ajouter";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button10_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(722, 541);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "Ajouter";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button11_Click);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(722, 568);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "Ajouter";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(569, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(236, 20);
            this.textBox6.TabIndex = 70;
            // 
            // Frm_identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 671);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.autre);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.garantie);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.prorate);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ttc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tva);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ht);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ref_contrat);
            this.Controls.Add(this.localisation);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.combo_arch);
            this.Controls.Add(this.combo_labo);
            this.Controls.Add(this.combo_bureau);
            this.Controls.Add(this.combo_soustrait);
            this.Controls.Add(this.combo_maitre);
            this.Controls.Add(this.combo_client);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ref_flap);
            this.Controls.Add(this.ref_lot);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_identification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_identification";
            this.Load += new System.EventHandler(this.Frm_identification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ref_lot;
        private System.Windows.Forms.TextBox ref_flap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox combo_client;
        private System.Windows.Forms.ComboBox combo_maitre;
        private System.Windows.Forms.ComboBox combo_soustrait;
        private System.Windows.Forms.ComboBox combo_bureau;
        private System.Windows.Forms.ComboBox combo_labo;
        private System.Windows.Forms.ComboBox combo_arch;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.TextBox localisation;
        private System.Windows.Forms.TextBox ref_contrat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox ht;
        private System.Windows.Forms.TextBox tva;
        private System.Windows.Forms.TextBox ttc;
        private System.Windows.Forms.TextBox prorate;
        private System.Windows.Forms.TextBox garantie;
        private System.Windows.Forms.TextBox autre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ComboBox combo_tva;
        private System.Windows.Forms.TextBox textBox6;
    }
}