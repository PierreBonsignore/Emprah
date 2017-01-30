using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using DAL;

namespace BLL
{
    public class ArmesBLL : IGenerateur<Arme>
    {
        private BindingList<Arme> listeArmes;

        #region Props
        public BindingList<Arme> ListeArmes
        {
            get { return this.listeArmes; }
            set { this.listeArmes = value; }
        }
        #endregion

        #region Singleton
        public static ArmesBLL instance = null;
        public static ArmesBLL GetInstance()
        {
            if (instance == null)
            {
                instance = new ArmesBLL();
            }
            return instance;
        }

   

        private ArmesBLL()
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

        public BindingList<Arme> Importer(FileStream flux)
        {
            this.ListeArmes = new ArmesDAL().ImportXML(flux);
            return this.ListeArmes;
        }

        public void ExporterListe(BindingList<Arme> liste, FileStream flux)
        {
            new ArmesDAL().ExportListeXml(this.ListeArmes, flux);
        }

        public void Exporter(Arme arme, FileStream flux)
        {
            new ArmesDAL().ExportXml(arme, flux);
        }


        #endregion
    }
}
