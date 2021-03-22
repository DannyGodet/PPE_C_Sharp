namespace App_GSB_Danny_G
{
    partial class GSB
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapportDeVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collaborateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCollaborateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnCollaborateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnPraticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnPraticienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLesPraticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatriculeUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportDeVisiteToolStripMenuItem,
            this.fraisToolStripMenuItem,
            this.utilisateurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapportDeVisiteToolStripMenuItem
            // 
            this.rapportDeVisiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rappToolStripMenuItem,
            this.collaborateurToolStripMenuItem,
            this.praticiensToolStripMenuItem,
            this.medocToolStripMenuItem});
            this.rapportDeVisiteToolStripMenuItem.Name = "rapportDeVisiteToolStripMenuItem";
            this.rapportDeVisiteToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.rapportDeVisiteToolStripMenuItem.Text = "Rapport de Visite";
            // 
            // rappToolStripMenuItem
            // 
            this.rappToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnRapportToolStripMenuItem,
            this.modifierUneRapportToolStripMenuItem,
            this.afficherUnRapportToolStripMenuItem,
            this.supprimerUnRapportToolStripMenuItem});
            this.rappToolStripMenuItem.Name = "rappToolStripMenuItem";
            this.rappToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.rappToolStripMenuItem.Text = "Compte-rendu";
            this.rappToolStripMenuItem.Click += new System.EventHandler(this.rappToolStripMenuItem_Click);
            // 
            // créerUnRapportToolStripMenuItem
            // 
            this.créerUnRapportToolStripMenuItem.Name = "créerUnRapportToolStripMenuItem";
            this.créerUnRapportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.créerUnRapportToolStripMenuItem.Text = "Créer un rapport";
            this.créerUnRapportToolStripMenuItem.Click += new System.EventHandler(this.créerUnRapportToolStripMenuItem_Click);
            // 
            // modifierUneRapportToolStripMenuItem
            // 
            this.modifierUneRapportToolStripMenuItem.Name = "modifierUneRapportToolStripMenuItem";
            this.modifierUneRapportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modifierUneRapportToolStripMenuItem.Text = "Modifier un rapport";
            this.modifierUneRapportToolStripMenuItem.Click += new System.EventHandler(this.modifierUneRapportToolStripMenuItem_Click);
            // 
            // afficherUnRapportToolStripMenuItem
            // 
            this.afficherUnRapportToolStripMenuItem.Name = "afficherUnRapportToolStripMenuItem";
            this.afficherUnRapportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.afficherUnRapportToolStripMenuItem.Text = "Afficher les rapports";
            this.afficherUnRapportToolStripMenuItem.Click += new System.EventHandler(this.afficherUnRapportToolStripMenuItem_Click);
            // 
            // supprimerUnRapportToolStripMenuItem
            // 
            this.supprimerUnRapportToolStripMenuItem.Name = "supprimerUnRapportToolStripMenuItem";
            this.supprimerUnRapportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.supprimerUnRapportToolStripMenuItem.Text = "Supprimer un rapport";
            // 
            // collaborateurToolStripMenuItem
            // 
            this.collaborateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnCollaborateurToolStripMenuItem,
            this.modifierUnCollaborateurToolStripMenuItem,
            this.afficherLesCollaborateursToolStripMenuItem,
            this.supprimerUnCollaborateursToolStripMenuItem});
            this.collaborateurToolStripMenuItem.Name = "collaborateurToolStripMenuItem";
            this.collaborateurToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.collaborateurToolStripMenuItem.Text = "Collaborateur";
            // 
            // ajouterUnCollaborateurToolStripMenuItem
            // 
            this.ajouterUnCollaborateurToolStripMenuItem.Name = "ajouterUnCollaborateurToolStripMenuItem";
            this.ajouterUnCollaborateurToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.ajouterUnCollaborateurToolStripMenuItem.Text = "Ajouter un Collaborateur";
            // 
            // modifierUnCollaborateurToolStripMenuItem
            // 
            this.modifierUnCollaborateurToolStripMenuItem.Name = "modifierUnCollaborateurToolStripMenuItem";
            this.modifierUnCollaborateurToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.modifierUnCollaborateurToolStripMenuItem.Text = "Modifier un Collaborateur";
            // 
            // afficherLesCollaborateursToolStripMenuItem
            // 
            this.afficherLesCollaborateursToolStripMenuItem.Name = "afficherLesCollaborateursToolStripMenuItem";
            this.afficherLesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.afficherLesCollaborateursToolStripMenuItem.Text = "Afficher les Collaborateurs";
            // 
            // supprimerUnCollaborateursToolStripMenuItem
            // 
            this.supprimerUnCollaborateursToolStripMenuItem.Name = "supprimerUnCollaborateursToolStripMenuItem";
            this.supprimerUnCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.supprimerUnCollaborateursToolStripMenuItem.Text = "Supprimer un Collaborateurs";
            // 
            // praticiensToolStripMenuItem
            // 
            this.praticiensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnPraticienToolStripMenuItem,
            this.modifierUnPraticienToolStripMenuItem,
            this.afficherLesPraticiensToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.praticiensToolStripMenuItem.Name = "praticiensToolStripMenuItem";
            this.praticiensToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.praticiensToolStripMenuItem.Text = "Praticiens";
            this.praticiensToolStripMenuItem.Click += new System.EventHandler(this.praticiensToolStripMenuItem_Click);
            // 
            // ajouterUnPraticienToolStripMenuItem
            // 
            this.ajouterUnPraticienToolStripMenuItem.Name = "ajouterUnPraticienToolStripMenuItem";
            this.ajouterUnPraticienToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajouterUnPraticienToolStripMenuItem.Text = "Ajouter un Praticien";
            // 
            // modifierUnPraticienToolStripMenuItem
            // 
            this.modifierUnPraticienToolStripMenuItem.Name = "modifierUnPraticienToolStripMenuItem";
            this.modifierUnPraticienToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.modifierUnPraticienToolStripMenuItem.Text = "Modifier un Praticien ";
            this.modifierUnPraticienToolStripMenuItem.Click += new System.EventHandler(this.modifierUnPraticienToolStripMenuItem_Click);
            // 
            // afficherLesPraticiensToolStripMenuItem
            // 
            this.afficherLesPraticiensToolStripMenuItem.Name = "afficherLesPraticiensToolStripMenuItem";
            this.afficherLesPraticiensToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.afficherLesPraticiensToolStripMenuItem.Text = "Afficher les Praticiens";
            this.afficherLesPraticiensToolStripMenuItem.Click += new System.EventHandler(this.afficherLesPraticiensToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer un Praticien";
            // 
            // medocToolStripMenuItem
            // 
            this.medocToolStripMenuItem.Name = "medocToolStripMenuItem";
            this.medocToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.medocToolStripMenuItem.Text = "Medicaments";
            // 
            // fraisToolStripMenuItem
            // 
            this.fraisToolStripMenuItem.Name = "fraisToolStripMenuItem";
            this.fraisToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fraisToolStripMenuItem.Text = "Frais";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // MatriculeUser
            // 
            this.MatriculeUser.AutoSize = true;
            this.MatriculeUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MatriculeUser.Location = new System.Drawing.Point(618, 9);
            this.MatriculeUser.Name = "MatriculeUser";
            this.MatriculeUser.Size = new System.Drawing.Size(35, 13);
            this.MatriculeUser.TabIndex = 3;
            this.MatriculeUser.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 411);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(693, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statut :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(550, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = " Utilisateur :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Status.Location = new System.Drawing.Point(742, 9);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(35, 13);
            this.lb_Status.TabIndex = 3;
            this.lb_Status.Text = "label1";
            // 
            // GSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.MatriculeUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GSB_FormClosing);
            this.Load += new System.EventHandler(this.GSB_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rapportDeVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collaborateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCollaborateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnCollaborateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesCollaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnCollaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnPraticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnPraticienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherLesPraticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.Label MatriculeUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Status;
    }
}