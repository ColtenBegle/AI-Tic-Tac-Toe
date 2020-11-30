using System.Drawing;

namespace TicTacToe.Game_Logic
{
    public enum PlayerSymbols
    {
        X,
        O
    }
    public class Player
    {
        private Bitmap XSymbol = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap CrownSymbol = new Bitmap(Properties.Resources.CrownSymbol);
        Bitmap BombSymbol = new Bitmap(Properties.Resources.BombSymbol);
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
