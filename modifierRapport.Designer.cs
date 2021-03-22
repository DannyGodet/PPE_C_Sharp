namespace App_GSB_Danny_G
{
    partial class modifierRapport
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
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Collaborateur = new System.Windows.Forms.ComboBox();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Echant = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_verif_Praticien = new System.Windows.Forms.Button();
            this.txb_bilan = new System.Windows.Forms.TextBox();
            this.cb_Motif = new System.Windows.Forms.ComboBox();
            this.cb_praticien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_CoefConf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_rap = new System.Windows.Forms.ComboBox();
            this.medoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qtemedoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pl_remplacent = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Rempla = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pl_coll = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Echant)).BeginInit();
            this.pl_remplacent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(247, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selectionner un collaborateur :";
            // 
            // cb_Collaborateur
            // 
            this.cb_Collaborateur.FormattingEnabled = true;
            this.cb_Collaborateur.Location = new System.Drawing.Point(398, 23);
            this.cb_Collaborateur.Name = "cb_Collaborateur";
            this.cb_Collaborateur.Size = new System.Drawing.Size(121, 21);
            this.cb_Collaborateur.TabIndex = 15;
            this.cb_Collaborateur.SelectedIndexChanged += new System.EventHandler(this.cb_Collaborateur_SelectedIndexChanged);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Enregistrer.FlatAppearance.BorderSize = 0;
            this.btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enregistrer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Enregistrer.Location = new System.Drawing.Point(486, 343);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(199, 34);
            this.btn_Enregistrer.TabIndex = 31;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Modifier un rapport";
            // 
            // DGV_Echant
            // 
            this.DGV_Echant.AllowDrop = true;
            this.DGV_Echant.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Echant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Echant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medoc,
            this.Qtemedoc});
            this.DGV_Echant.Location = new System.Drawing.Point(23, 288);
            this.DGV_Echant.Name = "DGV_Echant";
            this.DGV_Echant.Size = new System.Drawing.Size(294, 105);
            this.DGV_Echant.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Date de la visite";
            // 
            // btn_verif_Praticien
            // 
            this.btn_verif_Praticien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_verif_Praticien.FlatAppearance.BorderSize = 0;
            this.btn_verif_Praticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verif_Praticien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_verif_Praticien.Location = new System.Drawing.Point(209, 87);
            this.btn_verif_Praticien.Name = "btn_verif_Praticien";
            this.btn_verif_Praticien.Size = new System.Drawing.Size(60, 34);
            this.btn_verif_Praticien.TabIndex = 43;
            this.btn_verif_Praticien.Text = "Vérifier";
            this.btn_verif_Praticien.UseVisualStyleBackColor = false;
            // 
            // txb_bilan
            // 
            this.txb_bilan.Location = new System.Drawing.Point(421, 214);
            this.txb_bilan.Multiline = true;
            this.txb_bilan.Name = "txb_bilan";
            this.txb_bilan.Size = new System.Drawing.Size(338, 52);
            this.txb_bilan.TabIndex = 41;
            // 
            // cb_Motif
            // 
            this.cb_Motif.FormattingEnabled = true;
            this.cb_Motif.Location = new System.Drawing.Point(23, 253);
            this.cb_Motif.Name = "cb_Motif";
            this.cb_Motif.Size = new System.Drawing.Size(148, 21);
            this.cb_Motif.TabIndex = 40;
            // 
            // cb_praticien
            // 
            this.cb_praticien.FormattingEnabled = true;
            this.cb_praticien.Location = new System.Drawing.Point(23, 95);
            this.cb_praticien.Name = "cb_praticien";
            this.cb_praticien.Size = new System.Drawing.Size(148, 21);
            this.cb_praticien.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Coéfficent de confiance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Bilan de la visite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Motif de la visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Praticien";
            // 
            // txb_CoefConf
            // 
            this.txb_CoefConf.Location = new System.Drawing.Point(421, 150);
            this.txb_CoefConf.Name = "txb_CoefConf";
            this.txb_CoefConf.Size = new System.Drawing.Size(36, 20);
            this.txb_CoefConf.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(547, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Numéro Rapport :";
            // 
            // cb_rap
            // 
            this.cb_rap.FormattingEnabled = true;
            this.cb_rap.Location = new System.Drawing.Point(638, 23);
            this.cb_rap.Name = "cb_rap";
            this.cb_rap.Size = new System.Drawing.Size(121, 21);
            this.cb_rap.TabIndex = 50;
            this.cb_rap.SelectedIndexChanged += new System.EventHandler(this.cb_rap_SelectedIndexChanged);
            // 
            // medoc
            // 
            this.medoc.HeaderText = "Médicament";
            this.medoc.Name = "medoc";
            this.medoc.Width = 150;
            // 
            // Qtemedoc
            // 
            this.Qtemedoc.HeaderText = "Quantité";
            this.Qtemedoc.Name = "Qtemedoc";
            // 
            // pl_remplacent
            // 
            this.pl_remplacent.Controls.Add(this.button1);
            this.pl_remplacent.Controls.Add(this.cb_Rempla);
            this.pl_remplacent.Controls.Add(this.label9);
            this.pl_remplacent.Location = new System.Drawing.Point(23, 176);
            this.pl_remplacent.Name = "pl_remplacent";
            this.pl_remplacent.Size = new System.Drawing.Size(259, 58);
            this.pl_remplacent.TabIndex = 51;
            this.pl_remplacent.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(186, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Vérifier";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cb_Rempla
            // 
            this.cb_Rempla.FormattingEnabled = true;
            this.cb_Rempla.Location = new System.Drawing.Point(0, 20);
            this.cb_Rempla.Name = "cb_Rempla";
            this.cb_Rempla.Size = new System.Drawing.Size(148, 21);
            this.cb_Rempla.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Praticien remplacé :";
            // 
            // pl_coll
            // 
            this.pl_coll.Location = new System.Drawing.Point(230, 3);
            this.pl_coll.Name = "pl_coll";
            this.pl_coll.Size = new System.Drawing.Size(308, 78);
            this.pl_coll.TabIndex = 52;
            this.pl_coll.Visible = false;
            // 
            // modifierRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_remplacent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_rap);
            this.Controls.Add(this.txb_CoefConf);
            this.Controls.Add(this.DGV_Echant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_verif_Praticien);
            this.Controls.Add(this.txb_bilan);
            this.Controls.Add(this.cb_Motif);
            this.Controls.Add(this.cb_praticien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Collaborateur);
            this.Controls.Add(this.pl_coll);
            this.Name = "modifierRapport";
            this.Size = new System.Drawing.Size(776, 411);
            this.Load += new System.EventHandler(this.modifierRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Echant)).EndInit();
            this.pl_remplacent.ResumeLayout(false);
            this.pl_remplacent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Collaborateur;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Echant;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_verif_Praticien;
        private System.Windows.Forms.TextBox txb_bilan;
        private System.Windows.Forms.ComboBox cb_Motif;
        private System.Windows.Forms.ComboBox cb_praticien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_CoefConf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_rap;
        private System.Windows.Forms.DataGridViewComboBoxColumn medoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtemedoc;
        private System.Windows.Forms.Panel pl_remplacent;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Rempla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pl_coll;
    }
}
