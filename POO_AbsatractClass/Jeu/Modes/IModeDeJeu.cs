using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_AbsatractClass_Interface.Joueur;

namespace POO_AbsatractClass_Interface.Jeu.Modes
{
    internal interface IModeDeJeu
    {
        JoueurAbs CreerJoueur(string nom);
    }
}
