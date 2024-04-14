namespace multijoueurV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int nombreMystere = random.Next(1, 10);
            bool joueurATrouve = false;
            int nombreJoueurs;

            Console.WriteLine("Bienvenue dans le jeu de plus ou moins multijoueur ! Devinez le nombre entre 1 et 100.");
            Console.Write("Combien de joueurs participent à ce jeu ? ");
            nombreJoueurs = Convert.ToInt32(Console.ReadLine());

            int[] nombreEssaisJoueurs = new int[nombreJoueurs];

            while (!joueurATrouve)
            {
                for (int i = 0; i < nombreJoueurs; i++)
                {
                    Console.Write($"Joueur {i + 1}, entrez votre nombre : ");
                    int nombreUtilisateur = Convert.ToInt32(Console.ReadLine());
                    nombreEssaisJoueurs[i]++;

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
                        Console.WriteLine($"Bravo Joueur {i + 1} ! Vous avez trouvé le nombre mystère en {nombreEssaisJoueurs[i]} essais.");
                        break;
                    }
                }
            }
        }
    }
}
