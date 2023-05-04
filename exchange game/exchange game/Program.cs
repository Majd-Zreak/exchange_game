using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace exchange_game
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
            Application.Run(new presentationLay.main_form());
        
            //Application.Run(new presentationLay.trading_order());
        }
    }
}
