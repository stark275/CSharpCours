using POO_AbsatractClass_Interface.Jeu.Modes;
using POO_AbsatractClass_Interface.Joueur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ui.Database;
using ui.Jeu.Messages;
using ui.Models;

namespace POO_AbsatractClass_Interface.Jeu
{
    internal class Jeux
    {
        private int nombreMystere;
        private JoueurAbs[] joueurs;
        private IMessage message;
        private readonly MySqlDB DB;

        public Jeux(int nombreJoueurs, IModeDeJeu modeDeJeu, IMessage message)
        {
            Random random = new Random();
            nombreMystere = random.Next(2, 10);

            joueurs = new JoueurAbs[nombreJoueurs];

            for (int i = 0; i < nombreJoueurs; i++)
            {
                joueurs[i] = modeDeJeu.CreerJoueur($"Joueur {i + 1}");
            }

            this.message = message;

            DB = new MySqlDB("127.0.0.1", "root", "", "jeu");
           /* DB.testConnexion();*/
        }

        public void Jouer(TextBox textBox)
        {

                    int nombreUtilisateur = joueurs[0].DevinerNombre(textBox);

                    if (nombreUtilisateur < nombreMystere)
                    {
                        message.Contenu = "C'est plus !";
                    }
                    else if (nombreUtilisateur > nombreMystere)
                    {
                        message.Contenu = "C'est moins !";
                    }
                    else
                    {
                        message.Contenu = $"{joueurs[0].Nom} ! Vous avez trouvé le nombre mystère en {joueurs[0].NombreEssais} essais.";
                        
                        Log log = new Log(DB);
                        log.CreateLog(joueurs[0].Nom, joueurs[0].NombreEssais);
                        
                    }
               
            
        }
    }
}
