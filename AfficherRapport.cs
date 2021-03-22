using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GSB_Danny_G
{
    public partial class AfficherRapport : UserControl
    {
        string chaineConnexion;

        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }

        public AfficherRapport()
        {
            InitializeComponent();
        }

        private void AfficherRapport_Load(object sender, EventArgs e)
        {
            CURS cs = new CURS(ChaineConnexion);

            if (GSB.utilisateur.StatusUser == "admin") //si l'utilisateur est un admin 
            {
                dg_Rapport.Rows.Clear();
               
                string requete = "select * from rapport_visite;";
                cs.ReqSelect(requete);
                while (!cs.Fin())
                {
                    dg_Rapport.Rows.Add(cs.champ("VIS_MATRICULE"), cs.champ("RAP_NUM"), cs.champ("PRA_NUM"), cs.champ("RAP_DATE"), cs.champ("RAP_BILAN"), cs.champ("rap_dateSaisie"), cs.champ("rap_coefConf"), cs.champ("idMotif"));
                    cs.suivant();
                }
            }
            else
            {
                dg_Rapport.Rows.Clear();

                string requete = "select * from rapport_visite WHERE vis_matricule= '"+ GSB.utilisateur.Matricule +"';";
                cs.ReqSelect(requete);
                while (!cs.Fin())
                {
                    dg_Rapport.Rows.Add(cs.champ("VIS_MATRICULE"), cs.champ("RAP_NUM"), cs.champ("PRA_NUM"), cs.champ("RAP_DATE"), cs.champ("RAP_BILAN"), cs.champ("rap_dateSaisie"), cs.champ("rap_coefConf"), cs.champ("idMotif"));
                    cs.suivant();
                }
            }
            cs.fermer();
            dg_Rapport.Show();
        }
    }
}
