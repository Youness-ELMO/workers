using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oussama
{
    class personne
    {
        public string nom;
        public string prenom;
        public int age;


        public personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public virtual string affichage()
        {
            return " \n -le nom est: " + nom + "\n -le prenom est: " + prenom + "\n -l'age est: " + age;
        }
        public String Nom
        {
            get { return nom; }
            set { nom = value; }

        }
    }
}