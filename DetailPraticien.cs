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
    public partial class DetailPraticien : Form
    {

        string chaineConnexion;
        int _numPraticien;
        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public int NumPraticien { get => _numPraticien; set => _numPraticien = value; }

        public DetailPraticien(int NumPraticien)
        {

            _numPraticien = NumPraticien;
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
      
        private void DetailPraticien_Load(object sender, EventArgs e)
        {


            CURS cs = new CURS(ChaineConnexion);
            string requete = "select PRA_NUM,PRA_NOM,PRA_PRENOM,PRA_ADRESSE,PRA_VILLE,PRA_CP,PRA_COEFNOTORIETE,TYP_LIBELLE from praticien INNER JOIN type_praticien ON type_praticien.TYP_CODE = praticien.TYP_CODE WHERE PRA_NUM = " + _numPraticien + " ";
            cs.ReqSelect(requete);
            tb_nom.Text = Convert.ToString(cs.champ("PRA_NOM"));
            tb_prenom.Text = Convert.ToString(cs.champ("PRA_PRENOM"));
            tb_adr.Text = Convert.ToString(cs.champ("PRA_ADRESSE"));
            tb_ville.Text = Convert.ToString(cs.champ("PRA_VILLE"));
            tb_cp.Text = Convert.ToString(cs.champ("PRA_CP"));
            tb_typePra.Text = Convert.ToString(cs.champ("TYP_LIBELLE"));
            tb_notoriete.Text = Convert.ToString(cs.champ("PRA_COEFNOTORIETE"));
            tb_id.Text = Convert.ToString(cs.champ("PRA_NUM"));
            cs.fermer();



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
