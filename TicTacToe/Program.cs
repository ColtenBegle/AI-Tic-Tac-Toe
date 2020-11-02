using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.AI;
using TicTacToe.UI;
using TicTacToe.UI.LAN_Multiplayer;

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
            //Application.Run(new GameForm());
            //Application.Run(new MainScreen());
            GameForm1 game = new GameForm1(3);
            AIPlayer aIPlayer = new AIPlayer(PlayerSymbols.O, false, game.CheckState, game.IsFull);
            game.AI = aIPlayer;
            Application.Run(game);
        }
    }
}
