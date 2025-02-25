using EDDPlus.DB;
using EDDPlus.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SQLitePCL;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EDDPlus
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new eddplus().Database.EnsureCreated();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}