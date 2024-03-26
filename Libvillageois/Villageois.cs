using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Libvillageois
{
    public class Villageois
    {

        private string _nom;
        private int _poids;
        private bool _malade;

        public Villageois(string nom)
        {
            _nom = nom;
            this._malade = false;
        }

        public Villageois(string nom, int poids, bool malade)
        {

            this._nom = nom;
            this._poids = poids;
            this._malade = malade;

        }

        public string get_nom()
        {
            return this._nom;
        }
        public int get_poids()
        {
            return this._poids;
        }

        public bool get_malade()
        {
            return this._malade;
        }

        public void set_poids(int poids)
        {
            this._poids=poids;
        }

        public int poidsSouleve ()
        {
           int poidsSouleve = _poids / 5;
            return poidsSouleve;
        }

        public override string ToString()
        {
            string mal = "malade";
            if (this._malade = false) mal = "pas malade";

            return $"Le villageois se nomme {_nom} peut soulever {_poids} kg et est {mal}.";
        }
    }
}

