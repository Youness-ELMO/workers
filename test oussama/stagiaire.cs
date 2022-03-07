using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oussama
{
    class stagiaire:personne
    {
        int note;

        public stagiaire(string nom, string prenom, int age,int note) : base(nom, prenom, age)
        {
            this.note = note;
        }

        public override string affichage()
        {
            return base.affichage() + "\n -la note est: "+note;
        }
    }
}
