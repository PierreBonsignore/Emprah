using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class Degats
    {
        private TypeDegats type;
        public int Valeur { get; set; }
        public TypeDegats Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
                ChangerEtiquette();
            }
        }

        public string Etiquette { get; set; }

        public Degats()
        {

        }
        public Degats(int valeur=0, TypeDegats type=TypeDegats.Impact)
        {
            this.Valeur = valeur;
            this.Type = type;
        }

        private void ChangerEtiquette()
        {
            switch (this.type)
            {
                case TypeDegats.Energie:
                    this.Etiquette = "E";
                    break;
                case TypeDegats.Impact:
                    this.Etiquette = "I";
                    break;
                case TypeDegats.Dechirant:
                    this.Etiquette = "D";
                    break;
                case TypeDegats.Explosif:
                    this.Etiquette = "X";
                    break;
            }

        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("1d10+" + this.Valeur + this.Etiquette);
            return s.ToString();
        }

    }
}