using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleTechModParser
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
            ParserTest.enable();
            ParserTest.disable();
            //Parser.PatchFile(@"C:\Users\Yoni\Downloads\VersionManifest.csv", false);
            Application.Run(new Form1());
        }
    }
}
