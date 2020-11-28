using System;
using System.Windows.Forms;
using TicTacToe.UI;

namespace TicTacToe
{
    static class Program
    {
        // The main entry point for the application.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
