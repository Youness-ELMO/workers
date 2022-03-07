using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oussama
{
    class entreprise
    {
        string nom;
        service ser;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public entreprise(String nom)
        {
            this.nom = nom;
        }

        public void affichage()
        {
            Console.Write(": " + nom+ser);
        } 

            static ArrayList l = new ArrayList();
        //public static void ajouter(service s)
        //{
        //    l.Add(s);
        //}



    }
}
