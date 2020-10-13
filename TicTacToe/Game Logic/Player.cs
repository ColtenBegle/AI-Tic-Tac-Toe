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
        public Player(string name, PlayerSymbols symbol)
        {
            Name = name;
            Symbol = symbol;
            Wins = 0;
        }

        public string Name { get; set; }

        public PlayerSymbols Symbol { get; set; }

        public int Wins { get; set; }
    }
}
