using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementApp
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
            //string oradb = "DATA SOURCE=127.0.0.1:1521/hospital;PERSIST SECURITY INFO=True;USER ID=MANAGER; PASSWORD= Oracle_1;";
            //OracleConnection conn = new OracleConnection(oradb);  // C
            //conn.Open();
            //Application.Run(new MainForm(conn));
            Application.Run(new LoginForm());
        }
    }
}
