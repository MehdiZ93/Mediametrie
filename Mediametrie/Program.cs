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
            /*using (var entities = new GestionnaireEntities())
            {
                var tacheAjouter = new Container()
                {
                    nom = "Test",
                    etat = false
                };
                entities.Containers.Add(tacheAjouter);
                entities.SaveChanges();
                Console.WriteLine("Ajout");
                foreach (var cont in entities.Containers)
                {
                    Console.WriteLine("nom : " + cont.nom);
                }
                foreach (var cont in entities.Containers)
                {
                    cont.nom = "Ntm";
                }
                entities.SaveChanges();
                Console.WriteLine("Suppression");
                foreach (var cont in entities.Containers)
                {
                    Console.WriteLine("nom : " + cont.nom);
                }
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }
    }
}
