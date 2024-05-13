using POO_AbsatractClass_Interface.Jeu.Modes;
using POO_AbsatractClass_Interface.Joueur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ui.Models;

namespace POO_AbsatractClass_Interface.Jeu
{
    internal class Jeu
    {
        private int nombreMystere;
        private JoueurAbs[] joueurs;

        public Jeu(int nombreJoueurs, IModeDeJeu modeDeJeu)
        {
            Random random = new Random();
            nombreMystere = random.Next(1, 10);

            joueurs = new JoueurAbs[nombreJoueurs];

            for (int i = 0; i < nombreJoueurs; i++)
            {
                joueurs[i] = modeDeJeu.CreerJoueur($"Joueur {i + 1}");
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
                        Log log = new Log();
                        log.CreateLog(joueur.Nom, joueur.NombreEssais);
                        Console.WriteLine($"Bravo {joueur.Nom} ! Vous avez trouvé le nombre mystère en {joueur.NombreEssais} essais.");
                        break;
                    }
                }
            }
        }
    }
}
