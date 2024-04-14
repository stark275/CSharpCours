using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AbsatractClass_Interface.Joueur
{
    internal class JoueurBot: JoueurAbs
    {
        private Random random;

        public JoueurBot(string nom) : base(nom)
        {
            random = new Random();
        }

        public override int DevinerNombre()
        {
            NombreEssais++;
            int devinage = random.Next(1, 101);
            Console.WriteLine($"{Nom} (Bot) devine le nombre {devinage}.");
            return devinage;
        }
    }
}
