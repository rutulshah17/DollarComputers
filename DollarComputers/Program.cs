/*
Application Name        : Dollar Computers
Author's Name           : Rutul Shah
Student ID              : 200329341 
Application Description : This application lets user to select from a 
                          wide range of computers and laptops along with hardware components. 
                          Open box laptops and computers are also available.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public static class Program
    {
        public static SplashForm MySplashForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //opening splash form on startup
            Program.MySplashForm = new SplashForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
