using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GenerateurArmesDictance : IGenerateur<Arme>
    {
        private List<Arme> listeArmes;

        #region Props
        public List<Arme> ListeArmes
        {
            get { return this.listeArmes; }
            set { this.listeArmes = value; }
        }
        #endregion

        #region Singleton
        public GenerateurArmesDictance instance = null;
        public GenerateurArmesDictance GetInstance()
        {
            if (instance == null)
            {
                instance = new GenerateurArmesDictance();
            }
            return instance;
        }

   

        private GenerateurArmesDictance()
        {

        }
        #endregion

        #region Methodes
            public void Ajouter(Arme arme)
        {
            this.listeArmes.Add(arme);
        }

        public void Modifier(int position)
        {
            throw new NotImplementedException();
        }

        public void Dupliquer(int position)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int position)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
