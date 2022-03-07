using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oussama
{
    class employer
    {
        string nom;
        string prenom;
        int salaire;


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public employer(String nom, String prenom, int salaire)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
        }

        public string affichage1()
        {
            return"\n -Le nom est: "+nom+ "\n -le prenom est: "+prenom+ "\n -sont salaire est: "+salaire;
        }
    }
}
