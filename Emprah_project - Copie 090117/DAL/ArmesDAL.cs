using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class ArmesDAL
    {
        public void ExportXML(BindingList<Arme> liste, FileStream fluxSortie)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement racine = doc.CreateElement("racine");
            doc.AppendChild(racine);

            foreach (Arme item in liste)
            {
                XmlElement arme = doc.CreateElement("arme");
                XmlAttribute nom = doc.CreateAttribute("nom");
                nom.InnerText = item.Nom;
                arme.Attributes.Append(nom);
                racine.AppendChild(arme);
            }

            doc.Save(fluxSortie);
        }
    }
}
