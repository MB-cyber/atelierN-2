using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = Console.ReadLine();
            Client c1 = new Client(nom,"Hamza","aadd1");
            MAD solde1 = new MAD(8000);
            MAD val1 = new MAD(2000);
            Compte cpt = new Compte(c1, solde1);
            Compte cpt2 = new Compte(c1, solde1);
            Compte cpt3 = new Compte(c1, solde1);
            c1.affectercompt_client(cpt);
            c1.affectercompt_client(cpt2);
            c1.affectercompt_client(cpt3);
/*
            cpt2.consulter();
            cpt2.afich_op();
            cpt2.crediter(val1);
            cpt2.debiter(val1);
            cpt2.afich_op();
            cpt.crediter(val1);
            cpt.debiter(val1);
            cpt.afich_op();
            cpt.crediter(val1);
            cpt.debiter(val1);
            cpt.afich_op();
            //cpt.consulter();
            //c1.afich_liste();
            // cpt2.consulter();
            //cpt3.consulter();
            /////////// 
            /*CompteCourant cpt4 = new CompteCourant(c1,solde1);
            Console.WriteLine(cpt4.debiter(val1));
            Console.WriteLine(cpt4.debiter(val1));
            Console.WriteLine(cpt4.debiter(val1));
            Console.WriteLine(cpt4.debiter(val1));
            Console.WriteLine(cpt4.debiter(val1));
            Console.WriteLine(cpt4.debiter(val1));



            c1.affectercompt_client(cpt4);

            c1.afich_liste();
            */
            CompteEpergne cptE = new CompteEpergne(c1, new MAD(100), 10);
            //cptE.consulter();
           // cptE.CalcullInteret();
           cptE.consulter();
            CompteCourant CPC = new CompteCourant(c1, solde1);
            CPC.consulter();
            CPC.verser(cptE, new MAD(100));

            Console.WriteLine("CPC=========>cptE");
            cptE.consulter();
            CPC.consulter();




            Console.ReadKey();

          


        }
    }
}
