namespace App_GSB_Danny_G
{
    partial class AfficherRapport
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_Rapport = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_verif_rapport = new System.Windows.Forms.Button();
            this.Collaborateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Rap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Praticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Visite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bilan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Saisie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coef_Conf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Rapport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Liste des Rapports";
            // 
            // dg_Rapport
            // 
            this.dg_Rapport.AllowUserToAddRows = false;
            this.dg_Rapport.AllowUserToDeleteRows = false;
            this.dg_Rapport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Rapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Rapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Collaborateur,
            this.Numero_Rap,
            this.Praticien,
            this.Date_Visite,
            this.Bilan,
            this.Date_Saisie,
            this.Coef_Conf,
            this.Motif});
            this.dg_Rapport.Location = new System.Drawing.Point(48, 74);
            this.dg_Rapport.Name = "dg_Rapport";
            this.dg_Rapport.ReadOnly = true;
            this.dg_Rapport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_Rapport.Size = new System.Drawing.Size(680, 279);
            this.dg_Rapport.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_verif_rapport
            // 
            this.btn_verif_rapport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_verif_rapport.FlatAppearance.BorderSize = 0;
            this.btn_verif_rapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verif_rapport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_verif_rapport.Location = new System.Drawing.Point(601, 364);
            this.btn_verif_rapport.Name = "btn_verif_rapport";
            this.btn_verif_rapport.Size = new System.Drawing.Size(127, 34);
            this.btn_verif_rapport.TabIndex = 24;
            this.btn_verif_rapport.Text = "Détail Rapport";
            this.btn_verif_rapport.UseVisualStyleBackColor = false;
            // 
            // Collaborateur
            // 
            this.Collaborateur.HeaderText = "Collaborateur";
            this.Collaborateur.Name = "Collaborateur";
            this.Collaborateur.ReadOnly = true;
            // 
            // Numero_Rap
            // 
            this.Numero_Rap.HeaderText = "Numéro_Rap";
            this.Numero_Rap.Name = "Numero_Rap";
            this.Numero_Rap.ReadOnly = true;
            // 
            // Praticien
            // 
            this.Praticien.HeaderText = "Praticien";
            this.Praticien.Name = "Praticien";
            this.Praticien.ReadOnly = true;
            // 
            // Date_Visite
            // 
            this.Date_Visite.HeaderText = "Date_Visite";
            this.Date_Visite.Name = "Date_Visite";
            this.Date_Visite.ReadOnly = true;
            // 
            // Bilan
            // 
            this.Bilan.HeaderText = "Bilan";
            this.Bilan.Name = "Bilan";
            this.Bilan.ReadOnly = true;
            // 
            // Date_Saisie
            // 
            this.Date_Saisie.HeaderText = "Date_Saisie";
            this.Date_Saisie.Name = "Date_Saisie";
            this.Date_Saisie.ReadOnly = true;
            // 
            // Coef_Conf
            // 
            this.Coef_Conf.HeaderText = "Coef_Conf";
            this.Coef_Conf.Name = "Coef_Conf";
            this.Coef_Conf.ReadOnly = true;
            // 
            // Motif
            // 
            this.Motif.HeaderText = "Motif";
            this.Motif.Name = "Motif";
            this.Motif.ReadOnly = true;
            // 
            // AfficherRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Rapport);
            this.Controls.Add(this.btn_verif_rapport);
            this.Name = "AfficherRapport";
            this.Size = new System.Drawing.Size(776, 411);
            this.Load += new System.EventHandler(this.AfficherRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Rapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Rapport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.Button btn_verif_rapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collaborateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Rap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Praticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Visite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bilan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Saisie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef_Conf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
    }
}
