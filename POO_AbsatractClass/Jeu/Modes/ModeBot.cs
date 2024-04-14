﻿using POO_AbsatractClass_Interface.Joueur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AbsatractClass_Interface.Jeu.Modes
{
    internal class ModeBot: IModeDeJeu
    {
        public JoueurAbs CreerJoueur(string nom)
        {
            return new JoueurBot(nom);
        }
    }
}
