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
    public partial class modifierRapport : UserControl
    {
        string chaineConnexion;
        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }

        public modifierRapport()
        {
            InitializeComponent();
        }

        private void modifierRapport_Load(object sender, EventArgs e)
        {


            pl_coll.Visible = false;

            if (GSB.utilisateur.StatusUser == "admin") //si l'utilisateur est un admin 
            {
                pl_coll.Visible = true;

                CURS cm = new CURS(ChaineConnexion);

                string rqt = "SELECT * FROM Collaborateur ";
                cm.ReqSelect(rqt);
                try
                {
                    while (!cm.Fin())
                    {
                        string col = "" + cm.champ("vis_matricule") + " " + cm.champ("vis_nom") + " " + cm.champ("vis_prenom");

                        cb_Collaborateur.Items.Add(col);
                        cm.suivant();

                    }

                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de execution reader");
                }
                cm.fermer();

            }
            else// si c'est un user
            {
                CURS cm3 = new CURS(ChaineConnexion);

                string rqt3 = "SELECT rap_num FROM rapport_visite WHERE vis_matricule = '"+GSB.utilisateur.Matricule+"'";
                cm3.ReqSelect(rqt3);
                try
                {
                    while (!cm3.Fin())
                    {

                        cb_rap.Items.Add(cm3.champ("rap_num"));
                        cm3.suivant();

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur de execution reader");
                }
                cm3.fermer();


            }

        }

        private void cb_Collaborateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_rap.Items.Clear();
            CURS cm2 = new CURS(ChaineConnexion);

            string col_Select = cb_Collaborateur.SelectedItem.ToString();

            string[] mots = col_Select.Split(' ');

            col_Select = mots[0];

            string rqt2 = "SELECT rap_num FROM rapport_visite Where vis_matricule ='"+ col_Select + "'";
            cm2.ReqSelect(rqt2);
            try
            {
                while (!cm2.Fin())
                {

                    cb_rap.Items.Add(cm2.champ("rap_num"));
                    cm2.suivant();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de execution reader");
            }
            cm2.fermer();
        }

        private void cb_rap_SelectedIndexChanged(object sender, EventArgs e)
        {
            CURS cm2 = new CURS(ChaineConnexion);

            string rap_Select = cb_rap.SelectedItem.ToString();

            if (GSB.utilisateur.StatusUser == "admin") //si l'utilisateur est un admin 
            {

                string col_Select = cb_Collaborateur.SelectedItem.ToString();

                string[] mots = col_Select.Split(' ');

                col_Select = mots[0];

                string rqt2 = "SELECT * FROM rapport_visite Where vis_matricule ='" + col_Select + "' AND vis_rap = "+ rap_Select+"";
                cm2.ReqSelect(rqt2);
              
               
            }
            else
            {
                string rqt2 = "SELECT * FROM rapport_visite Where vis_rap = " + rap_Select + "";
                cm2.ReqSelect(rqt2);
            }

            while (!cm2.Fin())
            {

                cb_rap.Items.Add(cm2.champ("rap_num"));
                cm2.suivant();

            }
            cm2.fermer();
        }
    }
}
