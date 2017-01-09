namespace BLL
{
    public interface IGenerateur<T>
    {
        void Ajouter(T objet);
        void Modifier(int position);
        void Dupliquer(int position);
        void Supprimer(int position);
    }
}