namespace Charac_Generator_DH2.Equipements.Armes
{
    public class _Cadence
    {
        // Cadence: C/S/A

        private int c;
        private int s;
        private int a;

        public int CoupParCoup
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }

        public int SemiAuto
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public int Automatique
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }
    }
}