using BO;
using BO.Equipements;
using BO.Equipements.Armes.Propriétés;
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

        public void ExportListeXml(BindingList<Arme> liste, FileStream fluxSortie)
        {
            XmlDocument doc = new XmlDocument();
            doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            XmlElement racine = doc.CreateElement("armes");
            doc.AppendChild(racine);

            Console.WriteLine("début export" + DateTime.Now.ToLocalTime());
            foreach (Arme gun in liste)
            {
                XmlElement arme = doc.CreateElement("Arme");

                Console.WriteLine("attributs" + DateTime.Now.ToLocalTime());

                XmlAttribute nom = doc.CreateAttribute("Nom");
                nom.InnerText = gun.Nom;
                arme.Attributes.Append(nom);
                Console.WriteLine("nom ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute type = doc.CreateAttribute("Type");
                type.InnerXml = gun.Type.ToString();
                arme.Attributes.Append(type);
                Console.WriteLine("type ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute categorie = doc.CreateAttribute("Categorie");
                int enumCategorie = (int)gun.Categorie;
                categorie.Value = enumCategorie.ToString();
                arme.Attributes.Append(categorie);
                Console.WriteLine("catégorie ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute portee = doc.CreateAttribute("Portée");
                portee.InnerXml = gun.Portee.ToString();
                arme.Attributes.Append(portee);
                Console.WriteLine("portée ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute cadence = doc.CreateAttribute("Cadence");
                cadence.InnerXml = gun.Cadence.ToString();
                arme.Attributes.Append(cadence);
                Console.WriteLine("cadence ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute degatsValeur = doc.CreateAttribute("degValeur");
                degatsValeur.InnerXml = gun.Degats.Valeur.ToString();
                arme.Attributes.Append(degatsValeur);
                Console.WriteLine("dégats ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute degatsType = doc.CreateAttribute("degType");
                int enumType = (int)gun.Degats.Type;
                degatsType.InnerXml = enumType.ToString();
                arme.Attributes.Append(degatsType);
                Console.WriteLine("type dégats ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute penetration = doc.CreateAttribute("Pen");
                penetration.InnerXml = gun.Penetration.ToString();
                arme.Attributes.Append(penetration);
                Console.WriteLine("pénétration ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute autonomie = doc.CreateAttribute("AT");
                autonomie.InnerXml = gun.Autonomie.ToString();
                arme.Attributes.Append(autonomie);
                Console.WriteLine("autonomie ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute rechargement = doc.CreateAttribute("Rech");
                rechargement.InnerXml = gun.Rechargement.nbAction.ToString();
                arme.Attributes.Append(rechargement);
                Console.WriteLine("rechargement ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute typeRech = doc.CreateAttribute("TypeRech");
                int enumRech = (int)gun.Rechargement.type;
                typeRech.InnerXml = enumRech.ToString();
                arme.Attributes.Append(typeRech);
                Console.WriteLine("type rechargement ajouté" + DateTime.Now.ToLocalTime());

                XmlElement attributs = doc.CreateElement("Attributs");
                arme.AppendChild(attributs);
                foreach (AttributArme attribut in gun.Attributs)
                {
                    XmlElement attr = doc.CreateElement("attribut");
                    XmlAttribute nomAtt = doc.CreateAttribute("nomAtt");
                    nomAtt.InnerText = attribut.Nom;
                    attr.Attributes.Append(nomAtt);
                    XmlAttribute description = doc.CreateAttribute("description");
                    description.InnerText = attribut.Description;
                    attr.Attributes.Append(description);

                    attributs.AppendChild(attr);
                }

                XmlAttribute dispo = doc.CreateAttribute("Disponibilité");
                int dispoEnum = (int)gun.Disponibilité;
                dispo.Value = dispoEnum.ToString();
                arme.Attributes.Append(dispo);
                Console.WriteLine("disponibilité ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute poids = doc.CreateAttribute("Poids");
                poids.InnerXml = gun.Poids.ToString();
                arme.Attributes.Append(poids);
                Console.WriteLine("poids ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute refPage = doc.CreateAttribute("refPage");
                refPage.InnerXml = gun.RefPage.ToString();
                arme.Attributes.Append(refPage);
                Console.WriteLine("ref page ajouté" + DateTime.Now.ToLocalTime());

                XmlAttribute source = doc.CreateAttribute("Source");
                int sourceEnum = (int)gun.Source;
                source.InnerXml = sourceEnum.ToString();
                arme.Attributes.Append(source);
                Console.WriteLine("source ajouté" + DateTime.Now.ToLocalTime());

                racine.AppendChild(arme);
                Console.WriteLine("arme terminée" + DateTime.Now.ToLocalTime());

            }

            doc.Save(fluxSortie);
            Console.WriteLine("doc sauvé" + DateTime.Now.ToLocalTime());

        }

        public void ExportXml(Arme armeAExporter, FileStream fluxSortie)
        {
            XmlDocument doc = new XmlDocument();
            doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            
            XmlElement arme = doc.CreateElement("Arme");           

            Console.WriteLine("début export" + DateTime.Now.ToLocalTime());


            Console.WriteLine("attributs" + DateTime.Now.ToLocalTime());

            XmlAttribute nom = doc.CreateAttribute("Nom");
            nom.InnerText = armeAExporter.Nom;
            arme.Attributes.Append(nom);
            Console.WriteLine("nom ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute type = doc.CreateAttribute("Type");
            type.InnerXml = armeAExporter.Type.ToString();
            arme.Attributes.Append(type);
            Console.WriteLine("type ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute categorie = doc.CreateAttribute("Categorie");
            int enumCategorie = (int)armeAExporter.Categorie;
            categorie.Value = enumCategorie.ToString();
            arme.Attributes.Append(categorie);
            Console.WriteLine("catégorie ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute portee = doc.CreateAttribute("Portée");
            portee.InnerXml = armeAExporter.Portee.ToString();
            arme.Attributes.Append(portee);
            Console.WriteLine("portée ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute cadence = doc.CreateAttribute("Cadence");
            cadence.InnerXml = armeAExporter.Cadence.ToString();
            arme.Attributes.Append(cadence);
            Console.WriteLine("cadence ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute degatsValeur = doc.CreateAttribute("degValeur");
            degatsValeur.InnerXml = armeAExporter.Degats.Valeur.ToString();
            arme.Attributes.Append(degatsValeur);
            Console.WriteLine("dégats ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute degatsType = doc.CreateAttribute("degType");
            int enumType = (int)armeAExporter.Degats.Type;
            degatsType.InnerXml = enumType.ToString();
            arme.Attributes.Append(degatsType);
            Console.WriteLine("type dégats ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute penetration = doc.CreateAttribute("Pen");
            penetration.InnerXml = armeAExporter.Penetration.ToString();
            arme.Attributes.Append(penetration);
            Console.WriteLine("pénétration ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute autonomie = doc.CreateAttribute("AT");
            autonomie.InnerXml = armeAExporter.Autonomie.ToString();
            arme.Attributes.Append(autonomie);
            Console.WriteLine("autonomie ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute rechargement = doc.CreateAttribute("Rech");
            rechargement.InnerXml = armeAExporter.Rechargement.nbAction.ToString();
            arme.Attributes.Append(rechargement);
            Console.WriteLine("rechargement ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute typeRech = doc.CreateAttribute("TypeRech");
            int enumRech = (int)armeAExporter.Rechargement.type;
            typeRech.InnerXml = enumRech.ToString();
            arme.Attributes.Append(typeRech);
            Console.WriteLine("type rechargement ajouté" + DateTime.Now.ToLocalTime());

            XmlElement attributs = doc.CreateElement("Attributs");
            arme.AppendChild(attributs);
            foreach (AttributArme attribut in armeAExporter.Attributs)
            {
                XmlElement attr = doc.CreateElement("attribut");
                XmlAttribute nomAtt = doc.CreateAttribute("nomAtt");
                nomAtt.InnerText = attribut.Nom;
                attr.Attributes.Append(nomAtt);
                XmlAttribute description = doc.CreateAttribute("description");
                description.InnerText = attribut.Description;
                attr.Attributes.Append(description);

                attributs.AppendChild(attr);
            }

            XmlAttribute dispo = doc.CreateAttribute("Disponibilité");
            int dispoEnum = (int)armeAExporter.Disponibilité;
            dispo.Value = dispoEnum.ToString();
            arme.Attributes.Append(dispo);
            Console.WriteLine("disponibilité ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute poids = doc.CreateAttribute("Poids");
            poids.InnerXml = armeAExporter.Poids.ToString();
            arme.Attributes.Append(poids);
            Console.WriteLine("poids ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute refPage = doc.CreateAttribute("refPage");
            refPage.InnerXml = armeAExporter.RefPage.ToString();
            arme.Attributes.Append(refPage);
            Console.WriteLine("ref page ajouté" + DateTime.Now.ToLocalTime());

            XmlAttribute source = doc.CreateAttribute("Source");
            int sourceEnum = (int)armeAExporter.Source;
            source.InnerXml = sourceEnum.ToString();
            arme.Attributes.Append(source);
            Console.WriteLine("source ajouté" + DateTime.Now.ToLocalTime());

            doc.AppendChild(arme);
            Console.WriteLine("arme terminée" + DateTime.Now.ToLocalTime());

            Console.WriteLine("attributs" + DateTime.Now.ToLocalTime());


       

        doc.Save(fluxSortie);
            Console.WriteLine("doc sauvé" + DateTime.Now.ToLocalTime());

        }


    public BindingList<Arme> ImportXML(FileStream fluxEntree)
    {
        BindingList<Arme> liste = new BindingList<Arme>();
        XmlDocument doc = new XmlDocument();
        StreamReader str = new StreamReader(fluxEntree);
        doc.Load(str);

        XmlNodeList nodeList = doc.GetElementsByTagName("Arme");

        foreach (XmlNode arme in nodeList)
        {
            Console.WriteLine(arme.Name);
            liste.Add(ArmeBuilder(arme));
        }

        return liste;
    }

    public Arme ArmeBuilder(XmlNode armeXml)
    {
        Arme arme = new Arme();
        arme.Nom = armeXml.Attributes["Nom"].Value;
        Console.WriteLine(arme.Nom);
        switch (armeXml.Attributes["Type"].Value)
        {
            case "Pistolet":
                arme.Type = TypesArmes.Pistolet;
                break;
            case "Base":
                arme.Type = TypesArmes.Base;
                break;
            case "Melee":
                arme.Type = TypesArmes.Melee;
                break;
            case "Jet":
                arme.Type = TypesArmes.Jet;
                break;
        }

        arme.Categorie = (CategoriesArmes)int.Parse(armeXml.Attributes["Categorie"].Value);
        Console.WriteLine(arme.Categorie);

        arme.Portee = int.Parse(armeXml.Attributes["Portée"].Value);
        Console.WriteLine(arme.Portee);

        arme.Cadence = CadenceBuilder(armeXml.Attributes["Cadence"].InnerXml);
        Console.WriteLine(arme.Cadence);

        arme.Degats = new Degats();
        arme.Degats.Valeur = int.Parse(armeXml.Attributes["degValeur"].Value);
        arme.Degats.Type = (TypeDegats)int.Parse(armeXml.Attributes["degType"].Value);
        Console.WriteLine(arme.Degats);

        arme.Penetration = int.Parse(armeXml.Attributes["Pen"].Value);
        Console.WriteLine(arme.Penetration);
        arme.Autonomie = int.Parse(armeXml.Attributes["AT"].Value);
        Console.WriteLine(arme.Autonomie);

        arme.Rechargement = new Rech();
        arme.Rechargement.nbAction = int.Parse(armeXml.Attributes["Rech"].Value);
        arme.Rechargement.type = (TypeRech)int.Parse(armeXml.Attributes["TypeRech"].Value);

        arme.Disponibilité = (Disponibilité)int.Parse(armeXml.Attributes["Disponibilité"].Value);
        Console.WriteLine(arme.Disponibilité);

        arme.Poids = int.Parse(armeXml.Attributes["Poids"].Value);
        Console.WriteLine(arme.Poids);
        arme.RefPage = armeXml.Attributes["refPage"].Value;
        Console.WriteLine(arme.RefPage);

        arme.Source = (Source)int.Parse(armeXml.Attributes["Source"].Value);
        Console.WriteLine(arme.Source);

        XmlNodeList listeElements = armeXml.ChildNodes;
        Console.WriteLine("liste created");

        foreach (XmlNode element in listeElements)
        {
            Console.WriteLine(element);
            if (element is XmlElement)
            {
                foreach (XmlElement attribut in element.ChildNodes)
                {
                    AttributArme att = new AttributArme();
                    Console.WriteLine(attribut.Name);
                    att.Nom = attribut.Attributes["nomAtt"].InnerText;
                    Console.WriteLine(attribut.Attributes["nomAtt"].InnerText);
                    att.Description = attribut.Attributes["description"].InnerText;
                    Console.WriteLine(attribut.Attributes["description"].InnerText);
                    arme.Attributs.Add(att);
                }
            }
        }

        return arme;
    }


    private Cadence CadenceBuilder(string value)
    {
        Console.WriteLine("value: " + value);
        Cadence cadence = new Cadence(0, 0, 0);
        cadence.CoupParCoup = int.Parse(value.Split('/')[0]);
        cadence.SemiAuto = int.Parse(value.Split('/')[1]);
        cadence.Automatique = int.Parse(value.Split('/')[2]);
        Console.WriteLine("cadence: " + cadence.ToString());
        return cadence;
    }
}


}

