using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game_Logic.AI
{
    public class AIPlayer : Player
    {
        private const string _username = "AI";
        public AIPlayer(PlayerSymbols symbol, bool isTurn) : base(_username, symbol, isTurn)
        {

        }
    }
}
