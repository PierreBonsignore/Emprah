using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charac_Generator_DH2
{
    public class Saisies
    {
        public string Texte(string invite)
        {
            string saisie;
            Console.Write(invite);
            saisie = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(saisie))
            {
                Console.Write("Erreur. Veuillez saisir autre chose: ");
                saisie = Console.ReadLine();
            }
            return saisie;
        }

        public int NombreEntier(string invite)
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

        public string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);

        }
    }
}
