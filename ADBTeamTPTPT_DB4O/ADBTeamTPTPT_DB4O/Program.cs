using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBTeamTPTPT_DB4O
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            IObjectContainer db = Db4oEmbedded.OpenFile("ADBTeamTPTPT_EmployeeManage.yap");

            db.Close();
        }
    }
}
