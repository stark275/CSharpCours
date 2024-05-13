using POO_AbsatractClass_Interface.Jeu;
using POO_AbsatractClass_Interface.Jeu.Gestion;
using POO_AbsatractClass_Interface.Jeu.Modes;
using ui.Models;

namespace POO_AbsatractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GestionLogs gst = new GestionLogs(new Log());

            Console.Write("Que voulez-vous faire? Saisissez le nombre correspondant à votre choix \n");
            Console.WriteLine("1. Jouer ? ");
            Console.WriteLine("2. Gerer ? ");

            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.Write("Combien de joueurs participent à ce jeu ? ");
                    int nombreJoueurs = Convert.ToInt32(Console.ReadLine());

                    IModeDeJeu modeHumain = new ModeHumain();
                    Jeu jeuAvecHumains = new Jeu(nombreJoueurs, modeHumain);

                    // Créer un jeu avec des joueurs bot
                    IModeDeJeu modeBot = new ModeBot();
                    Jeu jeuAvecBots = new Jeu(nombreJoueurs, modeBot);

                    jeuAvecHumains.Jouer();

                    foreach (var log in gst.GetLogs())
                    {
                        Console.WriteLine(log);
                    }
                    break;

                case 2:
                    gst.AfficherOptions();
                    break;
            }

            
        }
    }
}
