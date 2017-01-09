using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public static class Saisies
    {
        public static string Texte(string invite)
        {
            string saisie;
            Console.Write(invite+": ");
            saisie = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(saisie))
            {
                Console.Write("Erreur. Veuillez saisir autre chose: ");
                saisie = Console.ReadLine();
            }
            return saisie;
        }

        public static int NombreEntier(string invite)
        {
            string saisie;
            int entier;
            bool entOk = false;
            Console.Write(invite);
            saisie = Console.ReadLine();
            entOk = int.TryParse(saisie, out entier);
            while (String.IsNullOrWhiteSpace(saisie) || !entOk)
            {
                Console.Write("Erreur. Veuillez saisir autre chose: ");
                saisie = Console.ReadLine();
                saisie = saisie.Replace(" ", "");
                entOk = int.TryParse(saisie, out entier);
            }
            return entier;
        }

        public static string FirstInUpper(this string chaine, char separateur)
        {
            String chaineFormatee = String.Empty;
            if (!String.IsNullOrWhiteSpace(chaine))
            {
                String[] motDeLaChaine = chaine.Split(separateur);
                //boucler sur les éléments de la chaine
                for (int index = 0; index < motDeLaChaine.Length; index++)
                {
                    String motAFormater = motDeLaChaine[index];
                    if (!String.IsNullOrEmpty(motAFormater))
                    {
                        motAFormater = motAFormater.ToLower();
                        String premiereLettreMaj = motAFormater.Substring(0, 1).ToUpper();
                        String resteDeLaChaine = motAFormater.Substring(1);
                        motDeLaChaine[index] = premiereLettreMaj + resteDeLaChaine;
                    }
                }
                chaineFormatee = String.Join(separateur.ToString(), motDeLaChaine);
            }
            return chaineFormatee;
        }

        public static void AfficherTitre(string nom)
        {
            string border = "###############################################";
            string titreNom = nom.PadLeft(border.Length / 2 + nom.Length / 2);
            string titre = border + "\n" + titreNom + "\n" + border;
            Console.WriteLine(titre);
        }
    }
}
