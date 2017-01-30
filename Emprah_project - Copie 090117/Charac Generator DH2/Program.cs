using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BO;

namespace Charac_Generator_DH2
{
    class Program
    {
        //PROGRAMME
        static void Main(string[] args)
        {
            Arme arme = new Arme();
            arme.Nom = "Boltgun";
            arme.Type = TypesArmes.Base;
            arme.Portee = 100;
            arme.RefPage = "DH CoreRulebook, 151";

            arme.Cadence = new Cadence(1, 3, 0);
            arme.Degats = new Degats(5, TypeDegats.Explosif);
            arme.Penetration = 4;
            arme.Autonomie = 24;
            arme.Rechargement = new Rech(1, TypeRech.Action);
            arme.Poids = 7;
            arme.Disponibilité = Disponibilité.TresRare;

            Console.WriteLine(arme);
            Console.ReadKey(true);

            Console.WriteLine("########################################");
            Console.WriteLine("   Dark Heresy 2 Character Generator  ");
            Console.WriteLine("########################################");

            //variables relatives au perso
            Console.WriteLine();
            Personnage perso = new Personnage(Saisies.Texte("Bonjour. Quel est le nom de votre personnage?").FirstInUpper(' '));

            Console.WriteLine("\nParfait. Le nom de votre personnages est " + perso.Nom);
            Console.ReadKey(true); Console.Clear();

            ChoixMonde(perso);

            DefinirCarac_PtsVie_PtsDestin(perso);

            ChoixBackground(perso); 


            ChoixRole(perso);

            Console.WriteLine(perso.FichePerso());

            Console.ReadKey(true);

        }



        //METHODES
        static void ChoixMonde(Personnage perso)
        {

            //Génération des mondes natals
            List<Monde_Natal> Mondes_Natals = GénérerMondes();


            #region mise en place menu
            // mise en place Menu
            // x= largeur, y = hauteur, du tableau. curs = position du curseur
            string curseur = ">";
            int positionCurs = 0;
            int x = 2;
            int y = 6;

            string[,] menuWorlds = new string[x, y];

            for (int i = 0; i < y; i++)
            {
                menuWorlds[0, i] = " ";
            }
            menuWorlds[0, positionCurs] = curseur;

            menuWorlds[1, 0] = "Monde Sauvage";
            menuWorlds[1, 1] = "Monde Forge";
            menuWorlds[1, 2] = "Haute Naissance";
            menuWorlds[1, 3] = "Monde Ruche";
            menuWorlds[1, 4] = "Monde Saint";
            menuWorlds[1, 5] = "Enfant du Vide";
            #endregion

            #region Affichage Menu

            ConsoleKeyInfo cki;
            bool mondeEstChoisi = false;
            //début loop refresh
            do
            {
                for (int h = 0; h < y; h++)
                {
                    menuWorlds[0, h] = " ";
                }
                //placage du curseur
                menuWorlds[0, positionCurs] = curseur;
                Console.WriteLine("\nChoisissez le monde natal de " + perso.Nom);


                //affichage tableau
                for (int h = 0; h < y; h++)
                {
                    for (int l = 0; l < x; l++)
                    {
                        Console.Write(menuWorlds[l, h]);
                    }
                    Console.WriteLine();
                }
                //affichage infos monde                
                Console.WriteLine("\nDescription:\n" + Mondes_Natals[positionCurs].ToString());
                #endregion

                #region Validation et affectation

                //lecture touche
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.DownArrow && positionCurs < y - 1)
                {
                    positionCurs++;
                }
                if (cki.Key == ConsoleKey.UpArrow && positionCurs > 0)
                {
                    positionCurs--;
                }
                if (cki.Key == ConsoleKey.Enter)
                {
                    //définition du monde et des bonus de carac

                    switch (positionCurs)
                    {
                        case 0:
                            //Monde Sauvage
                            perso.MondeNatal = Mondes_Natals[0];

                            perso.FOR.Bonus = BonusDeCarac.Positif;
                            perso.END.Bonus = BonusDeCarac.Positif;
                            perso.INF.Bonus = BonusDeCarac.Negatif;
                            break;
                        case 1:
                            //Monde Forge
                            perso.MondeNatal = Mondes_Natals[1];

                            perso.INT.Bonus = BonusDeCarac.Positif;
                            perso.END.Bonus = BonusDeCarac.Positif;
                            perso.SOC.Bonus = BonusDeCarac.Negatif;

                            break;
                        case 2:
                            //Haute Naissance
                            perso.MondeNatal = Mondes_Natals[2];

                            perso.SOC.Bonus = BonusDeCarac.Positif;
                            perso.INF.Bonus = BonusDeCarac.Positif;
                            perso.END.Bonus = BonusDeCarac.Negatif;

                            break;
                        case 3:
                            //Monde Ruche
                            perso.MondeNatal = Mondes_Natals[3];

                            perso.AGI.Bonus = BonusDeCarac.Positif;
                            perso.PER.Bonus = BonusDeCarac.Positif;
                            perso.FM.Bonus = BonusDeCarac.Negatif;

                            break;
                        case 4:
                            //Monde Saint
                            perso.MondeNatal = Mondes_Natals[4];

                            perso.SOC.Bonus = BonusDeCarac.Positif;
                            perso.FM.Bonus = BonusDeCarac.Positif;
                            perso.PER.Bonus = BonusDeCarac.Negatif;

                            break;
                        case 5:
                            //Enfant du Vide
                            perso.MondeNatal = Mondes_Natals[5];

                            perso.INT.Bonus = BonusDeCarac.Positif;
                            perso.FM.Bonus = BonusDeCarac.Positif;
                            perso.FOR.Bonus = BonusDeCarac.Negatif;
                            break;
                    }
                    mondeEstChoisi = true;
                    Console.WriteLine("\n" + perso.Nom + " " + perso.MondeNatal.DesignationMonde);
                    Console.ReadKey(true);
                }
                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }


