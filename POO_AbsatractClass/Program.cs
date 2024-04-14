using POO_AbsatractClass_Interface.Jeu;
using POO_AbsatractClass_Interface.Jeu.Modes;

namespace POO_AbsatractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Combien de joueurs participent à ce jeu ? ");
            int nombreJoueurs = Convert.ToInt32(Console.ReadLine());

            IModeDeJeu modeHumain = new ModeHumain();
            Jeu jeuAvecHumains = new Jeu(nombreJoueurs, modeHumain);

            // Créer un jeu avec des joueurs bot
            IModeDeJeu modeBot = new ModeBot();
            Jeu jeuAvecBots = new Jeu(nombreJoueurs, modeBot);

            jeuAvecBots.Jouer();
        }
    }
}
