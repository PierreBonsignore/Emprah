using BO;
using System.ComponentModel;
using System.IO;

namespace BLL
{
    public interface IGenerateur<T>
    {
        void Ajouter(T objet);
        void Modifier(int position);
        void Dupliquer(int position);
        void Supprimer(int position);

        BindingList<T> Importer(FileStream flux);

        void ExporterListe(BindingList<T> liste, FileStream flux);        
        
    }
}