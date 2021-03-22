using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GSB_Danny_G
{
    public class User
    {
         

        string _matricule;
        string _nomUser;
        string _prenomUser;
        string _statusUser;
       

        // internal static User _userConnected;
        public User()
        {

        }
        public User(string matricule, string nom, string prenom, string status)
        {
            _matricule = matricule;
            _nomUser = nom;
            _prenomUser = prenom;
            _statusUser = status;
            

        }
      
        public string Matricule { get => _matricule; set => _matricule = value; }
        public string NomUser { get => _nomUser; set => _nomUser = value; }
        public string PrenomUser { get => _prenomUser; set => _prenomUser = value; }
        public string StatusUser { get => _statusUser; set => _statusUser = value; }
        //internal User UserConnected { get => _userConnected; set => _userConnected = value; }

    }
}
