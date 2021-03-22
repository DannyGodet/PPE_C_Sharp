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
    public partial class AfficherPraticien : UserControl
    {

        int _idPraticienSelected = -1;
       
        string chaineConnexion;

        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public AfficherPraticien()
        {
            InitializeComponent();
        }

        private void AfficherPraticien_Load(object sender, EventArgs e)
        {
            dg_Praticien.Rows.Clear();
            CURS cs = new CURS(ChaineConnexion);
            string requete = "select * from praticien;";
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                dg_Praticien.Rows.Add(cs.champ("PRA_NUM"), cs.champ("PRA_NOM"), cs.champ("PRA_PRENOM"), cs.champ("PRA_ADRESSE"), cs.champ("PRA_CP"), cs.champ("PRA_VILLE"), cs.champ("PRA_COEFNOTORIETE"), cs.champ("TYP_CODE"));
                cs.suivant();
            }

            cs.fermer();
            dg_Praticien.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void btn_verif_Praticien_Click(object sender, EventArgs e)
        {
            if (_idPraticienSelected > -1)
            {
                 DetailPraticien detailPraticien = new DetailPraticien(_idPraticienSelected);
                detailPraticien.ChaineConnexion = this.ChaineConnexion;
                detailPraticien.Show();
            }
            else
            {
                MessageBox.Show("Selectionnez un Praticien ");
            }

        }

        private void dg_Praticien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = e.RowIndex;
            _idPraticienSelected = Convert.ToInt32(dg_Praticien.Rows[id].Cells[0].Value.ToString());
            //MessageBox.Show(Convert.ToString(_idPraticienSelected),Convert.ToString(id));
        }
        private void dg_Praticien_RowHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id;
            id = e.RowIndex;
            _idPraticienSelected = Convert.ToInt32(dg_Praticien.Rows[id].Cells[0].Value.ToString());
            //MessageBox.Show(Convert.ToString(_idPraticienSelected),Convert.ToString(id));
        }
        private void dg_Praticien_RowContentClick(object sender, DataGridViewRowHeaderCell e)
        {
            int id;
            id = e.RowIndex;
            _idPraticienSelected = Convert.ToInt32(dg_Praticien.Rows[id].Cells[0].Value.ToString());
            //MessageBox.Show(Convert.ToString(_idPraticienSelected),Convert.ToString(id));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
    
}
