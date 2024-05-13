namespace POO_AbsatractClass_Interface.Joueur
{
    internal abstract class JoueurAbs: IJoueur
    {
        public int NombreEssais { get; protected set; }
        public string Nom { get; private set; }

        public JoueurAbs(string nom)
        {
            Nom = nom;
            NombreEssais = 0;
        }

        public abstract int DevinerNombre(TextBox textBox);
    }
}
