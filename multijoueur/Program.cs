internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int nombreMystere = random.Next(1, 10);
        int nombreEssaisJoueur1 = 0;
        int nombreEssaisJoueur2 = 0;
        bool joueur1ATrouve = false;
        bool joueur2ATrouve = false;

        Console.WriteLine("Bienvenue dans le jeu de plus ou moins multijoueur ! Devinez le nombre entre 1 et 100.");

        while (!joueur1ATrouve && !joueur2ATrouve)
        {
            // Tour du joueur 1
            Console.Write("Joueur 1, entrez votre nombre : ");
            int nombreUtilisateur1 = Convert.ToInt32(Console.ReadLine());
            nombreEssaisJoueur1++;

            if (nombreUtilisateur1 < nombreMystere)
            {
                Console.WriteLine("C'est plus !");
            }
            else if (nombreUtilisateur1 > nombreMystere)
            {
                Console.WriteLine("C'est moins !");
            }
            else
            {
                joueur1ATrouve = true;
                Console.WriteLine($"Bravo Joueur 1 ! Vous avez trouvé le nombre mystère en {nombreEssaisJoueur1} essais.");
                break;
            }

            // Tour du joueur 2
            Console.Write("Joueur 2, entrez votre nombre : ");
            int nombreUtilisateur2 = Convert.ToInt32(Console.ReadLine());
            nombreEssaisJoueur2++;

            if (nombreUtilisateur2 < nombreMystere)
            {
                Console.WriteLine("C'est plus !");
            }
            else if (nombreUtilisateur2 > nombreMystere)
            {
                Console.WriteLine("C'est moins !");
            }
            else
            {
                joueur2ATrouve = true;
                Console.WriteLine($"Bravo Joueur 2 ! Vous avez trouvé le nombre mystère en {nombreEssaisJoueur2} essais.");
                break;
            }
        }
    }
}