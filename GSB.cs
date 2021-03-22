using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GSB_Danny_G
{

    public partial class GSB : Form
    {// faire un setteur de l'user connecté
        string chaineConnexion;
       
        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
      
        public static User utilisateur = new User();
        
        //public  User UtilisateurConnected { get => utilisateurConnected; set => utilisateurConnected = value; }

        public GSB()
        {
           
            InitializeComponent();

        }

        private void rappToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GSB_Load(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            panel1.Controls.Add(accueil);
            accueil.BringToFront();          
            MatriculeUser.Text = utilisateur.Matricule;
            lb_Status.Text = utilisateur.StatusUser;
        }

        private void créerUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Creer_Rapport creer_Rapports = new Creer_Rapport();
            creer_Rapports.ChaineConnexion = this.ChaineConnexion;
            panel1.Controls.Add(creer_Rapports);
            creer_Rapports.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void praticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afficherLesPraticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherPraticien afficherPraticien = new AfficherPraticien();
            afficherPraticien.ChaineConnexion = this.ChaineConnexion;
            panel1.Controls.Add(afficherPraticien);
            afficherPraticien.BringToFront();
        }

        private void afficherUnRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherRapport afficherRapport = new AfficherRapport();
            afficherRapport.ChaineConnexion = this.ChaineConnexion;
            panel1.Controls.Add(afficherRapport);
            afficherRapport.BringToFront();
        }
        private void GSB_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void modifierUnPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierUneRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierRapport modifierRapport = new modifierRapport();
            modifierRapport.ChaineConnexion = this.ChaineConnexion;
            panel1.Controls.Add(modifierRapport);
            modifierRapport.BringToFront();
        }
    }
}
