using System;
using System.ComponentModel;
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
            if (CheckState())
                return;
            FreezeBoard();
            if (_host != null)
            {
                _host.RecieveMove(grid.Cells);
                lblPlayerTurn.Text = string.Format("{0}'s turn", _host.Name);
                if (CheckState())
                {
                    lblOutcome.Text = string.Format("{0} wins!", _host.ClientUser);
                    lblOutcome.Visible = true;
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
                lblPlayerTurn.Text = string.Format("{0}'s turn", _client.Name);
                if (CheckState())
                {
                    string outcome = string.Format("{0} wins!", _client.HostUser);
                    lblOutcome.Text = outcome;
                    lblOutcome.Visible = true;
                    ResetCells();
                }
                else
                {
                    UnfreezeBoard();
                }
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
            lblPlayerTurn.Text = String.Format("{0}'s turn!", lblPlayer1.Text);
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

        private void ShowWinMessage(string value)
        {
            if (_ai != null)
            {
                if (value == PlayerSymbols.X.ToString())
                    MessageBox.Show(String.Format("{0} won!", player1.Name));
                else
                    MessageBox.Show(String.Format("{0} won!", _ai.Name));
            }
            else if (_client != null)
            {
                if (value == PlayerSymbols.X.ToString() && _client.Symbol == PlayerSymbols.X)
                    MessageBox.Show(String.Format("{0} won!", _client.Name));
                else if (value == PlayerSymbols.O.ToString() && _client.Symbol == PlayerSymbols.O)
                    MessageBox.Show(String.Format("{0} won!", _client.Name));
            }
            else if (_host != null)
            {
                if (value == PlayerSymbols.X.ToString() && _host.Symbol == PlayerSymbols.X)
                    MessageBox.Show(String.Format("{0} won!", _host.Name));
                else if (value == PlayerSymbols.O.ToString() && _host.Symbol == PlayerSymbols.O)
                    MessageBox.Show(String.Format("{0} won!", _host.Name));
            }
            else
            {
                if (value == PlayerSymbols.X.ToString())
                    MessageBox.Show(String.Format("{0} won!", player1.Name));
                else
                    MessageBox.Show(String.Format("{0} won!", player2.Name));
            }
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
                    PropertyInfo property = type.GetProperty("Text");
                    property.SetValue(sender, humanPlayer.Symbol.ToString());
                    property = type.GetProperty("Enabled");
                    property.SetValue(sender, false);
                    lblPlayerTurn.Text = "AI's turn!";
                    bool state = CheckState();
                    if (state == true)
                    {
                        lblOutcome.Text = String.Format("{0} wins!", humanPlayer.Name);
                        lblOutcome.Visible = true;
                        ResetCells();
                        humanPlayer.Wins += 1;
                    }
                    else
                    {
                        FreezeBoard();
                        _ai.MakeMove(_gridSize, grid.Cells);
                        state = CheckState();
                        if (state == true)
                        {
                            lblOutcome.Text = String.Format("{0} wins!", _ai.Name);
                            lblOutcome.Visible = true;
                            ResetCells();
                            _ai.Wins += 1;
                        }
                        else if (IsFull())
                        {
                                lblOutcome.Text = String.Format("It's a draw!");
                                lblOutcome.Visible = true;
                                ResetCells();
                        }
                        lblPlayerTurn.Text = String.Format("{0}'s turn!", lblPlayer1.Text);
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
                                byte[] bytes = { (byte)x, (byte)y };
                                _client.SendMove(bytes);
                                grid.Cells[x, y].Text = _client.Symbol.ToString();
                                lblPlayerTurn.Text = String.Format("{0}'s turn!", lblPlayer1.Text);
                                bool state = CheckState();
                                if (state == true)
                                {
                                    lblOutcome.Text = String.Format("{0} wins!", _client.Name);
                                    lblOutcome.Visible = true;
                                    ResetCells();
                                    _client.Wins += 1;
                                }
                                else if (IsFull())
                                {
                                    lblOutcome.Text = String.Format("It's a draw!");
                                    lblOutcome.Visible = true;
                                    ResetCells();
                                }

                                messageReciever.RunWorkerAsync();
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
                                byte[] bytes = { (byte)x, (byte)y };
                                _host.SendMove(bytes);
                                grid.Cells[x, y].Text = _host.Symbol.ToString();
                                bool state = CheckState();
                                lblPlayerTurn.Text = String.Format("{0}'s turn!", lblPlayer2.Text);
                                if (state == true)
                                {
                                    lblOutcome.Text = String.Format("{0} wins!", _host.Name);
                                    lblOutcome.Visible = true;
                                    ResetCells();
                                    _host.Wins += 1;
                                }
                                else if (IsFull())
                                {
                                    lblOutcome.Text = String.Format("It's a draw!");
                                    lblOutcome.Visible = true;
                                    ResetCells();
                                }
                                messageReciever.RunWorkerAsync();
                            }
                        }
                    }
                }
                else
                {
                    if (player1.IsTurn == true)
                    {
                        Type type = sender.GetType();
                        PropertyInfo property = type.GetProperty("Text");
                        property.SetValue(sender, player1.Symbol.ToString());
                        property = type.GetProperty("Enabled");
                        property.SetValue(sender, false);
                        bool state = CheckState();
                        if (state == true)
                        {
                            lblOutcome.Text = String.Format("{0} wins!", player1.Name);
                            lblOutcome.Visible = true;
                            ResetCells();
                            player1.Wins += 1;
                        }
                        else
                        {
                            bool isFull = IsFull();
                            if (isFull)
                            {
                                lblOutcome.Text = String.Format("It's a draw!");
                                lblOutcome.Visible = true;
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
                        PropertyInfo property = type.GetProperty("Text");
                        property.SetValue(sender, player2.Symbol.ToString());
                        property = type.GetProperty("Enabled");
                        property.SetValue(sender, false);
                        bool state = CheckState();
                        if (state == true)
                        {
                            lblOutcome.Text = String.Format("{0} wins!", player2.Name);
                            lblOutcome.Visible = true;
                            ResetCells();
                            player2.Wins += 1;
                        }
                        else
                        {
                            bool isFull = IsFull();
                            if (isFull)
                            {
                                lblOutcome.Text = String.Format("It's a draw!");
                                lblOutcome.Visible = true;
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
                    grid.Cells[x, y].Enabled = true;
                }
            }
        }
    }
}
