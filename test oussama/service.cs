using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oussama
{
    class service
    {
        string nom_service;
        employer chef;
        public service(string nom_service)
        {
            this.nom_service = nom_service;
            
        }
        static ArrayList l = new ArrayList();
        public static void ajouter(employer E)
        {
            l.Add(E);
        }

        public void info()
        {
            Console.WriteLine(" -Sous le nom est: " + nom_service+ chef );
        }

    }
}
