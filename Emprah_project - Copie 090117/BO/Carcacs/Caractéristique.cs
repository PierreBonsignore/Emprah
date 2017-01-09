using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Caractéristique
    {
        private int valeurCarac;
        private string nomCarac;
        private string dimCarac;
        private int modificateur;
        private BonusDeCarac bonus;

        

        public int ValeurDeCaractéristique
        {
            get { return this.valeurCarac; }
            set { this.valeurCarac = value; }
        }

        public string NomDeCaractéristique
        {
            get { return nomCarac; }
            set { nomCarac = value; }
        }

        public int Modificateur
        {
            get
            {
                return modificateur;
            }

            set
            {
                this.modificateur = ValeurDeCaractéristique / 10;
            }
        }

        public BonusDeCarac Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }

        public string DiminutifCaractéristique
        {
            get
            {
                return dimCarac;
            }

            set
            {
                dimCarac = value;
            }
        }

        public Caractéristique(string nomCarac, string dimCarac)
        {
            this.NomDeCaractéristique = nomCarac;
            this.DiminutifCaractéristique = dimCarac;
            this.Bonus = BonusDeCarac.Neutre;
            
        }

        private static void AfficherCarac(int[] carac, string[,] caracName)
        {
            Console.WriteLine();
            for (int i = 0; i < carac.Length; i++)
            {
                if (caracName[1, i].Length == 3)
                {
                    Console.Write("|" + caracName[1, i].ToUpper());
                }
                else
                {
                    Console.Write("| " + caracName[1, i].ToUpper());
                }

            }
            Console.WriteLine("\n --- --- --- --- --- --- --- --- --- ---");
            foreach (int item in carac)
            {
                Console.Write("| " + item);
            }
            Console.WriteLine();
        }


        public override string ToString()
        {
            return this.NomDeCaractéristique + " = " + this.ValeurDeCaractéristique;
        }

        
    }
}
