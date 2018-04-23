using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XtraVerticalGridNavigation
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
            SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }
    }
}
