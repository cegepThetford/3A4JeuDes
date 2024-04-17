using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDes_Affaires
{
    public class De
    {
        private int _valeur, _nbFaces;
        private bool _etatFige;
        private static Random _aleatoire = new Random();

        #region Proprietes
        public int Valeur { get { return _valeur; } set { _valeur = value; } }
        public int NbFaces { get { return _nbFaces; } }
        // Note: methodes booleennes au lieu d'une propriete sur _etatFige
        #endregion

        public De() : this(6) { }
        public De(int nbFaces)
        {
            _nbFaces = nbFaces;
            _valeur = _nbFaces;
            _etatFige = false;
        }
        public void figer() { _etatFige = true; }
        public void liberer() { _etatFige = false; }


        public void lancer()
        {
            if (!_etatFige)
                _valeur = _aleatoire.Next(1, _nbFaces+1);
        }
        public bool estFige() { return _etatFige; }
        public bool estLibre() { return !_etatFige; }
    }
}
