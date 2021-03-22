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
    public partial class Remplacement : Form
    {
        int _idRemplacement;
        int _remplacant; 
        int _remplacé = -1;
        DateTime _dateFin;
        DateTime _dateDebut;
        string _info;

        string chaineConnexion;
        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public Remplacement(int praticienRemplacent)
        {
            _remplacant = praticienRemplacent;
            InitializeComponent();
        }

        private void Remplacement_Load(object sender, EventArgs e)
        {
            CURS co1 = new CURS(ChaineConnexion);
            String rqt1 = "Select MAX(idRemplacement) as nbrRemplacement FROM remplacement ";
            co1.ReqSelect(rqt1);
            _idRemplacement = Convert.ToInt32(co1.champ("nbrRemplacement")) + 1;
            co1.fermer();


            CURS co7 = new CURS(ChaineConnexion);
            string rqtPraticien = "SELECT pra_num , pra_nom,pra_prenom  FROM praticien";
            co7.ReqSelect(rqtPraticien);

            try
            {
                while (!co7.Fin())
                {
                    string praticien = "" + co7.champ("pra_num") + " " + co7.champ("pra_nom") + " " + co7.champ("pra_prenom");
                    if (_remplacant == Convert.ToInt32(co7.champ("pra_num")))
                    {
                        co7.suivant();
                    }
                    else
                    {
                        cb_Rempla.Items.Add(praticien);
                        co7.suivant();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur d'execution reader");
            }
            co7.fermer(); 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _dateDebut = dateTimePicker1.Value.Date;
            _dateFin = dateTimePicker2.Value.Date;
        }

        private void cb_Rempla_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = -1;

            i = cb_Rempla.SelectedIndex;
            string praticienSelect = cb_Rempla.SelectedItem.ToString();

            string[] mots = praticienSelect.Split(' ');

            _remplacé = Convert.ToInt32(mots[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_remplacé == -1)
            {
                MessageBox.Show("Veuillez Selectionner un Praticien");
            }
            else
            {
                DetailPraticien detailPraticien = new DetailPraticien(_remplacé);
                detailPraticien.ChaineConnexion = this.ChaineConnexion;
                detailPraticien.Show();
            }
        }

        private void txb_descrMotif_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_CreerMotif_Click(object sender, EventArgs e)
        {
            _info = txb_InfoRempl.Text;

            Creer_Rapport._remplacement.IdRemplacement = _idRemplacement;
            Creer_Rapport._remplacement.Remplacant = _remplacant;
            Creer_Rapport._remplacement.Remplacé = _remplacé;
            Creer_Rapport._remplacement.Info = _info;
            Creer_Rapport._remplacement.DateDebut = _dateDebut;
            Creer_Rapport._remplacement.DateFin = _dateFin;
            this.Close();
           


        }
    }
}
