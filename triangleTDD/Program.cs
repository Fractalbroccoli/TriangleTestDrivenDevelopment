// File        : Program.cs
// Author      : Ricardo Mohammed
// Project     : Test Driven Development - Software Quality A4
// Date        : December 6th, 2017
// Description : Contains the main entry point for the Triangle program.
//               The program includes unit testing for triangle attribute methods.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangleTDD
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
            Application.Run(new Form1());
        }
    }
}
