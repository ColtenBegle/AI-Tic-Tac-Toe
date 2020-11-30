using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TicTacToe.Game_Logic;
using TicTacToe.Game_Logic.AI;
using TicTacToe.Game_Logic.LAN_Multiplayer;
using TicTacToe.UI;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private int _gridSize;
        private Grid grid;

        //Symbols
        Bitmap XSymbol = new Bitmap(Properties.Resources.Symbol_X);
        Bitmap OSymbol = new Bitmap(Properties.Resources.Symbol_O);
        Bitmap CrownSymbol = new Bitmap(Properties.Resources.CrownSymbol);
        Bitmap BombSymbol = new Bitmap(Properties.Resources.BombSymbol);

         
        

        public Grid Grid
        {
            get { return grid; }
            set { grid = value; }
        }
        //LAN Game variables
        private BackgroundWorker messageReciever = new BackgroundWorker();
        private Client _client;
        public Client Client
        {
            get { return _client; }
            set { _client = value; messageReciever.DoWork += MessageReciever_DoWork; messageReciever.RunWorkerAsync(); }
        }

        private Host _host;
        public Host Host
        {
            get { return _host; }
            set { _host = value; messageReciever.DoWork += MessageReciever_DoWork; }
        }

        private void MessageReciever_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (CheckState())
                {
                    return;
                }
                
                FreezeBoard();
                if (_host != null)
                {
                    _host.RecieveMove(grid.Cells);
                    if (IsFull())
                    {
                        MessageBox.Show("It's a draw!");
                        ResetCells();
                        return;
                    }
                    if (CheckState())
                    {
                        MessageBox.Show(string.Format("{0} wins!", _host.ClientUser));
                        int player2Wins = int.Parse(player2WinsCount.Text);
                        player2WinsCount.Text = String.Format("{0}", player2Wins + 1);
                        ResetCells();
                    }
                    else
                    {
                        UnfreezeBoard();
                    }
                }
                else if (_client != null)
                {
                    _client.RecieveMove(grid.Cells);
                    if (IsFull())
                    {
                        MessageBox.Show("It's a draw!");
                        ResetCells();
                        return;
                    }
                    if (CheckState())
                    {
                        MessageBox.Show(string.Format("{0} wins!", _client.HostUser));
                        int player1Wins = int.Parse(player1WinsCount.Text);
                        player1WinsCount.Text = String.Format("{0}", player1Wins + 1);
                        ResetCells();
                    }
                    else
                    {
                        UnfreezeBoard();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        //AI Game variables
        private AIPlayer _ai;
        public AIPlayer AI
        {
            get { return _ai; }
            set { _ai = value; }
        }
        private Player humanPlayer = new Player("Player 1", PlayerSymbols.X, true);

        public GameForm(int gridSize)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            grid = new Grid(gridSize);
            GenerateGrid(gridSize);
            _gridSize = gridSize;
        }

        public void InitializePlayerNames(string player1Name, string player2Name)
        {
            lblPlayer1.Text = player1Name;
            lblPlayer2.Text = player2Name;
            player1Wins.Text = string.Format("{0}:", player1Name);
            lblPlayer2Wins.Text = string.Format("{0}:", player2Name);
        }



        //Local multiplayer variables
        private Player player1 = new Player("Player 1", PlayerSymbols.X, true);
        private Player player2 = new Player("Player 2", PlayerSymbols.O, false);

        public bool CheckState()
        {
            //Vertical check
            for (int x = 0; x < _gridSize; x++)
            {
                string prevVal = grid.Cells[x, 0].Text;
                for (int y = 0; y < _gridSize; y++)
                {
                    string value = grid.Cells[x, y].Text;
                    if (value == "")
                        break;
                    if (value != prevVal)
                        break;
                    if (y + 1 == _gridSize)
                        return true;
                    prevVal = value;
                }
            }
            //Horizontal check
            for (int y = 0; y < _gridSize; y++)
            {
                string prevVal = grid.Cells[0, y].Text;
                for (int x = 0; x < _gridSize; x++)
                {
                    string value = grid.Cells[x, y].Text;
                    if (value == "")
                        break;
                    if (value != prevVal)
                        break;
                    if (x + 1 == _gridSize)
                        return true;
                    prevVal = value;
                }
            }
            //Left diagonal check
            string symbol = grid.Cells[0, 0].Text;
            for (int x = 0, y = 0; x < _gridSize && y < _gridSize; x++, y++)
            {
                if (symbol == "")
                    break;
                if (grid.Cells[x, y].Text != symbol)
                    break;
                if (x + 1 == _gridSize && y + 1 == _gridSize)
                    return true;
            }
            //Right diagnol check
            symbol = grid.Cells[_gridSize - 1, 0].Text;
            for (int x = _gridSize - 1, y = 0; x >= 0 && y < _gridSize; x--, y++)
            {
                if (symbol == "")
                    break;
                if (grid.Cells[x, y].Text != symbol)
                    break;
                if (x == 0 && y + 1 == _gridSize)
                    return true;
            }
            return false;
        }

        public bool IsFull()
        {
            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    if (String.IsNullOrEmpty(grid.Cells[x, y].Text))
                        return false;
                }
            }
            return true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            try
            {
                if (_ai != null)
                {
                    Type type = sender.GetType();
                    //PropertyInfo property = type.GetProperty("Text");
                    //property.SetValue(sender, humanPlayer.Symbol.ToString());
                    //property = type.GetProperty("Enabled");
                    //property.SetValue(sender, false);
                    for (int x = 0; x < _gridSize; x++)
                    {
                        for (int y = 0; y < _gridSize; y++)
                        {
                            if (grid.Cells[x, y] == (Button)sender)
                            {
                                grid.Cells[x, y].Text = humanPlayer.Symbol.ToString();
                                
                                grid.Cells[x, y].Image = XSymbol;
                                
                            }
                        }
                    }
                    bool state = CheckState();
                    if (state == true)
                    {
                        MessageBox.Show(String.Format("{0} wins!", humanPlayer.Name));
                        humanPlayer.Wins += 1;
                        player1WinsCount.Text = humanPlayer.Wins.ToString();
                        ResetCells();
                    }
                    else
                    {
                        FreezeBoard();
                        _ai.MakeMove(_gridSize, grid.Cells);
                        state = CheckState();
                        if (state == true)
                        {
                            MessageBox.Show(string.Format("{0} wins!", _ai.Name));
                            _ai.Wins += 1;
                            player2WinsCount.Text = _ai.Wins.ToString();
                            ResetCells();
                        }
                        else if (IsFull())
                        {
                            MessageBox.Show("It's a draw!");
                            ResetCells();
                        }
                        UnfreezeBoard();
                    }
                }
                else if (_client != null)
                {
                    for (int x = 0; x < _gridSize; x++)
                    {
                        for (int y = 0; y < _gridSize; y++)
                        {
                            if (grid.Cells[x, y] == (Button)sender)
                            {
                                try
                                {
                                    byte[] bytes = { (byte)x, (byte)y };

                                    _client.SendMove(bytes);
                                    grid.Cells[x, y].Text = _client.Symbol.ToString();
                                    grid.Cells[x, y].Image = XSymbol;

                                    bool state = CheckState();
                                    if (state == true)
                                    {
                                        MessageBox.Show(string.Format("{0} wins!", _client.Name));
                                        _client.Wins += 1;
                                        player2WinsCount.Text = _client.Wins.ToString();
                                        ResetCells();
                                    }
                                    else if (IsFull())
                                    {
                                        MessageBox.Show("It's a draw!");
                                        ; ResetCells();
                                    }
                                    messageReciever.RunWorkerAsync();
                                }
                                catch (Exception exc)
                                {
                                    MessageBox.Show(exc.Message);
                                    this.Close();
                                }
                                
                            }
                        }
                    }
                }
                else if (_host != null)
                {
                    for (int x = 0; x < _gridSize; x++)
                    {
                        for (int y = 0; y < _gridSize; y++)
                        {
                            if (grid.Cells[x, y] == (Button)sender)
                            {
                                try
                                {
                                    byte[] bytes = { (byte)x, (byte)y };
                                    _host.SendMove(bytes);
                                    grid.Cells[x, y].Text = _host.Symbol.ToString();
                                    grid.Cells[x, y].Image = XSymbol;
                                    bool state = CheckState();
                                    if (state == true)
                                    {
                                        MessageBox.Show(string.Format("{0} wins!", _host.Name));
                                        _host.Wins += 1;
                                        player1WinsCount.Text = _host.Wins.ToString();
                                        ResetCells();
                                    }
                                    else if (IsFull())
                                    {
                                        MessageBox.Show("It's a draw");
                                        ResetCells();
                                    }
                                    messageReciever.RunWorkerAsync();
                                } 
                                catch (Exception exc)
                                {
                                    MessageBox.Show(exc.Message);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (player1.IsTurn == true)
                    {
                        Type type = sender.GetType();
                        //PropertyInfo property = type.GetProperty("Text");
                        //property.SetValue(sender, player1.Symbol.ToString());
                        //property = type.GetProperty("Enabled");
                        //property.SetValue(sender, false);
                        for (int x = 0; x < _gridSize; x++)
                        {
                            for (int y = 0; y < _gridSize; y++)
                            {
                                if (grid.Cells[x, y] == (Button)sender)
                                {
                                    grid.Cells[x, y].Text = player1.Symbol.ToString();

                                    grid.Cells[x, y].Image = XSymbol;

                                }
                            }
                        }
                        bool state = CheckState();
                        if (state == true)
                        {
                            MessageBox.Show(string.Format("{0} wins!", player1.Name));
                            player1.Wins += 1;
                            player1WinsCount.Text = player1.Wins.ToString();
                            ResetCells();
                        }
                        else
                        {
                            bool isFull = IsFull();
                            if (isFull)
                            {
                                MessageBox.Show("It's a draw!");
                                ResetCells();
                            }
                            else
                            {
                                player1.IsTurn = false;
                                player2.IsTurn = true;
                            }
                        }
                    }
                    else
                    {
                        Type type = sender.GetType();
                        //PropertyInfo property = type.GetProperty("Text");
                        //property.SetValue(sender, player2.Symbol.ToString());
                        //property = type.GetProperty("Enabled");
                        //property.SetValue(sender, false);
                        for (int x = 0; x < _gridSize; x++)
                        {
                            for (int y = 0; y < _gridSize; y++)
                            {
                                if (grid.Cells[x, y] == (Button)sender)
                                {
                                    grid.Cells[x, y].Text = player2.Symbol.ToString();

                                    grid.Cells[x, y].Image = OSymbol;

                                }
                            }
                        }
                        bool state = CheckState();
                        if (state == true)
                        {
                            MessageBox.Show(string.Format("{0} wins!", player2.Name));
                            player2.Wins += 1;
                            player2WinsCount.Text = player2.Wins.ToString();
                            ResetCells();
                        }
                        else
                        {
                            bool isFull = IsFull();
                            if (isFull)
                            {
                                MessageBox.Show("It's a draw!");
                                ResetCells();
                            }
                            else
                            {
                                player2.IsTurn = false;
                                player1.IsTurn = true;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FreezeBoard()
        {
            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    grid.Cells[x, y].Enabled = false;
                    
                }
            }
        }

        private void UnfreezeBoard()
        {
            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    if (grid.Cells[x, y].Text == "")
                        grid.Cells[x, y].Enabled = true;
                    else
                        grid.Cells[x, y].Enabled = false;
                }
            }
        }

        private void ResetCells()
        {
            for (int x = 0; x < _gridSize; x++)
            {
                for (int y = 0; y < _gridSize; y++)
                {
                    grid.Cells[x, y].Text = "";
                    grid.Cells[x, y].Image = null;
                    grid.Cells[x, y].Enabled = true;
                }
            }
        }
    }
}
