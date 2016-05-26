﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PokemonEncCalc
{

    static class Program
    {

        internal readonly static string version = "5.6";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.Language == 0)
                detectSystemLanguage();

            // Load data
            Utils.initializePokemonList();
            Utils.loadEncounterSlotData();
            
            Application.Run(new frmMainPage());
        }

        static void detectSystemLanguage()
        {
            if (CultureInfo.CurrentUICulture.Name.StartsWith("fr"))
                Properties.Settings.Default.Language = 2;
            else
                Properties.Settings.Default.Language = 1;
        }

    }
}