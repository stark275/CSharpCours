namespace POO
{
    public class Joueur
    {
        public int NombreEssais { get; private set; }
        public string Nom { get; private set; }

        public Joueur(string nom)
        {
            Nom = nom;
            NombreEssais = 0;
        }

        public int DevinerNombre()
        {
            NombreEssais++;
            Console.Write($"{Nom}, entrez votre nombre : ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Jeu
    {
        private int nombreMystere;
        private Joueur[] joueurs;

        public Jeu(int nombreJoueurs)
        {
            Random random = new Random();
            nombreMystere = random.Next(1, 10);

            joueurs = new Joueur[nombreJoueurs];

            for (int i = 0; i < nombreJoueurs; i++)
            {
                joueurs[i] = new Joueur($"Joueur {i + 1}");
            }
        }

        public void Jouer()
        {
            Console.WriteLine("Bienvenue dans le jeu de plus ou moins multijoueur ! Devinez le nombre entre 1 et 100.");

            bool joueurATrouve = false;

            while (!joueurATrouve)
            {
                foreach (var joueur in joueurs)
                {
                    int nombreUtilisateur = joueur.DevinerNombre();

                    if (nombreUtilisateur < nombreMystere)
                    {
                        Console.WriteLine("C'est plus !");
                    }
                    else if (nombreUtilisateur > nombreMystere)
                    {
                        Console.WriteLine("C'est moins !");
                    }
                    else
                    {
                        joueurATrouve = true;
                        Console.WriteLine($"Bravo {joueur.Nom} ! Vous avez trouvé le nombre mystère en {joueur.NombreEssais} essais.");
                        break;
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Combien de joueurs participent à ce jeu ? ");
            int nombreJoueurs = Convert.ToInt32(Console.ReadLine());

            Jeu jeu = new Jeu(nombreJoueurs);
            jeu.Jouer();
        }
    }
}
