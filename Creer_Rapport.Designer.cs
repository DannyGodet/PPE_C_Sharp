namespace App_GSB_Danny_G
{
    partial class Creer_Rapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_numCR = new System.Windows.Forms.TextBox();
            this.TB_Confiance = new System.Windows.Forms.TrackBar();
            this.cb_praticien = new System.Windows.Forms.ComboBox();
            this.cb_Motif = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_bilan = new System.Windows.Forms.TextBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.Valeur_TBConf = new System.Windows.Forms.Label();
            this.btn_CreerRapport = new System.Windows.Forms.Button();
            this.btn_verif_Praticien = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CB_echant = new System.Windows.Forms.CheckBox();
            this.DGV_Echant = new System.Windows.Forms.DataGridView();
            this.ckb_remplacent = new System.Windows.Forms.CheckBox();
            this.medoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Qtemedoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Confiance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Echant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Création du rapport n°";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_numCR
            // 
            this.txb_numCR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_numCR.Location = new System.Drawing.Point(208, 19);
            this.txb_numCR.Name = "txb_numCR";
            this.txb_numCR.ReadOnly = true;
            this.txb_numCR.Size = new System.Drawing.Size(26, 13);
            this.txb_numCR.TabIndex = 1;
            this.txb_numCR.TextChanged += new System.EventHandler(this.txb_numCR_TextChanged);
            // 
            // TB_Confiance
            // 
            this.TB_Confiance.AllowDrop = true;
            this.TB_Confiance.Location = new System.Drawing.Point(392, 172);
            this.TB_Confiance.Name = "TB_Confiance";
            this.TB_Confiance.Size = new System.Drawing.Size(136, 45);
            this.TB_Confiance.TabIndex = 2;
            this.TB_Confiance.Scroll += new System.EventHandler(this.TB_Confiance_Scroll);
            // 
            // cb_praticien
            // 
            this.cb_praticien.FormattingEnabled = true;
            this.cb_praticien.Location = new System.Drawing.Point(20, 69);
            this.cb_praticien.Name = "cb_praticien";
            this.cb_praticien.Size = new System.Drawing.Size(148, 21);
            this.cb_praticien.TabIndex = 6;
            this.cb_praticien.SelectedIndexChanged += new System.EventHandler(this.cb_praticien_SelectedIndexChanged);
            // 
            // cb_Motif
            // 
            this.cb_Motif.FormattingEnabled = true;
            this.cb_Motif.Location = new System.Drawing.Point(20, 173);
            this.cb_Motif.Name = "cb_Motif";
            this.cb_Motif.Size = new System.Drawing.Size(148, 21);
            this.cb_Motif.TabIndex = 7;
            this.cb_Motif.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Praticien rencontré :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif de la visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Coéfficent de confiance";
            // 
            // txb_bilan
            // 
            this.txb_bilan.Location = new System.Drawing.Point(397, 71);
            this.txb_bilan.Multiline = true;
            this.txb_bilan.Name = "txb_bilan";
            this.txb_bilan.Size = new System.Drawing.Size(338, 52);
            this.txb_bilan.TabIndex = 9;
            this.txb_bilan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bilan de la visite";
            // 
            // Valeur_TBConf
            // 
            this.Valeur_TBConf.AutoSize = true;
            this.Valeur_TBConf.Location = new System.Drawing.Point(529, 181);
            this.Valeur_TBConf.Name = "Valeur_TBConf";
            this.Valeur_TBConf.Size = new System.Drawing.Size(42, 13);
            this.Valeur_TBConf.TabIndex = 3;
            this.Valeur_TBConf.Text = "10 / 10";
            // 
            // btn_CreerRapport
            // 
            this.btn_CreerRapport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_CreerRapport.FlatAppearance.BorderSize = 0;
            this.btn_CreerRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreerRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreerRapport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CreerRapport.Location = new System.Drawing.Point(475, 317);
            this.btn_CreerRapport.Name = "btn_CreerRapport";
            this.btn_CreerRapport.Size = new System.Drawing.Size(199, 34);
            this.btn_CreerRapport.TabIndex = 19;
            this.btn_CreerRapport.Text = "Valider";
            this.btn_CreerRapport.UseVisualStyleBackColor = false;
            this.btn_CreerRapport.Click += new System.EventHandler(this.btn_CreerRapport_Click);
            // 
            // btn_verif_Praticien
            // 
            this.btn_verif_Praticien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_verif_Praticien.FlatAppearance.BorderSize = 0;
            this.btn_verif_Praticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verif_Praticien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_verif_Praticien.Location = new System.Drawing.Point(174, 61);
            this.btn_verif_Praticien.Name = "btn_verif_Praticien";
            this.btn_verif_Praticien.Size = new System.Drawing.Size(60, 34);
            this.btn_verif_Praticien.TabIndex = 20;
            this.btn_verif_Praticien.Text = "Vérifier";
            this.btn_verif_Praticien.UseVisualStyleBackColor = false;
            this.btn_verif_Praticien.Click += new System.EventHandler(this.btn_verif_Praticien_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date de la visite";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(397, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CB_echant
            // 
            this.CB_echant.AutoSize = true;
            this.CB_echant.Location = new System.Drawing.Point(20, 239);
            this.CB_echant.Name = "CB_echant";
            this.CB_echant.Size = new System.Drawing.Size(124, 17);
            this.CB_echant.TabIndex = 23;
            this.CB_echant.Text = "Echantillons donnés ";
            this.CB_echant.UseVisualStyleBackColor = true;
            this.CB_echant.CheckedChanged += new System.EventHandler(this.CB_echant_CheckedChanged);
            // 
            // DGV_Echant
            // 
            this.DGV_Echant.AllowDrop = true;
            this.DGV_Echant.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Echant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Echant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medoc,
            this.Qtemedoc});
            this.DGV_Echant.Location = new System.Drawing.Point(20, 262);
            this.DGV_Echant.Name = "DGV_Echant";
            this.DGV_Echant.Size = new System.Drawing.Size(293, 105);
            this.DGV_Echant.TabIndex = 24;
            this.DGV_Echant.Visible = false;
            this.DGV_Echant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Echant_CellContentClick);
            this.DGV_Echant.SelectionChanged += new System.EventHandler(this.CB_echant_CheckedChanged);
            // 
            // ckb_remplacent
            // 
            this.ckb_remplacent.AutoSize = true;
            this.ckb_remplacent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckb_remplacent.Location = new System.Drawing.Point(20, 97);
            this.ckb_remplacent.Name = "ckb_remplacent";
            this.ckb_remplacent.Size = new System.Drawing.Size(133, 17);
            this.ckb_remplacent.TabIndex = 25;
            this.ckb_remplacent.Text = "Est-ce un remplacent ?";
            this.ckb_remplacent.UseVisualStyleBackColor = true;
            this.ckb_remplacent.CheckedChanged += new System.EventHandler(this.ckb_remplacent_CheckedChanged);
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
            // Creer_Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_remplacent);
            this.Controls.Add(this.DGV_Echant);
            this.Controls.Add(this.CB_echant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_verif_Praticien);
            this.Controls.Add(this.btn_CreerRapport);
            this.Controls.Add(this.txb_bilan);
            this.Controls.Add(this.cb_Motif);
            this.Controls.Add(this.cb_praticien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Valeur_TBConf);
            this.Controls.Add(this.TB_Confiance);
            this.Controls.Add(this.txb_numCR);
            this.Controls.Add(this.label1);
            this.Name = "Creer_Rapport";
            this.Size = new System.Drawing.Size(776, 411);
            this.Load += new System.EventHandler(this.Creer_Rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Confiance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Echant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_numCR;
        private System.Windows.Forms.TrackBar TB_Confiance;
        private System.Windows.Forms.ComboBox cb_praticien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_bilan;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Valeur_TBConf;
        private System.Windows.Forms.Button btn_CreerRapport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox CB_echant;
        private System.Windows.Forms.DataGridView DGV_Echant;
        public System.Windows.Forms.Button btn_verif_Praticien;
        private System.Windows.Forms.CheckBox ckb_remplacent;
        public System.Windows.Forms.ComboBox cb_Motif;
        private System.Windows.Forms.DataGridViewComboBoxColumn medoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtemedoc;
    }
}
