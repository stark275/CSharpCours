using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ui.Models;

namespace POO_AbsatractClass_Interface.Jeu.Gestion
{
    internal class GestionLogs
    {
        private readonly Log log;
        public GestionLogs(Log log) {
            this.log = log; 
        }

        public List<string> GetLogs()
        {
            return log.GetLogs();
        }

        public void AfficherOptions() {
            Console.WriteLine("1. Supprimer un Log ");
            Console.WriteLine("2. Mettre à jour un Log ");
            int choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1:
                    SupprimerLog();
                    break;
                case 2:
                    MiseAJourLog();
                    break;
            }
        }

        private void MiseAJourLog()
        {
            Console.WriteLine(" LOL ce n'est pas logique !!!!!! ");

        }

        public void DisplayLogs()
        {
            foreach (var log in GetLogs())
            {
                Console.WriteLine(log);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
        }

        private void SupprimerLog()
        {
            DisplayLogs();
            Console.WriteLine(" Tapez l'ID du log à supprimer ");

            int choix = Convert.ToInt32(Console.ReadLine());

            log.DeleteLog(choix);

            DisplayLogs();

        }
    }
}
