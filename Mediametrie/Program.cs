using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediametrie
{
        static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());


            //Creation d'une taches

           /* var date_de_fin = new DateTime();
            var nouvelletache = new Tache();
            nouvelletache.Id = 0;
            nouvelletache.nom = "New Tache";
            nouvelletache.description = "New Tache Description";
            nouvelletache.date_creation = DateTime.Now;
            nouvelletache.date_fin = date_de_fin;
            nouvelletache.etat = true;
            nouvelletache.id_container = 0;
            nouvelletache.priorite = 1;

            using (var entities = new Database1Entities())
            {
                entities.Taches.Add(nouvelletache);
            } */
        }
    }
}
