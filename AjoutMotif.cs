using Org.BouncyCastle.Crypto.Engines;
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
    public partial class AjoutMotif : Form
    {
       
        int _idMotif;
        string _matriculeCol = GSB.utilisateur.Matricule;
        string _libelleMotif;
        string _descriptionMotif;



        string chaineConnexion;
        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public AjoutMotif()
        {
            InitializeComponent();

        }

        private void AjoutMotif_Load(object sender, EventArgs e)
        {

        }

        private void btn_CreerMotif_Click(object sender, EventArgs e)
        {
            CURS connect = new CURS(ChaineConnexion);

            _libelleMotif = txb_nomMotif.Text;
            _descriptionMotif = txb_descrMotif.Text;
           // idMotif = ;
           //je recupère le num du motif
            string rqt = "SELECT MAX(id) as maxid FROM motif WHERE idCollaborateur ='"+ _matriculeCol + "' OR idCollaborateur = '-1' ";
            connect.ReqSelect(rqt);
            _idMotif = Convert.ToInt32(connect.champ("maxid")) + 1 ;
            connect.fermer();
            

            // j'ajoute le nouveau
            CURS connect2 = new CURS(ChaineConnexion);
            string rqt2 = "INSERT INTO motif VALUES ("+ _idMotif +",'" + _libelleMotif + "','" + _descriptionMotif + "','" + _matriculeCol + "')";
            connect2.ReqAdmin(rqt2);
            connect2.fermer();
      
          
            this.Close();
        }
    }
}
