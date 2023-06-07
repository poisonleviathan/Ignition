using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ignition
{
    internal static class Program
    {
        ///Dinil was here
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///created the paymebt interface
        ///add payment methods to proceed interface
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Admin_Dashboard());
        }
    }
}
