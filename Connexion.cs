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
    public partial class Connexion : Form
    {
        
        string chaineConnexion;

        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }


        //public User UtilisateurConnected { get => utilisateurConnected; set => utilisateurConnected = value; }

        public Connexion()
        {
            ChaineConnexion = "server = 127.0.0.1; user id = admin; password='admin'; pooling = false; convert zero datetime=True;  database = gsb";
            InitializeComponent();

            //////////////////////////////////////////
            txb_login.Text = "user";
            txb_mdp.Text = "usermdp";
            
            
        }

        private void btn_Valider_co_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                string Req;
                CURS cs = new CURS(ChaineConnexion);
                 Req = "Select Count(*) FROM useraccount WHERE login = '" + txb_login.Text + "' AND password = '" + txb_mdp.Text + "'";
                if (Convert.ToInt32(cs.compter(Req)) >= 1)
                {
                  
                    cs.fermer();
                    CURS cs2 = new CURS(ChaineConnexion);
                    string Req2 = "Select collaborateur.VIS_MATRICULE,collaborateur.VIS_NOM,collaborateur.Vis_PRENOM,status.libelleStatus,collaborateur.idResponsable FROM useraccount INNER JOIN collaborateur ON collaborateur.VIS_MATRICULE = useraccount.idCollaborateur INNER JOIN status ON collaborateur.idStatus = status.id WHERE useraccount.login = '" + txb_login.Text + "' AND useraccount.password = '" + txb_mdp.Text + "'";

                    cs2.ReqSelect(Req2);
                    
                    GSB g = new GSB();
                    g.ChaineConnexion = this.ChaineConnexion;
                    
                    User u = new User(Convert.ToString(cs2.champ("vis_matricule")), Convert.ToString(cs2.champ("vis_nom")), Convert.ToString(cs2.champ("vis_prenom")), Convert.ToString(cs2.champ("libelleStatus")));
                    GSB.utilisateur = u;
                    g.Show();
                    cs2.fermer();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Identification incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cs.fermer();
                }
            }
            catch
            {
                MessageBox.Show("erreur try");
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