                Console.Clear();
            } while (!mondeEstChoisi);



            #endregion

            Console.Clear();
        }

        static void DefinirCarac_PtsVie_PtsDestin(Personnage perso)
        {
            Dés dé = Dés.GetInstance();

            #region Definition caracs

            Console.WriteLine("\nLes caractéristiques de " + perso.Nom + ":");

            Console.ReadKey(true);


            //Caractéristiques; 0:CC; 1:CT; 2:FOR; 3:EN; 4:AGI; 5:INT; 6:PER; 7:FM; 8:SOC; 9:INF
            //Modificateurs ; 0: Neutre, on lance2d10; 1: Negatif, RollandKeep - ; 2: Positif, RollandKeep +

            //Caractéristiques; 0:CC; 1:CT; 2:FOR; 3:EN; 4:AGI; 5:INT; 6:PER; 7:FM; 8:SOC; 9:INF

            //table des carac du perso
            int[] carac = new int[10];


            
            foreach (var item in perso.Caractéristiques)
            {
                Console.WriteLine("\nLancer de dés pour " + item.NomDeCaractéristique);
                switch (item.Bonus)
                {
                    case BonusDeCarac.Neutre:
                        Console.WriteLine("On lance 2d10");
                        Console.ReadKey(true);
                        item.ValeurDeCaractéristique += dé.LancerLesDés(2, 10) + 20;
                        break;
                    case BonusDeCarac.Negatif:
                        Console.WriteLine("On lance 3d10 et on gardera les 2 plus faibles");
                        Console.ReadKey(true);
                        item.ValeurDeCaractéristique += dé.RollAndKeep(3, 2, 10, 1) + 20;
                        break;
                    case BonusDeCarac.Positif:
                        Console.WriteLine("On lance 3d10 et on gardera 2 les 2 plus forts");
                        Console.ReadKey(true);
                        item.ValeurDeCaractéristique += dé.RollAndKeep(3, 2, 10, 2) + 20;
                        break;
                }

                Console.WriteLine("\nVotre " + item.NomDeCaractéristique + " a un score de " + item.ValeurDeCaractéristique);
                Console.ReadKey(true);
                Console.Clear();

            }
            #endregion

            #region Definition Pts de Vie
            //definition PV ; pts blessure base + 1d5
            Console.WriteLine("\nPoints de vie de " + perso.Nom + ": " + perso.MondeNatal.PtsBlessuresBase + " +1d5.");
            Console.ReadKey(true);

            perso.PointsDeVie = perso.MondeNatal.PtsBlessuresBase + dé.LancerLesDés(1, 5);
            Console.WriteLine("\n" + perso.Nom + " possède " + perso.PointsDeVie + " Points de Vie.");


            Console.ReadKey(true);
            Console.Clear();
            #endregion

            #region Definition Pts de Destin

            Console.WriteLine("Détermination des Points de Destin.\n{0} possède une base de {1} Pts de Destin.", perso.Nom, perso.MondeNatal.PtsDestinBase);
            Console.ReadKey(true);
            Console.WriteLine("\n{0} recquiert la Bénédiction de l'Empereur-Dieu (seuil {1}).\nOn lance 1d10.", perso.Nom, perso.MondeNatal.EmpereurBenediction);

            Console.ReadKey(true);
            int jetBenediction = dé.LancerLesDés(1, 10);

            Console.WriteLine("\nRésultat du dé: {0}", jetBenediction);

            if (jetBenediction >= perso.MondeNatal.EmpereurBenediction)
            {
                Console.WriteLine("\n{0} reçoit la Bénédiction de l'Empereur! Il gagne +1 Pts de Destin.", perso.Nom);
                perso.PointsDeDestin = perso.MondeNatal.PtsDestinBase + 1;
            }
            else
            {
                Console.WriteLine("\nL'Empereur-Dieu reste silencieux.\n{0} ne gagne pas de Pts de Destin supplémentaire.", perso.Nom);
                perso.PointsDeDestin = perso.MondeNatal.PtsDestinBase;
            }
            
            Console.ReadKey(true);
            Console.WriteLine("\n{0} a {1} Points de Destin.", perso.Nom, perso.PointsDeDestin);
            Console.ReadKey(true);
            Console.Clear();
            #endregion
        }

        static void ChoixBackground(Personnage perso)
        {
            //Génération des backgrounds
            List<_Background> ListeBackgrounds = GénérerBackgrounds();

            #region Mise en place Menu Backgrounds
            #endregion

            #region Affichage Menu Backgrounds
            #endregion

            #region Validation Choix Background
            #endregion
        }

        static List<_Background> GénérerBackgrounds()
        {
            List<_Background> liste = new List<_Background>();
            

            return liste;
        }

        static void ChoixRole(Personnage perso)
        {
            throw new NotImplementedException();
        }

        static List<Monde_Natal> GénérerMondes()
        {
            /*Monde Sauvage: +Force, +Endurance - Influence" +
                Monde Forge: +Intelligence, + Endurance, -Social" +
                 Haute naissance: +Social, +Influence, -Endurance" +
                Monde Ruche: +Agilité, +Perception, -Force Mentale" +
               Monde Saint: +Social, +Force Mentale, -Perception" +
                Enfant du Vide: +Intelligence, +Force Mentale, -Force" +*/
            Monde_Natal MondeSauvage = new MondeSauvage();
            Monde_Natal MondeForge = new MondeForge();
            Monde_Natal HauteNaissance = new HauteNaissance();
            Monde_Natal MondeRuche = new MondeRuche();
            Monde_Natal MondeSaint = new MondeSaint();
            Monde_Natal EnfantDuVide = new EnfantDuVide();

            List<Monde_Natal> listeMondes = new List<Monde_Natal>();
            listeMondes.Add(MondeSauvage);
            listeMondes.Add(MondeForge);
            listeMondes.Add(HauteNaissance);
            listeMondes.Add(MondeRuche);
            listeMondes.Add(MondeSaint);
            listeMondes.Add(EnfantDuVide);
            return listeMondes;
        }





    }
}


