namespace App_GSB_Danny_G
{
    partial class AfficherPraticien
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
            this.dg_Praticien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_verif_Praticien = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoefNot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypePra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Praticien)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Praticien
            // 
            this.dg_Praticien.AllowUserToAddRows = false;
            this.dg_Praticien.AllowUserToDeleteRows = false;
            this.dg_Praticien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_Praticien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Praticien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nom,
            this.Prénom,
            this.Adresse,
            this.CodeP,
            this.Ville,
            this.CoefNot,
            this.TypePra});
            this.dg_Praticien.Location = new System.Drawing.Point(40, 84);
            this.dg_Praticien.Name = "dg_Praticien";
            this.dg_Praticien.ReadOnly = true;
            this.dg_Praticien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_Praticien.Size = new System.Drawing.Size(680, 279);
            this.dg_Praticien.TabIndex = 0;
            this.dg_Praticien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Praticien_CellContentClick);
            this.dg_Praticien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_Praticien_RowHeaderClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Praticien";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // btn_verif_Praticien
            // 
            this.btn_verif_Praticien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_verif_Praticien.FlatAppearance.BorderSize = 0;
            this.btn_verif_Praticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verif_Praticien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_verif_Praticien.Location = new System.Drawing.Point(593, 374);
            this.btn_verif_Praticien.Name = "btn_verif_Praticien";
            this.btn_verif_Praticien.Size = new System.Drawing.Size(127, 34);
            this.btn_verif_Praticien.TabIndex = 21;
            this.btn_verif_Praticien.Text = "Détail Praticien";
            this.btn_verif_Praticien.UseVisualStyleBackColor = false;
            this.btn_verif_Praticien.Click += new System.EventHandler(this.btn_verif_Praticien_Click);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numéro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 60;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // CodeP
            // 
            this.CodeP.HeaderText = "Code Postal";
            this.CodeP.Name = "CodeP";
            this.CodeP.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // CoefNot
            // 
            this.CoefNot.HeaderText = "CoefNot";
            this.CoefNot.Name = "CoefNot";
            this.CoefNot.ReadOnly = true;
            // 
            // TypePra
            // 
            this.TypePra.HeaderText = "TypePraticien";
            this.TypePra.Name = "TypePra";
            this.TypePra.ReadOnly = true;
            // 
            // AfficherPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_verif_Praticien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Praticien);
            this.Name = "AfficherPraticien";
            this.Size = new System.Drawing.Size(776, 411);
            this.Load += new System.EventHandler(this.AfficherPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Praticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Praticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.Button btn_verif_Praticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoefNot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypePra;
    }
}
