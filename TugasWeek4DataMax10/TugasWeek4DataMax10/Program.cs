﻿using System;
using System.Windows.Forms;

namespace TugasWeek4DataMax10
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
            Application.Run(new Form_Penambahan_Data());
        }
    }
}
