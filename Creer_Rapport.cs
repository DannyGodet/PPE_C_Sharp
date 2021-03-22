using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Ocsp;
using System.Threading;
using MySqlX.XDevAPI.Relational;

namespace App_GSB_Danny_G
{

    public partial class Creer_Rapport : UserControl
    {
        string _matricule = GSB.utilisateur.Matricule;//
        int _rap_num;//
        int _pra_num = -1;//
        DateTime _date_visite;//
        string _bilan;//
        DateTime _date_rapport;//
        int _coef_conf;//
        int _idMotif = -1; //

        public static InfoRemplacement _remplacement = new InfoRemplacement();



        string chaineConnexion;
        public string ChaineConnexion { get => chaineConnexion; set => chaineConnexion = value; }
        public Creer_Rapport()
        {
            InitializeComponent();
        }

        public void remplirCBMotif()
        {

            /*////////////////////////////////////////////////////// On va chercher la liste des motifs de rdv */
            cb_Motif.Items.Clear();

            CURS co3 = new CURS(ChaineConnexion);

            string rqtmotif = "SELECT motif_libelle FROM motif WHERE idCollaborateur = '" + GSB.utilisateur.Matricule + "' OR idCollaborateur = '-1' ";
            co3.ReqSelect(rqtmotif);

            try
            {
                while (!co3.Fin())
                {
                    cb_Motif.Items.Add(co3.champ("motif_libelle"));
                    co3.suivant();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur d'execution reader");
            }
            co3.fermer();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            CURS co5 = new CURS(ChaineConnexion);
          
            int i = -1;
            i = cb_Motif.SelectedIndex;
            string motifSelect = cb_Motif.SelectedItem.ToString();
            if (i >= 0)
            {
                if (motifSelect == "Autres")
                {
                    AjoutMotif creerMotif = new AjoutMotif();
                    creerMotif.ChaineConnexion = this.ChaineConnexion;

                    //On lance une boite de dialogue pour mettre en "Pause" le formulaire principale et donc réinitialiser la combobox une fois l'ajout du motif effectué
                    System.Windows.Forms.DialogResult result = creerMotif.ShowDialog();
                    this.remplirCBMotif();


                }
                string ReqIdmotif = "SELECT id FROM motif WHERE motif_libelle = '"+motifSelect +"'";
                co5.ReqSelect(ReqIdmotif);

                
            }

            _idMotif = Convert.ToInt32(co5.champ("id"));
            co5.fermer();
        }

        public void ajouterMotif( string newMotif)
        {
           this.cb_Motif.Items.Add(newMotif);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Creer_Rapport_Load(object sender, EventArgs e)
        {
            /*////////////////////////////////////////////////////// On va chercher le nouveau num_Rapport */
            CURS co = new CURS(ChaineConnexion);

            string rqtNumRap = "SELECT MAX(rap_num) as maxRap_num  FROM rapport_visite WHERE vis_matricule='"+ GSB.utilisateur.Matricule + "' ORDER BY rap_num ASC";
            co.ReqSelect(rqtNumRap);

            try
            {
               
                    int num_Rap;
                    if (co.champ("maxRap_num") == null)
                    {
                        num_Rap = 1;
                        _rap_num = num_Rap;
                    }
                    _rap_num = Convert.ToInt32(co.champ("maxRap_num")) + 1;
                    txb_numCR.Text = Convert.ToString(_rap_num);
                
            }      
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur d'execution reader ");
            }
            co.fermer();
            /*////////////////////////////////////////////////////// On va chercher la liste des praticiens */
            CURS co2 = new CURS(ChaineConnexion);
            
            string rqtPraticien = "SELECT pra_num , pra_nom,pra_prenom  FROM praticien";
            co2.ReqSelect(rqtPraticien);

            try
            {
                while (!co2.Fin())
                {
                    string praticien = "" + co2.champ("pra_num") + " " + co2.champ("pra_nom") + " " + co2.champ("pra_prenom");
                    cb_praticien.Items.Add(praticien);
                    
                    co2.suivant();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur d'execution reader");
            }
            co2.fermer();

            this.remplirCBMotif();
            

        }

        private void txb_numCR_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Confiance_Scroll(object sender, EventArgs e)
        {
            Valeur_TBConf.Text =" "+ TB_Confiance.Value+" / 10";
        }

        private void CB_echant_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_echant.Checked is true)
            {
                DGV_Echant.Visible = true;
                /*////////////////////////////////////////////////////// remplir la comboBox de la DataGridView */
                try
                {
                 
                    CURS co4 = new CURS(ChaineConnexion);

                    string rqtMedicDGV = "SELECT med_depotlegal FROM medicament";
                    co4.ReqSelect(rqtMedicDGV);

                    while (!co4.Fin())
                    {
                        medoc.Items.Add(co4.champ("med_depotlegal"));
                        co4.suivant();
                    }
                    co4.fermer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur d'execution reader");
                }

            }
            else
            {
                if(CB_echant.Checked is false)
                {
                    DGV_Echant.Visible = false;
                }
            }
        }

        private void DGV_Echant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void cb_praticien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = -1;
         
            i = cb_praticien.SelectedIndex;
            string praticienSelect = cb_praticien.SelectedItem.ToString();

            string[] mots = praticienSelect.Split(' ');

