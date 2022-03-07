using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oussama
{
    class prof : personne
    {
        public int salaire;


        public prof(string nom, string prenom, int age, int salaire) : base(nom, prenom, age)
        {
            this.salaire = salaire;
        }

        public override string affichage()
        {
            return base.affichage() + "\n -salaire : " + salaire;
        }
        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }

        }
    }
}