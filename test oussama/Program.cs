using System;

namespace test_oussama
{
    class Program
    {
        static void Main(string[] args)
        {
            entreprise E = new entreprise("M. Youness");
            service s1 = new service(" GREEN ");
            service s2 = new service(" RED ");
            service s3 = new service(" BLACK ");
            service s4 = new service(" BLUE ");
            employer a = new employer(" Youness ", " EL MODAHHAB ", 1200);
            prof p = new prof("Youness", "EL MODAHHAB", 20, 6200);
            stagiaire ss = new stagiaire("Youness", "EL MODAHHAB", 20, 18);
            //entreprise.ajouter(s1);

            Console.Write("L’entreprise de  ");
            E.affichage();
            service.ajouter(a);
            Console.WriteLine("\ncontient les services suivants: ");
            s1.info();
            s2.info();
            s3.info();
            s4.info();
            Console.Write("\nl'employeur est: ");
           Console.WriteLine( a.affichage1());

            Console.Write("\nDu professeur suivant:  ");
            Console.WriteLine(p.affichage());

            Console.Write("\nle premier stagiaire est:  ");
            Console.WriteLine(ss.affichage());

            Console.ReadKey();
        }
    }
}