            _pra_num = Convert.ToInt32(mots[0]);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _date_visite = dateTimePicker1.Value.Date;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutMotif ajoutMotif = new AjoutMotif();
            ajoutMotif.ChaineConnexion = this.ChaineConnexion;
            ajoutMotif.Show();

        }

        private void btn_verif_Praticien_Click(object sender, EventArgs e)
        {
            if(_pra_num == -1)
            {
                MessageBox.Show( "Veuillez Selectionner un Praticien");
            }
            else
            {
                DetailPraticien detailPraticien = new DetailPraticien(_pra_num);
                detailPraticien.ChaineConnexion = this.ChaineConnexion;
                detailPraticien.Show();
            }
            

        }

        private void ckb_remplacent_CheckedChanged(object sender, EventArgs e)
        {
            if(_pra_num != -1)
            {
                if (ckb_remplacent.Checked is true)
                {
                    Remplacement r = new Remplacement(_pra_num);
                    r.ChaineConnexion = this.ChaineConnexion;
                    r.Show();




                    /* pl_remplacent.Visible = true;

                     CURS co7 = new CURS(ChaineConnexion);
                     string rqtPraticien = "SELECT pra_num , pra_nom,pra_prenom  FROM praticien";
                     co7.ReqSelect(rqtPraticien);

                     try
                     {
                         while (!co7.Fin())
                         {
                             string praticien = "" + co7.champ("pra_num") + " " + co7.champ("pra_nom") + " " + co7.champ("pra_prenom");
                             if (_pra_num == Convert.ToInt32(co7.champ("pra_num")))
                             {
                                 co7.suivant();
                             }
                             else {
                                 cb_Rempla.Items.Add(praticien);
                                 co7.suivant();
                             }


                         }


                     }
                      catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message, "Erreur d'execution reader");
                     }
                     co7.fermer();*/
                }

            }
            else
            {
                MessageBox.Show("veuillez selectionner un praticien", "Erreur");
            }
          

        }


        private void cb_Rempla_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int i = -1;

            i = cb_Rempla.SelectedIndex;
            string praticienSelect = cb_Rempla.SelectedItem.ToString();

            string[] mots = praticienSelect.Split(' ');

            _rempl_num = Convert.ToInt32(mots[0]); */
        }

        private void btn_CreerRapport_Click(object sender, EventArgs e)
        {
            _date_rapport = DateTime.Now;
            _bilan = txb_bilan.Text;
            _coef_conf = TB_Confiance.Value;

            if (_pra_num != -1)
            {
                if (_bilan != null)
                {
                    if (_idMotif != -1)
                    {
                        if (CB_echant.Checked == true)
                        {
                            string medic;
                            int qteMedic;
                            foreach (DataGridViewRow r in DGV_Echant.Rows)
                            {
                                if ((r.Cells[0].Value != null) || (r.Cells[1].Value != null))
                                {
                                    try
                                    {
                                        medic = r.Cells[0].Value.ToString();
                                        qteMedic = Convert.ToInt32(r.Cells[1].Value.ToString());
                                        CURS co = new CURS(ChaineConnexion);
                                        string Req = "INSERT INTO offrir Values ('" + _matricule + "'," + _rap_num + ",'" + medic + "'," + qteMedic + ")";
                                        co.ReqAdmin(Req);
                                        co.fermer();


                                    }
                                    catch
                                    {
                                        MessageBox.Show("La table des échantillons ne sont pas correctement remplies");
                                    }

                                }


                            }
                        }
                        if (ckb_remplacent.Checked == true)
                        {
                          

                            CURS co2 = new CURS(ChaineConnexion);
                            String rqt2 = "Insert INTO remplacement Values("+ _remplacement.IdRemplacement+","+ _remplacement.Remplacant+ ",'" + _remplacement.DateDebut.Year + "-" + _remplacement.DateDebut.Month + "-" + _remplacement.DateDebut.Day + " " + _remplacement.DateDebut.Hour + ":" + _remplacement.DateDebut.Minute + ":" + _remplacement.DateDebut.Second + "','" + _remplacement.DateFin.Year + "-" + _remplacement.DateFin.Month + "-" + _remplacement.DateFin.Day + " " + _remplacement.DateFin.Hour + ":" + _remplacement.DateFin.Minute + ":" + _remplacement.DateFin.Second +"','"+ _remplacement.Info+"',"+ _remplacement.Remplacé+")";
                            co2.ReqAdmin(rqt2);
                            co2.fermer();
                        }

                        CURS newRapport = new CURS(ChaineConnexion);
                        string requete = "INSERT INTO rapport_visite Values ('" + _matricule + "'," + _rap_num + "," + _pra_num + ",'"+ _date_rapport.Year+"-"+ _date_rapport.Month+"-"+ _date_rapport.Day+" "+_date_rapport.Hour+":"+_date_rapport.Minute + ":" + _date_rapport.Second+ "','"+_bilan+"','" + _date_visite.Year + "-" + _date_visite.Month + "-" + _date_visite.Day + " " + _date_visite.Hour + ":" + _date_visite.Minute + ":" + _date_visite.Second + "','" + _coef_conf + "'," + _idMotif + ")";
                        newRapport.ReqAdmin(requete);
                        newRapport.fermer();
                        MessageBox.Show("Rapport rendu");
                        this.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Selectionnez un motif");
                    }
                    
                    
                }
                else
                    {
                        MessageBox.Show("Remplissez le bilan");
                    }
               


            } 
            else
                {
                    MessageBox.Show("Entrez le numéro du praticien");
                }

        }
    }
}
