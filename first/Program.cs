internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int nombreMystere = random.Next(1, 10);
        int nombreUtilisateur = 0;
        int nombreEssais = 0;

        Console.WriteLine("Bienvenue dans le jeu de plus ou moins ! Devinez le nombre entre 1 et 100.");

        while (nombreUtilisateur != nombreMystere)
        {
            Console.Write("Entrez votre nombre : ");
            nombreUtilisateur = Convert.ToInt32(Console.ReadLine());
            nombreEssais++;

            if (nombreUtilisateur < nombreMystere)
            {
                Console.WriteLine("C'est plus !");
            }
            else if (nombreUtilisateur > nombreMystere)
            {
                Console.WriteLine("C'est moins !");
            }
        }

        Console.WriteLine($"Bravo ! Vous avez trouvé le nombre mystère en {nombreEssais} essais.");
    }
}