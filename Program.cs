﻿using System;
using System.Windows.Forms;

namespace ProjectHotel_UAS_PAD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //Application.Run(new FormCheckoutReport("NOTA19052024132012"));
        }
    }
}
