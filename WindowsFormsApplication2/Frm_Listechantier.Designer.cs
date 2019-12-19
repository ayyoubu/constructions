namespace WindowsFormsApplication2
{
    partial class Frm_Listechantier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Référence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Réf_Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Réf_Contrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Contrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Début = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Architecte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bureau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 28);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interrogation de lot";
            this.label1.UseMnemonic = false;
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Référence,
            this.Réf_Plan,
            this.Réf_Contrat,
            this.Date_Contrat,
            this.Client,
            this.Date_Début,
            this.Date_Fin,
            this.Nature,
            this.Localisation,
            this.Maitre,
            this.Architecte,
            this.Laboratoire,
            this.Bureau});
            this.dgv1.Location = new System.Drawing.Point(0, 28);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(1294, 605);
            this.dgv1.TabIndex = 2;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Référence
            // 
            this.Référence.HeaderText = "Référence";
            this.Référence.Name = "Référence";
            // 
            // Réf_Plan
            // 
            this.Réf_Plan.HeaderText = "Réf Plan";
            this.Réf_Plan.Name = "Réf_Plan";
            // 
            // Réf_Contrat
            // 
            this.Réf_Contrat.HeaderText = "Réf Contrat";
            this.Réf_Contrat.Name = "Réf_Contrat";
            // 
            // Date_Contrat
            // 
            this.Date_Contrat.HeaderText = "Date Contrat";
            this.Date_Contrat.Name = "Date_Contrat";
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // Date_Début
            // 
            this.Date_Début.HeaderText = "Date Début";
            this.Date_Début.Name = "Date_Début";
            // 
            // Date_Fin
            // 
            this.Date_Fin.HeaderText = "Date Fin";
            this.Date_Fin.Name = "Date_Fin";
            // 
            // Nature
            // 
            this.Nature.HeaderText = "Nature";
            this.Nature.Name = "Nature";
            // 
            // Localisation
            // 
            this.Localisation.HeaderText = "Localisation";
            this.Localisation.Name = "Localisation";
            // 
            // Maitre
            // 
            this.Maitre.HeaderText = "Maitre";
            this.Maitre.Name = "Maitre";
            // 
            // Architecte
            // 
            this.Architecte.HeaderText = "Architecte";
            this.Architecte.Name = "Architecte";
            // 
            // Laboratoire
            // 
            this.Laboratoire.HeaderText = "Laboratoire";
            this.Laboratoire.Name = "Laboratoire";
            // 
            // Bureau
            // 
            this.Bureau.HeaderText = "Bureau";
            this.Bureau.Name = "Bureau";
            // 
            // btn_new
            // 
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(12, 640);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 73;
            this.btn_new.Text = "Ajouter";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(174, 640);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 81;
            this.button5.Text = "Supprimer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(93, 640);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 80;
            this.button4.Text = "Modifier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(138)))), ((int)(((byte)(141)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1207, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 78;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Listechantier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 675);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Listechantier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Listechantier";
            this.Load += new System.EventHandler(this.Frm_Listechantier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Référence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Réf_Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Réf_Contrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Contrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Début;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Architecte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bureau;
        public System.Windows.Forms.DataGridView dgv1;
    }
}