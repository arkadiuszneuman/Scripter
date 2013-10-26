using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Skryper.View;

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
            Application.Run(new Frm_Skrypter());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Cl_ProgramMessages.ProgramMessages.Error(e.Exception.Message);
        }
    }
}
