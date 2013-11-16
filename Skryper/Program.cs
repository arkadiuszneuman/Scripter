using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Skryper.StartUp.View;
using Skryper.View;
using Skryper.Utilities;

namespace Skryper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException, true);
            Application.ThreadException += Application_ThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_StartUpPanel());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Cl_Messages.Messages.Error(e.Exception.Message);
        }
    }
}
