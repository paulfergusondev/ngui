using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngui
{
    static class Program
    {
        static main mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            mainForm = new main(new ngrok.ngrok().GetSavedTunnels());
            Application.Run(mainForm);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            new ngrok.ngrok().SaveTunnels(mainForm._tunnels);
        }
    }
}
