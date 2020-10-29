using System;
using System.ComponentModel;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.AI;
using TicTacToe.Game_Logic.LAN_Multiplayer;
using TicTacToe.UI;

namespace TicTacToe
{
    public partial class GameForm1 : Form
    {
        private int _gridSize;
        private Grid grid;
        public Grid Grid
        {
            get { return grid; }
            set { grid = value; }
        }
        //LAN Game variables
        private Client _client;
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        private Host _host;
        public Host Host
        {
            get { return _host; }
            set { _host = value; }
        }

        //AI Game variables
        private AIPlayer _ai;
        public AIPlayer AI
        {
            get { return _ai; }
            set { _ai = value; }
        }

        public GameForm1(int gridSize)
        {
            InitializeComponent();
            grid = new Grid(gridSize);
            GenerateGrid(gridSize);
            _gridSize = gridSize;
        }

        //Local multiplayer variables
        private Player player1 = new Player("Player 1", PlayerSymbols.X, true);
        private Player player2 = new Player("Player 2", PlayerSymbols.O, false);

        public bool CheckState()
        {
            //Vertical check
            for (int x = 0; x < _gridSize; x++)
            {
                if (grid.Cells[x, 0].Text == grid.Cells[x, 1].Text && 
                    grid.Cells[x, 1].Text == grid.Cells[x, 2].Text && 
                    grid.Cells[x, 2].Text != "")
                    return true;
            }
            //Horizontal check
            for (int y = 0; y < _gridSize; y++)
            {
                if (grid.Cells[0, y].Text == grid.Cells[1, y].Text &&
                    grid.Cells[1, y].Text == grid.Cells[2, y].Text &&
                    grid.Cells[2, y].Text != "")
                    return true;
            }
            //Left diagonal check
            string symbol = grid.Cells[0, 0].Text;
            for (int x = 0, y = 0; x < _gridSize && y < _gridSize; x++, y++)
            {
                if (grid.Cells[x, y].Text != symbol)
                    return false;
                if (x + 1 == _gridSize && y + 1 == _gridSize)
                    return true;
            }
            //Right diagnol check
            symbol = grid.Cells[_gridSize - 1, _gridSize - 1].Text;
            for (int x = _gridSize - 1, y = _gridSize - 1; x >= 0 && y >= 0; x--, y--)
            {
                if (grid.Cells[x, y].Text != symbol)
                    return false;
                if (x == 0 && y == 0)
                    return true;
            }
            return false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_host != null)
            {
                _host.KillHost();
            }
            if (_client != null)
            {
                _client.KillClient();
            }
        }

        public void CellClicked(object sender, EventArgs e)
        {
            if (_ai != null)
            {

            }
            else if (_client != null)
            {

            }
            else if (_host != null)
            {

            }
            else
            {
                if (player1.IsTurn == true)
                {
                    Type type = sender.GetType();
                    PropertyInfo property = type.GetProperty("Text");
                    property.SetValue(sender, player1.Symbol.ToString());
                    player1.IsTurn = false;
                    player2.IsTurn = true;
                }
                else
                {
                    Type type = sender.GetType();
                    PropertyInfo property = type.GetProperty("Text");
                    property.SetValue(sender, player2.Symbol.ToString());
                    player2.IsTurn = false;
                    player1.IsTurn = true;
                }
            }
        }
    }
}
