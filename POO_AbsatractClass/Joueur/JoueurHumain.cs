using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AbsatractClass_Interface.Joueur
{
    internal class JoueurHumain: JoueurAbs
    {
        public JoueurHumain(string nom) : base(nom) { }

        public override int DevinerNombre()
        {
            NombreEssais++;
            Console.Write($"{Nom}, entrez votre nombre : ");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : veuillez entrer un nombre valide.");
                return DevinerNombre(); // Rappelle la fonction pour demander à nouveau un nombre.
            }
        }
    }
}
