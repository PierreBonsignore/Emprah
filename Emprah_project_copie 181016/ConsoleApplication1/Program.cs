using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            string NomDuHeros;

            NomDuHeros = Saisie("Donnez un nom à votre héros:");

            Console.WriteLine("Votre héros se nomme " + NomDuHeros);

            int valeur = LancerLesDés(3, 100);

            Console.WriteLine(valeur);
            
            //test week end
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday && DateTime.Now.Hour < 18 ||
                DateTime.Now.DayOfWeek == DayOfWeek.Sunday && DateTime.Now.Hour < 18 ||
                DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9)
            {
                WeekEnd();
            }

            //test soir
            else if (DateTime.Now.Hour > 18)
            {
                Bonsoir();
            }

            //test jour
            else
            {
                Bonjour();
            }
            Console.WriteLine("Il est " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);            
            
        }
        static void WeekEnd()
        {
            Console.WriteLine("Bon week-end " + Environment.UserName + "!");
        }

        static void Bonjour()
        {
            Console.WriteLine("Bonjour " + Environment.UserName + "!");           
        }

        static void Bonsoir()
        {
            Console.WriteLine("Bonsoir " + Environment.UserName + "!");
        }

        static string Saisie(string texte)
        {
            string saisie;
            Console.WriteLine(texte);           
            saisie = Console.ReadLine();         
            return saisie;          
        }

        static int LancerLesDés(int nbrDés, int valeurDé)
        {
            int[] resultDés = new int[nbrDés];
            int totalDés = 0;

            for (int d = 0; d < nbrDés; d++)
            {
                Random rand = new Random();
                resultDés[d] = rand.Next(1, valeurDé);
                Console.WriteLine("Le résultat du dé " + (d + 1) + " est " + resultDés[d]);
                totalDés = totalDés + resultDés[d];
                Console.WriteLine("Appuyez sur une touche pour continuer...");
                Console.ReadKey(true);
            }

            return totalDés;

        }

    }
}
