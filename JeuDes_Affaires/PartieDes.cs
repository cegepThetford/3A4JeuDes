using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDes_Affaires
{
    public class PartieDes
    {
        private int _meilleurScore;
        private int _noTourJoue;
        private int _nbToursPartie;
        private bool _partieTerminee;

        #region Proprietes
        public int MeilleurScore { get { return _meilleurScore; } set { _meilleurScore = value; } }
        public int NoTourJoue { get { return _noTourJoue; } set { _noTourJoue = value; } }
        public int NbToursPartie { get { return _nbToursPartie; } set { _nbToursPartie = value; } }
        // Pas de propriete pour _partieTerminee
        #endregion

        public PartieDes(int nombreTours)
        {
            _meilleurScore = 0;
            _noTourJoue = 0;
            _nbToursPartie = nombreTours;
            _partieTerminee = false;
        }
        public void inscrireScoreCourant(int score)
        {
            if (_meilleurScore < score)
                _meilleurScore = score;
        }
        public bool estTerminee()
        {
            return _partieTerminee;
        }
        public void demarrerNouvellePartie()
        {
            _noTourJoue = 0;
            _partieTerminee = false;
        }

        public void incrementerTourJoue()
        {
            _noTourJoue++;
            if (_noTourJoue == _nbToursPartie)
                _partieTerminee = true;
        }
    }
}
