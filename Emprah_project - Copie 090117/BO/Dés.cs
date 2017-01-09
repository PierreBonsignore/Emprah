using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Dés
    {
        public static Dés instance = null;
        public static Dés GetInstance()
        {
            if (instance==null)
            {
                instance = new Dés();
            }
            return instance;
        }
        private Dés()
        { }

        public int LancerLesDés(int nbrDés, int valeurDé)
        {
            int[] resultDés = new int[nbrDés];
            int totalDés = 0;
            Random rand = new Random();

            for (int d = 0; d < nbrDés; d++)
            {
                resultDés[d] = rand.Next(1, valeurDé + 1);
                Console.WriteLine("Le dé fait: " + resultDés[d]);
                totalDés = totalDés + resultDés[d];
                Console.ReadKey(true);
            }

            return totalDés;

        }

        public int RollAndKeep(int nbrRoll, int nbrKeep, int valeurDés, int KeepWhat)
        //KeepWhat: 0=tous dés gardés, 1=faibles gardés, 2=plus hauts gardés
        {
            int[] choixDés = new int[nbrRoll];
            int[] keep = new int[nbrKeep];

            for (int indexDé = 0; indexDé < nbrRoll; indexDé++)
            {
                choixDés[indexDé] = LancerLesDés(1, valeurDés);
                Console.WriteLine("Le résultat du dé " + (indexDé + 1) + " est : " + choixDés[indexDé]);
                Console.ReadKey(true);
            }
            Array.Sort(choixDés);//les dés sont triés du plus faible au plus fort            
            if (KeepWhat == 1)
            {
                Console.WriteLine("On garde les dés les plus faibles");
                for (int i = 0; i < nbrKeep; i++)
                {
                    keep[i] = choixDés[i];
                }
            }
            else if (KeepWhat == 2)
            {
                Console.WriteLine("On garde les dés les plus forts");
                Array.Reverse(choixDés);
                for (int i = 0; i < nbrKeep; i++)
                {
                    keep[i] = choixDés[i];
                }
            }
            else //on garde tous les dés
            {
                for (int i = 0; i < nbrKeep; i++)
                {
                    keep[i] = choixDés[i];
                }
            }
            int res = 0;
            Console.Write("\nLes dés gardés sont : ");
            foreach (var item in keep)
            {
                res += item;
                Console.Write(item + ", ");
            }
            Console.WriteLine("Le total de ces dés est {0}", res);
            return res;
        }
    }
}
