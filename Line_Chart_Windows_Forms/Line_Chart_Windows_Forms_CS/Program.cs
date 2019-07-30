using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ECG
{
    static class Program
    {
        public static int loginflg = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
		{
        //static void Main()
        //{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
           Application.Run(new ECG.Login());
           if (loginflg == 1)
            {
                Application.Run(new MainForm());
                Application.Run(new Main());
            }
        }
    }
}
