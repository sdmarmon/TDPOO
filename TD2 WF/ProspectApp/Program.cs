using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace ProspectApp
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);

            // Utilise le Repository mémoire pour accéder aux prospects
            IProspectRepository prospectRepository =
                new MemoryProspectRepository();
            Application.Run(new MainForm(prospectRepository));
        }
    }
}
