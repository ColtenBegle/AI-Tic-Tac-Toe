using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game_Logic
{
    public enum PlayerSymbols
    {
        X,
        O
    }
    public class Player
    {
        public Player(string name, PlayerSymbols symbol, bool isTurn)
        {
            Name = name;
            Symbol = symbol;
            Wins = 0;
            IsTurn = isTurn;
        }

        public bool IsTurn { get; set; }

        public string Name { get; set; }

        public PlayerSymbols Symbol { get; set; }

        public int Wins { get; set; }
    }
}
