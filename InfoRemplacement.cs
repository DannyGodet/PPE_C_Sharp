using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_GSB_Danny_G
{
    public class InfoRemplacement
    {

        int _idRemplacement;
        int _remplacant;
        int _remplace ;
        DateTime _dateFin;
        DateTime _dateDebut;
        string _info;

        public InfoRemplacement()
        {
            
        }
        public InfoRemplacement(int idRemplacement, int remplacant, int remplacé, DateTime dateFin, DateTime dateDebut, string info)
        {
            _idRemplacement = idRemplacement;
            _remplacant = remplacant;
            _remplace = remplacé;
            _dateFin = dateFin;
            _dateDebut = dateDebut;
            _info = info;
        }

        public int IdRemplacement { get => _idRemplacement; set => _idRemplacement = value; }
        public int Remplacant { get => _remplacant; set => _remplacant = value; }
        public int Remplacé { get => _remplace; set => _remplace = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public string Info { get => _info; set => _info = value; }
    }
}
