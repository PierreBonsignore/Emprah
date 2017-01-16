using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class ArmesDAL
    {

        public void ExportSoap(BindingList<Arme> liste, FileStream flux)
        {
            SoapFormatter formatter = new SoapFormatter();

            try
            {
                formatter.Serialize(flux, liste);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                flux.Close();
            }


        }

        public BindingList<Arme> ImportSoap(FileStream flux)
        {
            SoapFormatter formatter = new SoapFormatter();

            try
            {
                return (BindingList<Arme>)formatter.Deserialize(flux);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                flux.Close();
            }

        }

        //public void ExportXML(BindingList<Arme> liste, FileStream fluxSortie)
        //{
        //    XmlDocument doc = new XmlDocument();
        //    XmlElement racine = doc.CreateElement("armes");
        //    doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
        //    doc.AppendChild(racine);

        //    foreach (Arme gun in liste)
        //    {
        //        XmlElement arme = doc.CreateElement("Arme");

        //        XmlAttribute nom = doc.CreateAttribute("Nom");
        //        nom.InnerText = gun.Nom;
        //        arme.Attributes.Append(nom);

        //        XmlAttribute type = doc.CreateAttribute("Type");
        //        type.InnerXml = gun.Type.ToString();
        //        arme.Attributes.Append(type);

        //        XmlAttribute portee = doc.CreateAttribute("Portée");
        //        portee.InnerXml = gun.Portée.ToString();
        //        arme.Attributes.Append(portee);

        //        XmlAttribute cadence = doc.CreateAttribute("Cadence");
        //        cadence.InnerXml = gun.Cadence.ToString();
        //        arme.Attributes.Append(cadence);

        //        XmlAttribute degats = doc.CreateAttribute("Dégats");
        //        degats.InnerXml = gun.Degats.ToString();
        //        arme.Attributes.Append(degats);

        //        XmlAttribute penetration = doc.CreateAttribute("Pen");
        //        penetration.InnerXml = gun.Penetration.ToString();
        //        arme.Attributes.Append(penetration);

        //        XmlAttribute autonomie = doc.CreateAttribute("AT");
        //        autonomie.InnerXml = gun.Autonomie.ToString();
        //        arme.Attributes.Append(autonomie);

        //        XmlAttribute rechargement = doc.CreateAttribute("Rech");
        //        rechargement.InnerXml = gun.Rechargement.ToString();
        //        arme.Attributes.Append(rechargement);

        //        XmlAttribute special = doc.CreateAttribute("Special");
        //        special.InnerXml = gun.Special.Nom;
        //        arme.Attributes.Append(special);

        //        XmlAttribute dispo = doc.CreateAttribute("Disponibilité");
        //        dispo.InnerXml = gun.Disponibilité.ToString();
        //        arme.Attributes.Append(dispo);

        //        XmlAttribute poids = doc.CreateAttribute("Poids");
        //        poids.InnerXml = gun.Poids.ToString();
        //        arme.Attributes.Append(poids);

        //        XmlAttribute refPage = doc.CreateAttribute("refPage");
        //        refPage.InnerXml = gun.RefPage.ToString();
        //        arme.Attributes.Append(refPage);

        //        racine.AppendChild(arme);
        //    }

        //    doc.Save(fluxSortie);
        //}

        //public BindingList<Arme> ImportXML(FileStream fluxEntree)
        //{
        //    BindingList<Arme> liste = new BindingList<Arme>();

        //    XmlDocument doc = new XmlDocument();

        //    doc.Load(fluxEntree);

        //    foreach (XmlElement node1 in doc)
        //    {
        //        Console.WriteLine("node1" + node1.Name);
        //        foreach (XmlElement armeXml in node1)
        //        {
        //            Console.WriteLine("node2" + armeXml.Name);
        //            Arme arme = new Arme();

        //            foreach (XmlAttribute attribut in armeXml)
        //            {
        //                if (attribut.Name == "Nom")
        //                {
        //                    arme.Nom = attribut.InnerText;
        //                }
        //            }
        //            Console.WriteLine(arme.Nom);
        //            liste.Add(arme);
        //        }
        //    }

        //    return liste;
        //}

    }


}

