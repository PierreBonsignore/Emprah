using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables relatives au perso
            string name;


            //Le joueur est salué et entre le nom
            Console.WriteLine("####################################");
            Console.WriteLine("  Dark Heresy 2 Character Generator  ");
            Console.WriteLine("####################################");



            name = SaisieTexte("\nBonjour.\nSaisissez le nom de votre personnage:");

            Console.WriteLine("\nParfait. Le nom de votre personnages est " + name);
            Console.ReadKey(true); Console.Clear();

            //choix du monde natal et influence sur les carac            

            bool mondeEstChoisi = false;

            while (mondeEstChoisi == false)
            {
                int mondeNatal = int.Parse(SaisieTexte(
                "\nChoisissez le monde natal de " + name +
                "\n\n1= Monde Sauvage: +Force, +Endurance -Influence" +
                "\n2= Monde Forge: +Intelligence, + Endurance, -Social" +
                "\n3= Haute naissance: +Social, +Influence, -Endurance" +
                "\n4= Monde Ruche: +Agilité, +Perception, -Force Mentale" +
                "\n5= Monde Saint: +Social, +Force Mentale, -Perception" +
                "\n6= Enfant du Vide: +Intelligence, +Force Mentale, -Force" +
                "\n\nChoix du monde:"));

                //Caractéristiques; 0:CC; 1:CT; 2:FOR; 3:EN; 4:AGI; 5:INT; 6:PER; 7:FM; 8:SOC; 9:INF

                switch (mondeNatal)
                {
                    case 1:
                        Console.WriteLine("\n" + name + " vient d'un Monde Sauvage");
                        mondeEstChoisi = true; break;
                    case 2:
                        Console.WriteLine("\n" + name + " vient d'un Monde Forge");
                        mondeEstChoisi = true; break;
                    case 3:
                        Console.WriteLine("\n" + name + " est de Haute Naissance");
                        mondeEstChoisi = true; break;
                    case 4:
                        Console.WriteLine("\n" + name + " vient d'un Monde Ruche");
                        mondeEstChoisi = true; break;
                    case 5:
                        Console.WriteLine("\n" + name + " vient d'un Monde Saint");
                        mondeEstChoisi = true; break;
                    case 6:
                        Console.WriteLine("\n" + name + " est un Enfant du Vide");
                        mondeEstChoisi = true; break;
                    default:
                        Console.WriteLine("\nErreur. Le monde choisi est inexistant.");
                        Console.ReadKey(true); Console.Clear();
                        break;
                }
            }

            //CARACTERISTIQUES
            //Caractéristiques; 0:CC; 1:CT; 2:FOR; 3:EN; 4:AGI; 5:INT; 6:PER; 7:FM; 8:SOC; 9:INF

            //table des carac du perso
            int[] carac = new int[10];
            string[] caracName = {"Capacité de Combat"
                                    , "Capacité de Tir"
                                    , "Force"
                                    , "Endurance"
                                    , "Agilité"
                                    , "Intelligence"
                                    , "Perception"
                                    , "Force Mentale"
                                    , "Sociabilité"
                                    , "Influence"};


            Console.ReadKey(true); Console.Clear();
            Console.WriteLine("\nLes caractéristiques de " + name + ":");
            Console.ReadKey(true);


            int cptCarac = 0;
            for (cptCarac = 0; cptCarac < 10; cptCarac++)
            {
                Console.WriteLine("\nLancer de dés pour " + caracName[cptCarac]);

                carac[(cptCarac)] += LancerLesDés(2, 10) + 20;


                Console.WriteLine("\nVotre " + caracName[cptCarac] + " a un score de " + carac[cptCarac]);
                Console.ReadKey(true);
            }
            RollAndKeep(3, 2, 10);

            Console.ReadKey();







        }
        static string SaisieTexte(string texte)
        {
            string saisie;
            Console.Write(texte);
            saisie = Console.ReadLine();
            saisie = saisie.Replace(" ", "");
            while (String.IsNullOrWhiteSpace(saisie) || String.IsNullOrEmpty(saisie))
            {
                Console.Write("Erreur. Veuillez saisir autre chose: ");
                saisie = Console.ReadLine();
            }
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
                Console.WriteLine("Le résultat du dé " + (d + 1) + " est : " + resultDés[d]);
                totalDés = totalDés + resultDés[d];
                Console.ReadKey(true);
            }

            return totalDés;

        }

        static int RollAndKeep(int nbrRoll, int nbrKeep, int valeurDés)
        {
            int[] choixDés = new int[nbrRoll];
            for (int indexDé = 0; indexDé < nbrRoll; indexDé++)
            {
                choixDés[indexDé] = LancerLesDés(1, valeurDés);                
            }
            return choixDés[1];
        }


    }
}

