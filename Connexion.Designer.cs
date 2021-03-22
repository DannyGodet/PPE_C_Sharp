namespace App_GSB_Danny_G
{
    partial class Connexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Valider_co = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_mdp = new System.Windows.Forms.TextBox();
            this.txb_login = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(424, -46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 554);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Login\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "BDD";
            // 
            // btn_Valider_co
            // 
            this.btn_Valider_co.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Valider_co.FlatAppearance.BorderSize = 0;
            this.btn_Valider_co.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valider_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Valider_co.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Valider_co.Location = new System.Drawing.Point(105, 327);
            this.btn_Valider_co.Name = "btn_Valider_co";
            this.btn_Valider_co.Size = new System.Drawing.Size(199, 34);
            this.btn_Valider_co.TabIndex = 0;
            this.btn_Valider_co.Text = "Valider";
            this.btn_Valider_co.UseVisualStyleBackColor = false;
            this.btn_Valider_co.Click += new System.EventHandler(this.btn_Valider_co_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Identifiez vous";
            // 
            // txb_mdp
            // 
            this.txb_mdp.Location = new System.Drawing.Point(126, 264);
            this.txb_mdp.Name = "txb_mdp";
            this.txb_mdp.PasswordChar = '●';
            this.txb_mdp.Size = new System.Drawing.Size(162, 20);
            this.txb_mdp.TabIndex = 17;
            this.txb_mdp.UseWaitCursor = true;
            // 
            // txb_login
            // 
            this.txb_login.Location = new System.Drawing.Point(126, 211);
            this.txb_login.Name = "txb_login";
            this.txb_login.Size = new System.Drawing.Size(162, 20);
            this.txb_login.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MySQL",
            "Oracle",
            "MariaDB"});
            this.comboBox1.Location = new System.Drawing.Point(126, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Valider_co);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_mdp);
            this.Controls.Add(this.txb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Valider_co;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_mdp;
        private System.Windows.Forms.TextBox txb_login;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

